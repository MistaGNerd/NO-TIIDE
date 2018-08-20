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

            foreach (byte b in byteList)
            {
                allbytes += _83FileFormat.ByteToKeyword(b);
            }
            return allbytes; ;
        }

        #endregion Public Methods
    }
}