using System;
using System.Collections.Generic;
using System.IO;


namespace TICalcLibrary
{
    public class TI83Model
    {
        /// <summary>
        /// Use this file offset to get the file type (2 Bytes) from the TI-83 program file. 
        /// This should read [**TI83**] or [**TI8F*}
        /// </summary>
        public int TypeOffset { get; } = 0;

        /// Use the file offset to get the file type (2 Bytes) from the TI-83 program file. 
        /// This should read [**TI83**] or [**TI8F*}
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Use this file offset to get the comment (40 Bytes) from the TI-83 program file.
        /// </summary>
        public int CommentOffset { get; } = 11;

        /// <summary>
        /// Use the file offset to get the comment (40 Bytes) from the TI-83 program file.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Use the Data Length Offset to get the Data Length from the TI-83 program file.
        /// </summary>
        public int DataLengthOffset { get; } = 70;

        /// <summary>
        /// Use the Data Length Offset to get the Data Length from the TI-83 program file.
        /// </summary>
        public int DataLength { get; set; }

        /// <summary>
        /// Use the Name Offset to get the Name from the TI-83 program file.
        /// </summary>
        public int NameOffset { get; } = 60;

        /// <summary>
        /// Used with the NameOffset to get the Name from the TI-83 program file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Used to get the Data Offset to get the Data from the TI-83 program file.
        /// </summary>
        public int DataOffset { get; } = 72;

        /// <summary>
        /// Used with the DataOffset to get the Data from the TI-83 program file.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Get the file offset for the Protect Flag. 
        /// </summary>
        public int ProtectFlagOffset { get; } = 59;

        /// <summary>
        /// Used to get or set the boolan status of the Protect Flag from the TI-83 program file.
        /// </summary>
        public bool ProtectFlag { get; set; } = false;

        /// <summary>
        /// Used to get or set the checksum from the TI-83 program file.
        /// </summary>
        public byte[] Checksum { get; set; }
        public string AssociatedFileName { get; set; } = " ";
    }
}
