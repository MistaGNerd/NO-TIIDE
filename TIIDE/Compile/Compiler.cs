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

        internal static List<byte> loadBytes(BinaryReader binaryReader)
        {
            bool reading = true;
            List<byte> byteList = new List<byte>();

            Console.WriteLine("Starting byte read.");
            while (reading)
            {
                try
                {
                    byte b = binaryReader.ReadByte();
                    byteList.Add(b);
                    Console.WriteLine("Reading byte {0}", b.ToString("X2"));
                    //_83FileFormat.ByteToKeyword(b);
                }
                catch
                {
                    reading = false;
                }
            }
            Console.WriteLine("Completed byte read.");
            Console.WriteLine("All Bytes Loaded.");

            return byteList;
        }

        internal static string ReverseCompile(BinaryReader binaryReader, int dataSize)
        {
            List<byte> byteList = loadBytes(binaryReader);

            // We should use the header info. See here: https://www.ticalc.org/pub/text/calcinfo/83pformat.txt
            // TODO: Use checksum info on load to check for errors

            string allbytes = "";
            // Program data begins at 0x50 (74)
            try
            {   // Iterate through bytes
                for (int i = 74; i <= dataSize + 200; i++)
                    //  Branch and send two bytes if needed
                    if (byteList[i].Equals(0xBB) || byteList[i].Equals(0xAA) || byteList[i].Equals(0x5C) || byteList[i].Equals(0x5D) || byteList[i].Equals(0x5E) || byteList[i].Equals(0x60) || byteList[i].Equals(0x61) || byteList[i].Equals(0x62) || byteList[i].Equals(0x63) || byteList[i].Equals(0x7E))
                    {
                        allbytes += _83FileFormat.BytesToKeyword(byteList[i], byteList[i+1]);
                        i++;
                    }
                    else
                    {
                        allbytes += _83FileFormat.ByteToKeyword(byteList[i]);
                    }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            return allbytes; ;
        }

        internal static int GetDataSize(BinaryReader binaryReader)
        {
            List<byte> byteList = loadBytes(binaryReader);

            // Load the data size information from 0x
            byte[] dataSizeBytes = { byteList[57], byteList[58] };
            int dataSize = BitConverter.ToUInt16(dataSizeBytes, 0);
            Console.WriteLine("Data Size: {0} bytes", dataSize);

            return dataSize;
        }

        internal static string GetComment(BinaryReader binaryReader)
        {
            List<byte> byteList = loadBytes(binaryReader);

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
            List<byte> byteList = loadBytes(binaryReader);

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