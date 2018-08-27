﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace TIIDE.Compile
{
    internal class _83FileFormat
    {
        #region Private Fields

        #endregion Private Fields

        #region Public Methods

        public static string BytesToString(byte b1, byte b2)
        {
            //var token = SqliteDataAccess.FindTokenByHex(b1.ToString(), b2.ToString())[0];
            Console.WriteLine(b1.ToString(), b2.ToString());
            //return token.String;
            return "?";
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
                int integer = i;
                i = ((i << 8) | (i >> 8)) & 0xFFFF;
                Console.WriteLine("ERROR: Attempt to access integer {0} | hex {1} in database failed.", integer, i.ToString("x4"));
                return "[?|" + i.ToString("X4") +"]";
            }
        }
       
        // Untested
        public static byte StringToByte(string s)
        {
            var token = SqliteDataAccess.FindTokenByString(s)[0];
            string b = token.HighByte + token.LowByte;
            return Convert.ToByte(b, 16);
        }
    }
    #endregion Public Methods
}