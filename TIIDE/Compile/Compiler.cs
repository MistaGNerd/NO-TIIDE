using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
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
                    byteList.Add(binaryReader.ReadByte());
                }
                catch
                {
                    reading = false;
                }
            }
            Console.WriteLine("LoadBytes(): Completed byte read.");

            return byteList;
        }

        internal static string ReverseCompile(List<byte> byteList)
        {
            int tokenInteger = 0;
            string allbytes = "";
            try
            {   // Iterate through bytes
                for (int i = 0; i < byteList.Count; i++)
                {
                    // If the first byte does not match here, branch to else and assume the first byte is 0x00.
                    if (byteList [i].Equals(0xBB) || byteList [i].Equals(0xAA) || byteList [i].Equals(0x5C) ||
                        byteList [i].Equals(0x5D) || byteList [i].Equals(0x5E) || byteList [i].Equals(0x60) ||
                        byteList [i].Equals(0x61) || byteList [i].Equals(0x62) || byteList [i].Equals(0x63) ||
                        byteList [i].Equals(0x7E) || byteList [i].Equals(0xEF))
                    {
                        // Combine the two bytes into an integer
                        tokenInteger = (byteList [i] << 8) + byteList [i + 1];
                        // Since we already read in the next byte, we increment our pointer by one to skip it.
                        i++;
                    }
                    else
                    {
                        // Assume that the first byte is 0x00 and combine it with the current byte.
                        tokenInteger = (0x00 << 8) + byteList [i];
                    }
                    // Get the string from the database and append it to the variable
                    allbytes += IntegerToString(tokenInteger);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ReverseCompile(): Argument out of range! Are we losing data?");
            }

            //Console.WriteLine("First byte: {0} - {1}", byteList[0], byteList[0].ToString("X2"));
            return allbytes;
        }

        internal static async Task<string> ReverseCompileAsync(List<byte> byteList, IProgress<ProgressReportModel> progress)
        {
            ProgressReportModel report = new ProgressReportModel();
            int tokenInteger = 0;
            string allbytes = "";

            try
            {   // Iterate through bytes
                for (int i = 0; i < byteList.Count; i++)
                {
                    // If the first byte does not match here, branch to else and assume the first byte is 0x00.
                    if (byteList [i].Equals(0xBB) || byteList [i].Equals(0xAA) || byteList [i].Equals(0x5C) ||
                        byteList [i].Equals(0x5D) || byteList [i].Equals(0x5E) || byteList [i].Equals(0x60) ||
                        byteList [i].Equals(0x61) || byteList [i].Equals(0x62) || byteList [i].Equals(0x63) ||
                        byteList [i].Equals(0x7E) || byteList [i].Equals(0xEF))
                    {
                        // Combine the two bytes into an integer
                        tokenInteger = (byteList [i] << 8) + byteList [i + 1];
                        // Since we already read in the next byte, we increment our pointer by one to skip it.
                        i++;
                    }
                    else
                    {
                        // Assume that the first byte is 0x00 and combine it with the current byte.
                        tokenInteger = (0x00 << 8) + byteList [i];
                    }
                    // Get the string from the database and append it to the variable
                    allbytes += await Task.Run(() => IntegerToString(tokenInteger));
                    report.PercentageComplete = (i * 100) / byteList.Count;
                    progress.Report(report);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ReverseCompile(): Argument out of range! Are we losing data?");
            }

            //Console.WriteLine("First byte: {0} - {1}", byteList[0], byteList[0].ToString("X2"));
            return allbytes;
        }

        internal static TI83Model GetTI83Object(BinaryReader binaryReader)
        {
            List<byte> byteList = LoadBytes(binaryReader);

            // Create *83p file object
            TI83Model file83 = new TI83Model();

            // Load program [Type] and [Program Name]
            byte[] prgmTypeBytes = new byte[8];
            byte[] prgmNameBytes = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                prgmTypeBytes [i] = byteList [i + file83.TypeOffset];
                prgmNameBytes [i] = byteList [i + file83.NameOffset];
            }
            file83.Type = Encoding.ASCII.GetString(prgmTypeBytes);
            file83.Name = Encoding.ASCII.GetString(prgmNameBytes);

            // Load program [Comment]
            byte[] prgmCommentBytes = new byte[40];
            for (int i = 0; i < 40; i++)
                prgmCommentBytes [i] = byteList [i + file83.CommentOffset];
            file83.Comment = Encoding.ASCII.GetString(prgmCommentBytes);

            // Load program [Data Length] (size in bytes)
            byte[] prgmDataLength = new byte[2];
            for (int i = 0; i < 2; i++)
                prgmDataLength [i] = byteList [i + file83.DataLengthOffset];
            file83.DataLength = (prgmDataLength [1] << 8) + prgmDataLength [0];

            // Load program [Data]
            //List<byte> prgmData = new List<byte>();
            byte[] prgmData = new byte[file83.DataLength];
            for (int i = 2; i < (file83.DataLength); i++)
                prgmData [i] = byteList [i + file83.DataOffset];
            file83.Data = prgmData;

            // Load program [ProtectFlag]
            if (byteList [file83.ProtectFlagOffset].Equals(6))
                file83.ProtectFlag = true;
            else
                file83.ProtectFlag = false;

            // Load program [Checksum]
            byte[] prgmChecksum = new byte[16];
            int checksumOffset = file83.DataLength - 16;
            for (int i = 0; i < 16; i++)
                prgmChecksum [i] = byteList [i + checksumOffset];
            file83.Checksum = prgmChecksum;

            return file83;
        }

        public static string IntegerToString(int i)
        {
            try
            {
                var token = SqliteDataAccess.FindTokenByInteger(i)[0];
                return token.String;
            }
            catch
            {
                Console.WriteLine("ERROR: Attempt to access integer {0} | hex {1} in database failed.", i, i.ToString("x4"));
                return "[?|" + i.ToString("X4") + "]";
            }
        }

        // TODO: THIS IS INCOMPLETE
        public static string BytesToString(byte b1, byte b2)
        {
            //var token = SqliteDataAccess.FindTokenByHex(b1.ToString(), b2.ToString())[0];
            Console.WriteLine(b1.ToString(), b2.ToString());
            //return token.String;
            return "?";
        }

        // TODO: THIS IS INCOMPLETE
        public static byte StringToByte(string s)
        {
            var token = SqliteDataAccess.FindTokenByString(s)[0];
            string b = token.HighByte + token.LowByte;
            return Convert.ToByte(b, 16);
        }

        #endregion Public Methods
    }
}