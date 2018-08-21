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
                    //
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

        internal static string ReverseCompile(BinaryReader binaryReader)
        {
            List<byte> byteList = loadBytes(binaryReader);
            string allbytes = "";
            int byteCount = byteList.Count;
            for (int i = 0; i < byteCount; i++)
            {
                if (!_83FileFormat.DoesByteDenoteTwoByteToken(byteList[i]))
                {
                    allbytes += _83FileFormat.SingleByteToKeyword(byteList[i]);
                }
                else
                {
                    allbytes += _83FileFormat.DualByteToKeyword(byteList[i], byteList[i + 1]);
                    i++;
                }
            }

            //foreach (byte b in byteList)
            //{
            //    allbytes += _83FileFormat.ByteToKeyword(b);
            //}

            Console.WriteLine("First byte: {0} - {1}", byteList[0], byteList[0].ToString("X2"));
            return allbytes;
        }

        #endregion Public Methods
    }
}