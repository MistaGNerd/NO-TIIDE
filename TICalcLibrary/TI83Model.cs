using System;
using System.Collections.Generic;
using System.IO;

// TODO: Finish comments in this file

namespace TICalcLibrary
{
    public class TI83Model
    {
        /// <summary>
        /// Use this file offset to grab the file type (2 Bytes) from the TI-83 program file. 
        /// This should read [**TI83**] or [**TI8F*}
        /// </summary>
        public int TypeOffset { get; } = 0;

        /// Use the file offset to grab the file type (2 Bytes) from the TI-83 program file. 
        /// This should read [**TI83**] or [**TI8F*}
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Use this file offset to grab the comment (40 Bytes) from the TI-83 program file.
        /// </summary>
        public int CommentOffset { get; } = 11;

        /// <summary>
        /// Use the file offset to grab the comment (40 Bytes) from the TI-83 program file.
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
