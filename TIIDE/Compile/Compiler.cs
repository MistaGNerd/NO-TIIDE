using System;
using System.Collections.Generic;
using System.IO;

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

        internal static string ReverseCompile(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);
            // We should use the header info. See here: https://www.ticalc.org/pub/text/calcinfo/83pformat.txt
            // TODO: Use checksum info on load to check for errors
            int tokenInteger = 0;
            string allbytes = "";
            // Program data begins at 0x50 (74), maybe?... 
            // Perhaps the variable header alters the data start location?
            try
            {   // Iterate through bytes
                for (int i = 73; i <= byteList.Count - 4; i++)
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
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ReverseCompile(): Argument out of range! Are we losing data?");
                //Console.WriteLine(e);
            }

            //Console.WriteLine("First byte: {0} - {1}", byteList[0], byteList[0].ToString("X2"));
            return allbytes;
        }

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
            string prgmName = System.Text.Encoding.ASCII.GetString(prgmNameBytes);
            Console.WriteLine("Program Name: {0}", prgmName);

            return prgmName;
        }
            #endregion Public Methods
    }
}