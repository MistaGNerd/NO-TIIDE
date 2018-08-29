using System;
using System.Collections.Generic;
using System.IO;

namespace TICalcLibrary
{
    public class TI83Model
    {
        /// <summary>
        /// Use this file offset to grab the file type from the TI-83 program file to verify that it's a TI-83 compatable file.
        /// This should read [**TI83**] or [**TI8F*}
        /// </summary>
        public int TypeOffset { get; } = 0;

        /// <summary>
        /// The Type length is 8 bytes.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Use this file offset to grab the comment from the TI-83 program file.
        /// </summary>
        public int CommentOffset { get; } = 11;

        /// <summary>
        /// The comment length is 40 bytes. 
        /// </summary>
        public string Comment { get; set; }


        public int DataLengthOffset { get; } = 70;
        public int DataLength { get; set; }

        public int NameOffset { get; } = 60;
        public string Name { get; set; }

        public int DataOffset { get; } = 72;
        public byte[] Data { get; set; }

        public int ProtectFlagOffset { get; } = 59;
        public bool ProtectFlag { get; set; } = false;

        public byte[] Checksum { get; set; }
        public string AssociatedFileName { get; set; } = " ";
    }
}
