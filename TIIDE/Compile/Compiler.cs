using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TICalcLibrary;

namespace TIIDE.Compile
{
    internal class Compiler
    {
        #region Public Enums

        internal List<byte> _bytes = new List<byte>();

        internal enum TargetBuild { }

        #endregion Public Enums

        #region Public Methods

        public void Compile()
        {
        }

        internal static List<byte> LoadBytes(BinaryReader binaryReader)
        {
            bool reading = true;
            List<byte> byteList = new List<byte>();

            Console.WriteLine("LoadBytes(): Starting byte read.");
            while (reading)
            {
                try
                {
                    byte b = binaryReader.ReadByte();
                    byteList.Add(b);
                    //Console.WriteLine("Reading byte {0}", b.ToString("X2"));
                }
                catch
                {
                    reading = false;
                }
            }
            Console.WriteLine("LoadBytes(): Completed byte read.");
            //Console.WriteLine("All Bytes Loaded.");

            return byteList;
        }

        internal static string ReverseCompile(List<byte> byteList)
        {
            //List<byte> byteList = LoadBytes(binaryReader);

            // We should use the header info. See here: https://www.ticalc.org/pub/text/calcinfo/83pformat.txt
            // TODO: Use checksum info on load to check for errors
            int tokenInteger = 0;
            string allbytes = "";
            // Program data begins at 0x50 (74), maybe?... 
            // Perhaps the variable header alters the data start location?
            try
            {   // Iterate through bytes
                for (int i = 0; i < byteList.Count; i++)
                {
                    // Branch to else and assume the first byte is 0x00 if it does not match here.
                    if (byteList[i].Equals(0xBB) || byteList[i].Equals(0xAA) || byteList[i].Equals(0x5C) || 
                        byteList[i].Equals(0x5D) || byteList[i].Equals(0x5E) || byteList[i].Equals(0x60) ||
                        byteList[i].Equals(0x61) || byteList[i].Equals(0x62) || byteList[i].Equals(0x63) || 
                        byteList[i].Equals(0x7E) || byteList[i].Equals(0xEF))
                    {
                        // Combine the two bytes into an integer
                        tokenInteger = (byteList[i] << 8) + byteList[i + 1];
                        // Since we already read in the next byte, we increment by one to skip it.
                        i++;
                    }
                    else
                    {
                        // Assume that the first byte is 0x00 and combine it with the current byte.
                        tokenInteger = (0x00 << 8) + byteList[i];
                    }
                    // Get the string from the database and append it to the variable
                    //Console.WriteLine(tokenInteger);
                    allbytes += _83FileFormat.IntegerToString(tokenInteger);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ReverseCompile(): Argument out of range! Are we losing data?");
            }

            //Console.WriteLine("First byte: {0} - {1}", byteList[0], byteList[0].ToString("X2"));
            return allbytes;
        }
        /*
        internal static int GetDataSize(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);

            // Load the data size information from 0x
            byte[] dataSizeBytes = { byteList[57], byteList[58] };
            int dataSize = BitConverter.ToUInt16(dataSizeBytes, 0);
            Console.WriteLine("Data Size: {0} bytes", dataSize);

            return dataSize;
        }

        internal static string GetComment(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);

            // Load the comment from 0x0B - 0x34 (40 bytes)
            byte[] commentBytes = new byte[50];
            int i2 = 0;
            for (byte b = 0x0b; b <= 0x34; b++)
            {
                commentBytes[i2] = byteList[b];
                i2++;
            }
            string comment = System.Text.Encoding.ASCII.GetString(commentBytes);
            Console.WriteLine("Comment: {0}", comment);
            return comment;
        }

        internal static string GetProgramName(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);

            // Load the program name from 0x3c - 0x43 (8 bytes)
            byte[] prgmNameBytes = new byte[8];
            int i1 = 0;
            for (byte b = 0x3c; b <= 0x43; b++)
            {
                prgmNameBytes[i1] = byteList[b];
                i1++;
            }
            string prgmName = Encoding.ASCII.GetString(prgmNameBytes);
            Console.WriteLine("Program Name: {0}", prgmName);

            return prgmName;
        }
        */
        

        internal static TI83Model Decompile(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);

            // Create *83p file object
            TI83Model file83 = new TI83Model();

            // Load program [Type] and [Program Name]
            byte[] prgmTypeBytes = new byte[8];
            byte[] prgmNameBytes = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                prgmTypeBytes[i] = byteList[i + file83.TypeOffset];
                prgmNameBytes[i] = byteList[i + file83.NameOffset];
            }
            file83.Type = Encoding.ASCII.GetString(prgmTypeBytes);
            file83.Name = Encoding.ASCII.GetString(prgmNameBytes);

            // Load program [Comment]
            byte[] prgmCommentBytes = new byte[40];
            for (int i = 0; i < 40; i++)
                prgmCommentBytes[i] = byteList[i + file83.CommentOffset];
            file83.Comment = Encoding.ASCII.GetString(prgmCommentBytes);

            // Load program [Data Length] (size in bytes)
            byte[] prgmDataLength = new byte[2];
            for (int i = 0; i < 2; i++)
                prgmDataLength[i] = byteList[i + file83.DataLengthOffset];
            file83.DataLength = (prgmDataLength[1] << 8) + prgmDataLength[0];

            // Load program [Data]
            //List<byte> prgmData = new List<byte>();
            byte[] prgmData = new byte[file83.DataLength];
            for (int i = 2; i < (file83.DataLength); i++)
                prgmData[i] = byteList[i + file83.DataOffset];
            file83.Data = prgmData;

            // Load program [ProtectFlag]
            if (byteList[file83.ProtectFlagOffset].Equals(6))
                file83.ProtectFlag = true;
            else
                file83.ProtectFlag = false;

            // Load program [Checksum]
            byte[] prgmChecksum = new byte[16];
            int checksumOffset = file83.DataLength - 16;
            for (int i = 0; i < 16; i++)
                prgmChecksum[i] = byteList[i + checksumOffset];
            file83.Checksum = prgmChecksum;

            return file83;
        }
            #endregion Public Methods
    }
}