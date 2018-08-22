using System;
using System.Collections.Generic;
using System.Linq;


namespace TIIDE.Compile
{
    internal class _83FileFormat
    {
        #region Private Fields
        // Define tokens for single bytes (0x00 - 0xFF)
        private static IDictionary<byte, string> baseKeywordDictionary = new Dictionary<byte, string>()
        {
            {0x00, ""}, {0x01, "►DMS"}, {0x02, "►Dec"}, {0x03, "►Frac"}, {0x04, "→"}, {0x05, "Boxplot"}, {0x06, "["}, {0x07, "]"}, {0x08, "{"}, {0x09, "}"}, {0x0A, "r"}, {0x0B, "°"}, {0x0C, "¹"}, {0x0D, "²"}, {0x0E, "T"}, {0x0F, "³"},
            {0x10, "(" }, {0x11, ")" }, {0x12, "round(" }, {0x13, "pxl-Test" }, {0x14, "augment(" }, {0x15, "rowSwap(" }, {0x16, "row+(" }, {0x17, "*row(" }, {0x18, "*row+(" }, {0x19, "max(" }, {0x1A, "min(" }, {0x1B, "R►Pr(" }, {0x1C, "R►Pθ(" }, {0x1D, "P►Rx(" }, {0x1E, "P►Ry("}, {0x1F, "median(" },
            {0x20,  "randM("}, {0x21,  "mean("}, {0x22, "solve("}, {0x23, "seq("}, {0x24, "fnint("}, {0x25, "nDeriv"}, {0x26, ""}, {0x27, "fMin("}, {0x28, "fMax"}, {0x29, " "}, {0x2A, "\""}, {0x2B, ","}, {0x2C, "i"}, {0x2D, "!"}, {0x2E, "CubicReg"}, {0x2F, "QuartReg"},
            {0x30, "0"}, {0x31, "1"}, {0x32, "2"}, {0x33, "3"}, {0x34, "4"}, {0x35, "5"}, {0x36, "6"}, {0x37, "7"}, {0x38, "8"}, {0x39, "9"}, {0x3A, "."}, {0x3B, "E"}, {0x3C, " or "}, {0x3D, " xor "}, {0x3E, ":"}, {0x3F, ":"},
            {0x40, " and "}, {0x41, "A"}, {0x42, "B"},  {0x43, "C"}, {0x44, "D"}, {0x45, "E"}, {0x46, "F"}, {0x47, "G"}, {0x48, "H"},  {0x49, "I"}, {0x4A, "J"}, {0x4B, "K"}, {0x4C, "L"}, {0x4D, "M"}, {0x4E, "N"}, {0x4F, "O"},
            {0x50, "P" }, {0x51, "Q" },{0x52, "R" }, {0x53, "S" },{0x54, "T" }, {0x55, "U" },{0x56, "V" }, {0x57, "W" },{0x58, "X" }, {0x59, "Y" },{0x5A, "Z" }, {0x5B, "θ" },{0x5C, "" }, {0x5D, "" },{0x5E, "" }, {0x5F, "prgm" },
            {0x60, "" }, {0x61, ""}, {0x62, ""}, {0x63, ""}, {0x64, "Radian"}, {0x65, "Degree"}, {0x66, "Normal"}, {0x67, "Sci"}, {0x68, "Eng"}, {0x69, "Float"}, {0x6A, "="}, {0x6B, "<"}, {0x6C, ">"}, {0x6D, "≤"}, {0x6E, "≥"}, {0x6F, "≠"},
            {0x70, "+"}, {0x71, "-"}, {0x72, "Ans"}, {0x73, "Fix"}, {0x74, "Horiz"}, {0x75, "Full"}, {0x76, "Func"}, {0x77, "Param"}, {0x78, "Polar"}, {0x79, "Seq"}, {0x7A, "IndpntAuto"}, {0x7B, "IndpntAsk"}, {0x7C, "DependAuto"}, {0x7D, "DependAsk"}, {0x7E, ""}, {0x7F, "□"},
            {0x80, "▒"}, {0x81, "▒"}, {0x82, "*"}, {0x83, "/"}, {0x84, "Trace"}, {0x85, "ClrDraw"}, {0x86, "ZStandard"}, {0x87, "ZTrig"}, {0x88, "ZBox"}, {0x89, "Zoom In"}, {0x8A, "Zoom Out"}, {0x8B, "ZSquare"}, {0x8C, "ZInteger"}, {0x8D, "ZPrevious"}, {0x8E, "ZDecimal"}, {0x8F, "ZoomStat"},
            {0x90, "ZoomRcl"}, {0x91, "PrintScreen"}, {0x92, "ZoomSto"}, {0x93, "Text("}, {0x94, "nPr"}, {0x95, "nCr"}, {0x96, "FnOn"}, {0x97, "FnOff"}, {0x98, "StorePic"}, {0x99, "RecallPic"}, {0x9A, "StoreGDB"}, {0x9B, "RecallGDB"}, {0x9C, "Line("}, {0x9D, "Vertical"}, {0x9E, "Pt-On("}, {0x9F, "Pt-Off("},
            {0xA0, "Pt-Change("}, {0xA1, "Pxl-On("}, {0xA2, "Pxl-Off("}, {0xA3, "Pxl-Change("}, {0xA4, "Shade("}, {0xA5, "Circle("}, {0xA6, "Horizontal"}, {0xA7, "Tangent("}, {0xA8, "DrawInv"}, {0xA9, "DrawF"}, {0xAA, ""}, {0xAB, "rand"}, {0xAC, "π"}, {0xAD, "getKey"}, {0xAE, "'"}, {0xAF, "?"},
            {0xB0, "-"}, {0xB1, "int("}, {0xB2, "abs("}, {0xB3, "det("}, {0xB4, "identity("}, {0xB5, "dim("}, {0xB6, "sum("}, {0xB7, "prod("}, {0xB8, "not("}, {0xB9, "iPart("}, {0xBA, "fPart("}, {0xBB, ""}, {0xBC, "√("}, {0xBD, "³√("}, {0xBE, "ln("}, {0xBF, "e^("},
            {0xC0, "log("}, {0xC1, "10^("}, {0xC2, "sin("}, {0xC3, "sinֿ¹("}, {0xC4, "cos("}, {0xC5, "cosֿ¹("}, {0xC6, "tan("}, {0xC7, "tanֿ¹("}, {0xC8, "sinh("}, {0xC9, "sinhֿ¹("}, {0xCA, "cosh("}, {0xCB, "coshֿ¹("}, {0xCC, "tanh("}, {0xCD, "tanhֿ¹("}, {0xCE, "If "}, {0xCF, "Then "},
            {0xD0, "Else "}, {0xD1, "While "}, {0xD2, "Repeat "}, {0xD3, "For("}, {0xD4, "End"}, {0xD5, "Return"}, {0xD6, "Lbl "}, {0xD7, "Goto "}, {0xD8, "Pause"}, {0xD9, "Stop"}, {0xDA, "IS>("}, {0xDB, "DS<("}, {0xDC, "Input "}, {0xDD, "Prompt "}, {0xDE, "Disp "}, {0xDF, "DispGraph "},
            {0xE0, "Output("}, {0xE1, "ClrHome"}, {0xE2, "Fill("}, {0xE3, "SortA("}, {0xE4, "SortD("}, {0xE5, "DispTable"}, {0xE6, "Menu"}, {0xE7, "Send("}, {0xE8, "Get("}, {0xE9, "PlotsOn"}, {0xEA, "PlotsOff"}, {0xEB, "∟"}, {0xEC, "Plot1("}, {0xED, "Plot2("}, {0xEE, "Plot3"}, {0xEF, ""},
            {0xF0, "^"}, {0xF1, "×√"}, {0xF2, "1-Var Stats"}, {0xF3, "2-Var Stats"}, {0xF4, "LinReg(a+bx)"}, {0xF5, "ExpReg"}, {0xF6, "LnReg"}, {0xF7, "PwrReg"}, {0xF8, "Med-Med"}, {0xF9, "QuadReg"}, {0xFA, "ClrList"}, {0xFB, "ClrTable"}, {0xFC, "Histogram"}, {0xFD, "xyLine"}, {0xFE, "Scatter"}, {0xFF, "LinReg(ax+b"}
        };

        // Define tokens for two byte, 0xBB branch - Misc (0x00 - 0xF5)
        private static IDictionary<byte, string> miscKeywordDictionary = new Dictionary<byte, string>()
        {
            {0x00, "npv("}, {0x01, "irr("}, {0x02, "bal("}, {0x03, "Σprn("}, {0x04, "ΣInt("}, {0x05, "►Nom("}, {0x06, "►Eff("}, {0x07, "dbd("}, {0x08, "lcm("}, {0x09, "gcd("}, {0x0A, "randInt("}, {0x0B, "randBin("}, {0x0C, "sub("}, {0x0D, "stdDev("}, {0x0E, "variance("}, {0x0F, "inString("},
            {0x10, "normalcdf("}, {0x11, "invNorm("}, {0x12, "tcdf("}, {0x13, "χ²cdf("}, {0x14, "Fcdf("}, {0x15, "binompdf("}, {0x16, "binomcdf("}, {0x17, "poissonpdf("}, {0x18, "poissoncdf("}, {0x19, "geometpdf"}, {0x1A, "geometcdf("}, {0x1B, "normalpdf("}, {0x1C, "tpdf("}, {0x1D, "χ²pdf("}, {0x1E, "Fpdf("}, {0x1F, "randNorm("},
            {0x20, "tvm_Pmt"}, {0x21, "tvm_I%"}, {0x22, "tvm_PV"}, {0x23, "tvm_N"}, {0x24, "tvm_FV"}, {0x25, "conj("}, {0x26, "real("}, {0x27, "imag("}, {0x28, "angle("}, {0x29, "cumSum("}, {0x2A, "expr"}, {0x2B, "length("}, {0x2C, "ΔList("}, {0x2D, "ref("}, {0x2E, "rref("}, {0x2F, "►Rect"},
            {0x30, "►Polar"}, {0x31, "e"}, {0x32, "SinReg"}, {0x33, "Logistic"}, {0x34, "LinRegTTest"}, {0x35, "ShadeNorm("}, {0x36, "Shade_t("}, {0x37, "Shadeχ²"}, {0x38, "ShadeF("}, {0x39, "Matr►list("}, {0x3A, "List►matr("}, {0x3B, "Z-Test("}, {0x3C, "T-Test"}, {0x3D, "2-SampZTest("}, {0x3E, "1-PropZTest("}, {0x3F, "2-PropZTest("},
            {0x40, "χ²-Test("}, {0x41, "ZInterval"}, {0x42, "2-SampZInt("}, {0x43, "1-PropZInt("}, {0x44, "2-PropZInt("}, {0x45, "GraphStyle("}, {0x46, "2-SampTTest"}, {0x47, "2-SampFTest"}, {0x48, "TInterval"}, {0x49, "2-SampTInt"}, {0x4A, "SetUpEditor"}, {0x4B, "Pmt_End"}, {0x4C, "Pmt_Bgn"}, {0x4D, "Real"}, {0x4E, "re^θi"}, {0x4F, "a+bi"},
            {0x50, "ExprOn"}, {0x51, "ExprOff"}, {0x52, "ClrAllLists"}, {0x53, "GetCalc("}, {0x54, "DelVar"}, {0x55, "Equ►String("}, {0x56, "String►Equ("}, {0x57, "Clear Entries"}, {0x58, "Select("}, {0x59, "ANOVA("}, {0x5A, "ModBoxplot"}, {0x5B, "NormProbPlot"}, {0x5C, ""}, {0x5D, ""}, {0x5E, ""}, {0x5F, ""},
            {0x60, ""}, {0x61, ""}, {0x62, ""}, {0x63, ""}, {0x64, "G-T"}, {0x65, "ZoomFit"}, {0x66, "DiagnosticOn"}, {0x67, "DiagnosticOff"}, {0x68, "Archive"}, {0x69, "UnArchive"}, {0x6A, "Asm("}, {0x6B, "AsmComp("}, {0x6C, "AsmPrgm"}, {0x6D, ""}, {0x6E, "Á"}, {0x6F, "À"},
            {0x70, "Â"}, {0x71, "Ä"}, {0x72, "á"}, {0x73, "à"}, {0x74, "â"}, {0x75, "ä"}, {0x76, "É"}, {0x77, "È"}, {0x78, "Ê"}, {0x79, "Ë"}, {0x7A, "é"}, {0x7B, "è"}, {0x7C, "ê"}, {0x7D, "ë"}, {0x7E, ""}, {0x7F, "Ì"},
            {0x80, "Î"}, {0x81, "Ï"}, {0x82, "í"}, {0x83, "ì"}, {0x84, "î"}, {0x85, "ï"}, {0x86, "Ó"}, {0x87, "Ò"}, {0x88, "Ô"}, {0x89, "Ö"}, {0x8A, "ó"}, {0x8B, "ò"}, {0x8C, "ô"}, {0x8D, "ö"}, {0x8E, "Ú"}, {0x8F, "Ù"},
            {0x90, "Û"}, {0x91, "Ü"}, {0x92, "ú"}, {0x93, "ù"}, {0x94, "û"}, {0x95, "ü"}, {0x96, "Ç"}, {0x97, "ç"}, {0x98, "Ñ"}, {0x99, "ñ"}, {0x9A, "´"}, {0x9B, "`"}, {0x9C, "¨"}, {0x9D, "¿"}, {0x9E, "¡"}, {0x9F, "α"},
            {0xA0, "β"}, {0xA1, "γ"}, {0xA2, "Δ"}, {0xA3, "δ"}, {0xA4, "ε"}, {0xA5, "λ"}, {0xA6, "μ"}, {0xA7, "π"}, {0xA8, "ρ"}, {0xA9, "Σ"}, {0xAA, ""}, {0xAB, "φ"}, {0xAC, "Ω"}, {0xAD, "p^"}, {0xAE, "χ"}, {0xAF, "F"},
            {0xB0, "a"}, {0xB1, "b"}, {0xB2, "c"}, {0xB3, "d"}, {0xB4, "e"}, {0xB5, "f"}, {0xB6, "g"}, {0xB7, "h"}, {0xB8, "i"}, {0xB9, "j"}, {0xBA, "k"}, {0xBB, ""}, {0xBC, "l"}, {0xBD, "m"}, {0xBE, "n"}, {0xBF, "o"},
            {0xC0, "p"}, {0xC1, "q"}, {0xC2, "r"}, {0xC3, "s"}, {0xC4, "t"}, {0xC5, "u"}, {0xC6, "v"}, {0xC7, "w"}, {0xC8, "x"}, {0xC9, "y"}, {0xCA, "z"}, {0xCB, "σ"}, {0xCC, "τ"}, {0xCD, "Í"}, {0xCE, "GarbageCollect"}, {0xCF, "~"},
            {0xD0, ""}, {0xD1, "@"}, {0xD2, "#"}, {0xD3, "$"}, {0xD4, "&"}, {0xD5, "`"}, {0xD6, ";"}, {0xD7, "\\"}, {0xD8, "|"}, {0xD9, "_"}, {0xDA, "%"}, {0xDB, "…"}, {0xDC, "∠"}, {0xDD, "ß"}, {0xDE, "x"}, {0xDF, "T"},
            {0xE0, "0"}, {0xE1, "1"}, {0xE2, "2"}, {0xE3, "3"}, {0xE4, "4"}, {0xE5, "5"}, {0xE6, "6"}, {0xE7, "7"}, {0xE8, "8"}, {0xE9, "9"}, {0xEA, "10"}, {0xEB, "←"}, {0xEC, "→"}, {0xED, "↑"}, {0xEE, "↓"}, {0xEF, ""},
            {0xF0, "x"}, {0xF1, "∫"}, {0xF2, ""}, {0xF3, ""}, {0xF4, "√"}, {0xF5, ""}
        };

        // Define tokens for two byte, 0x5C branch - User Variables, Matricies
        private static readonly IDictionary<byte, string> userVariablesKeywordDictionary = new Dictionary<byte, string>()
        {
            // 
        };

        /*
        private static byte[] dualByteEquationsDictionary =
        {
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19,
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B,
            0x40, 0x41, 0x42, 0x43, 0x44, 0x45,
            0x80, 0x81, 0x82
        };

        private static byte[] dualByteGraphDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
            0x10, 0x11, 0x12
        };

        private static byte[] dualByteListsDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05
        };

        private static byte[] dualByteMatrices_Pictures_GDBs_StringsDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09
        };

        private static byte[] dualByteMiscellaneousDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F,
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F,
            0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3A, 0x3B, 0x3C, 0x3D, 0x3E, 0x3F,
            0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F,
            0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F,
            0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F
        };

        private static byte[] dualBytePicturesDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09
        };

        private static byte[] dualBytePrimaryDictionary =
        {
            0x5C, 0x5D, 0x5E, 0x60, 0x61, 0x62, 0x63, 0x7E, 0xAA, 0xBB
        };

        private static byte[] dualByteStatisticsDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F,
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F,
            0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3A, 0x3B, 0x3C
        };

        private static byte[] dualByteWindowAndFinanceDictionary =
        {
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
            0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F,
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F,
            0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38
        };

        private static string[] keywordDictionary = 
        {
            "?", "►DMS", "►Dec", "►Frac", "→", "Boxplot", "[", "]", "{", "}", "r", "°", "¹", "²", "T", "³",
            "(", ")", "round(", "pxl-Test(", "augment(", "rowSwap(", "row+(", "*row(", "*row+(", "max(", "min(", "R►Pr(", "R►Pθ(", "P►Rx(", "P►Ry(", "median(",
            "randM(", "mean(", "solve(", "seq(", "fnInt(", "nDeriv(", "?", "fMin(", "fMax(", " ", "\"", ",", "i", "!", "CubicReg", "QuartReg",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "E", "or", "xor", "newline", ":",
            "and", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "θ", "?", "?", "?", "prgm",
            "?", "?", "?", "?", "Radian", "Degree", "Normal", "Sci", "Eng", "Float", "=", "<", ">", "≤", "≥", "≠",
            "+", "-", "Ans", "Fix", "Horiz", "Full", "Func", "Param", "Polar", "Seq", "IndpntAuto", "IndpntAsk", "DependAuto", "DependAsk", "?", "?",
            "?", "?", "*", "/", "Trace", "ClrDraw", "ZStandard", "ZTrig", "ZBox", "Zoom In", "Zoom Out", "ZSquare", "ZInteger", "ZPrevious", "ZDecimal", "ZoomStat",
            "ZoomRcl", "PrintScreen", "ZoomSto", "Text(", "nPr", "nCr", "FnOn", "FnOff", "StorePic", "RecallPic", "StoreGDB", "RecallGDB", "Line(", "Vertical", "Pt-On(", "Pt-Off(",
            "Pt-Change(", "Pxl-On(", "Pxl-Off(", "Pxl-Change(", "Shade(", "Circle(", "Horizontal", "Tangent(", "DrawInv", "DrawF", "?", "rand", "π", "getKey", "'", "?",
            "-", "int(", "abs(", "det(", "identity(", "dim(", "sum(", "prod(", "not(", "iPart(", "fPart(", "?", "√(", "³√(", "ln(", "e^(",
            "log(", "10^(", "sin(", "sinֿ¹(", "cos(", "cosֿ¹(", "tan(", "tanֿ¹(", "sinh(", "sinhֿ¹(", "cosh(", "coshֿ¹(", "tanh(", "tanhֿ¹(", "If", "Then",
            "Else", "While", "Repeat", "For(", "End", "Return", "Lbl", "Goto", "Pause", "Stop", "IS>(", "DS<(", "Input", "Prompt", "Disp", "DispGraph",
            "Output(", "ClrHome", "Fill(", "SortA(", "SortD(", "DispTable", "Menu(", "Send(", "Get(", "PlotsOn", "PlotsOff", "∟", "Plot1(", "Plot2(", "Plot3(", "?",
            "^", "×√", "1-Var Stats", "2-Var Stats", "LinReg(a+bx)", "ExpReg", "LnReg", "PwrReg", "Med-Med", "QuadReg", "ClrList", "ClrTable", "Histogram", "xyLine", "Scatter", "LinReg(ax+b)"
        };

        private static string[] keywordWindowAndFinanceDictionary =
        {
            "ZXscl", "ZYscl", "Xscl", "Yscl", "u(nMin)", "v(nMin)", "u(n-1)", "v(n-1)", "Zu(nMin)", "Zv(nMin)", "Xmin", "Xmax", "Ymin", "Ymax", "Tmin", "Tmax",
            "θmin", "θmax", "ZXmin", "ZXmax", "ZYmin", "ZYmax", "Zθmin", "Zθmax", "ZTmin", "ZTmax", "TblStart", "PlotStart", "ZPlotStart", "nMax", "ZnMax", "nMin",
            "ZnMin", "ΔTbl", "Tstep", "θstep", "ZTstep", "Zθstep", "ΔX", "ΔY", "XFact", "YFact", "TblInput", "N", "I%", "PV", "PMT", "FV",
            "P/Y", "C/Y", "w(nMin)", " Zw(nMin)", "PlotStep", "ZPlotStep", "Xres", "ZXres", "TraceStep"
        };

        // We may still use this?
        /*internal static bool DoesByteDenoteTwoByteToken(byte v)
        {
            bool bl = false;
            foreach (byte bt in dualBytePrimaryDictionary)
            {
                if (bt == v) { bl = true; }
            }
            return bl;
        }*/


        public static string BytesToKeyword(byte b1, byte b2)
        {
            // Check b1 and branch if needed & Try to get value from dictionary, stored in "keyword" 
            if (b1 == 0xBB && miscKeywordDictionary.TryGetValue(b2, out string keyword))
            {
                Console.WriteLine("Found byte at {0}{1}", b1, b2);
                return keyword;
            }
            else
            {
                // Return something useful for debugging
                Console.WriteLine("Missing byte at {0}{1}", b1, b2);
                return "[ 0x" + b2.ToString("x2").ToUpper() + " ]";
            }
        }

        /*        
            internal static string DualByteToKeyword(byte v1, byte v2)
                    {
                    int index1 = byteFindIndexInByteArray(v1, dualBytePrimaryDictionary);
                    int index2 = 0;
                    string token = "token";

                    switch (index1)
                    {
                        case 0:
                            index2 = byteFindIndexInByteArray(v2, dualByteMatrices_Pictures_GDBs_StringsDictionary);
                            break;

                        case 1:
                            index2 = byteFindIndexInByteArray(v2, dualByteListsDictionary);
                            break;

                        case 2:
                            index2 = byteFindIndexInByteArray(v2, dualByteEquationsDictionary);
                            break;

                        case 3:
                            index2 = byteFindIndexInByteArray(v2, dualByteMatrices_Pictures_GDBs_StringsDictionary);
                            break;

                        case 4:
                            index2 = byteFindIndexInByteArray(v2, dualByteMatrices_Pictures_GDBs_StringsDictionary);
                            break;

                        case 5:
                            index2 = byteFindIndexInByteArray(v2, dualByteStatisticsDictionary);
                            break;

                        case 6:
                            index2 = byteFindIndexInByteArray(v2, dualByteWindowAndFinanceDictionary);
                            token = keywordWindowAndFinanceDictionary[index2];
                            break;

                        case 7:
                            index2 = byteFindIndexInByteArray(v2, dualByteGraphDictionary);
                            break;

                        case 8:
                            index2 = byteFindIndexInByteArray(v2, dualByteMatrices_Pictures_GDBs_StringsDictionary);
                            break;

                        case 9:
                            index2 = byteFindIndexInByteArray(v2, dualByteMiscellaneousDictionary);
                            break;
                    }
                    return token;
                }

                private static int byteFindIndexInByteArray(byte signature, byte[] byteArray)
                {
                    int index = 0;
                    for (int i = 0; i < byteArray.Length; i++)
                    {
                        if (signature == byteArray[i]) { index = i; }
                    }
                    return index;
                }
        */
        #endregion Private Fields

        #region Public Methods


        // ### Untested ###
        public static byte KeywordToByte(string s)
        {
            var result = baseKeywordDictionary.FirstOrDefault(x => x.Key.ToString() == s || x.Value == s);
            Console.Write(result);
            return Convert.ToByte(result);
        }

        public static string ByteToKeyword(byte b)
        {
            if (baseKeywordDictionary.TryGetValue(b, out string keyword))
            {
            Console.WriteLine("Found byte at {0}", b);
            return keyword;
            }
            else
            {
            // Return something useful for debugging
            Console.WriteLine("Missing byte at {0}", b);
            return "[ 0x" + b.ToString("x2").ToUpper() + " ]";
            }
        }
    }
        #endregion Public Methods
}