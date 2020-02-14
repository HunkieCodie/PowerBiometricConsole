using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.Data.Validators
{
    public class Extras
    {
        public string doConvertPwd(string pwd)
        {
            int pwdLen;
            string vPwd;
            string vConvertedPwd;

            vPwd = pwd;
            pwdLen = pwd.Length;
            vConvertedPwd = "";

            if (pwdLen > 0)
            {
                int pcount;
                int textStep;
                string myxter;
                string convertdPwd;
                string myxtercoded;
                pcount = 0;
                pcount = pwdLen;
                convertdPwd = "";
                textStep = 0;
                myxter = "";


                while (pcount > 0)
                {
                    myxter = vPwd.Substring(textStep, 1);
                    myxtercoded = PowerEncode.FncEncode(ref myxter);
                    convertdPwd = convertdPwd + myxtercoded;
                    textStep = textStep + 1;
                    pcount = pcount - 1;
                    vConvertedPwd = convertdPwd;
                }

                return vConvertedPwd;
            }
            else
            {
                return vConvertedPwd = "";
            }
        }

        internal class PowerEncode
        {
            public static string FncEncode(ref string xletter)
            {
                string Myxletter = null;
                //UPPER CASE XTERS
                if (xletter == "A")
                {
                    Myxletter = "P";
                }
                else if (xletter == "B")
                {
                    Myxletter = "1";
                }
                else if (xletter == "C")
                {
                    Myxletter = "M";
                }
                else if (xletter == "D")
                {
                    Myxletter = "O";
                }
                else if (xletter == "E")
                {
                    Myxletter = "2";
                }
                else if (xletter == "F")
                {
                    Myxletter = "J";
                }
                else if (xletter == "G")
                {
                    Myxletter = "W";
                }
                else if (xletter == "H")
                {
                    Myxletter = "3";
                }
                else if (xletter == "I")
                {
                    Myxletter = "B";
                }
                else if (xletter == "J")
                {
                    Myxletter = "E";
                }
                else if (xletter == "K")
                {
                    Myxletter = "4";
                }
                else if (xletter == "L")
                {
                    Myxletter = "H";
                }
                else if (xletter == "M")
                {
                    Myxletter = "R";
                }
                else if (xletter == "N")
                {
                    Myxletter = "5";
                }
                else if (xletter == "O")
                {
                    Myxletter = "A";
                }
                else if (xletter == "P")
                {
                    Myxletter = "S";
                }
                else if (xletter == "Q")
                {
                    Myxletter = "6";
                }
                else if (xletter == "R")
                {
                    Myxletter = "M";
                }
                else if (xletter == "S")
                {
                    Myxletter = "0";
                }
                else if (xletter == "T")
                {
                    Myxletter = "7";
                }
                else if (xletter == "U")
                {
                    Myxletter = "I";
                }
                else if (xletter == "V")
                {
                    Myxletter = "F";
                }
                else if (xletter == "W")
                {
                    Myxletter = "8";
                }
                else if (xletter == "X")
                {
                    Myxletter = "9";
                }
                else if (xletter == "Y")
                {
                    Myxletter = "T";
                }
                else if (xletter == "Z")
                {
                    Myxletter = "9";
                    //LOWER CASE XTERS
                }
                else if (xletter == "a")
                {
                    Myxletter = "{";
                }
                else if (xletter == "b")
                {
                    Myxletter = "\\";
                }
                else if (xletter == "c")
                {
                    Myxletter = "}";
                }
                else if (xletter == "d")
                {
                    Myxletter = "#";
                }
                else if (xletter == "e")
                {
                    Myxletter = "|";
                }
                else if (xletter == "f")
                {
                    Myxletter = "*";
                }
                else if (xletter == "g")
                {
                    Myxletter = "@";
                }
                else if (xletter == "h")
                {
                    Myxletter = "&";
                }
                else if (xletter == "i")
                {
                    Myxletter = "?";
                }
                else if (xletter == "j")
                {
                    Myxletter = "!";
                }
                else if (xletter == "k")
                {
                    Myxletter = "-";
                }
                else if (xletter == "l")
                {
                    Myxletter = "+";
                }
                else if (xletter == "m")
                {
                    Myxletter = "/";
                }
                else if (xletter == "n")
                {
                    Myxletter = ">";
                }
                else if (xletter == "o")
                {
                    Myxletter = "<";
                }
                else if (xletter == "p")
                {
                    Myxletter = "$";
                }
                else if (xletter == "q")
                {
                    Myxletter = "[";
                }
                else if (xletter == "r")
                {
                    Myxletter = "]";
                }
                else if (xletter == "s")
                {
                    Myxletter = "(";
                }
                else if (xletter == "t")
                {
                    Myxletter = ")";
                }
                else if (xletter == "u")
                {
                    Myxletter = "=";
                }
                else if (xletter == "v")
                {
                    Myxletter = "~";
                }
                else if (xletter == "w")
                {
                    Myxletter = ":";
                }
                else if (xletter == "x")
                {
                    Myxletter = ";";
                }
                else if (xletter == "y")
                {
                    Myxletter = "_";
                }
                else if (xletter == "z")
                {
                    Myxletter = ".";
                }
                else if (xletter == " ")
                {
                    Myxletter = "£";
                    //NUMERIC XTERS
                }
                else if (xletter == "1")
                {
                    Myxletter = "B";
                }
                else if (xletter == "2")
                {
                    Myxletter = "E";
                }
                else if (xletter == "3")
                {
                    Myxletter = "H";
                }
                else if (xletter == "4")
                {
                    Myxletter = "K";
                }
                else if (xletter == "5")
                {
                    Myxletter = "N";
                }
                else if (xletter == "6")
                {
                    Myxletter = "Q";
                }
                else if (xletter == "7")
                {
                    Myxletter = "T";
                }
                else if (xletter == "8")
                {
                    Myxletter = "W";
                }
                else if (xletter == "9")
                {
                    Myxletter = "Z";
                    //SPECIAL XTERS
                }
                else if (xletter == "{")
                {
                    Myxletter = "a";
                }
                else if (xletter == "\\")
                {
                    Myxletter = "b";
                }
                else if (xletter == "}")
                {
                    Myxletter = "c";
                }
                else if (xletter == "#")
                {
                    Myxletter = "d";
                }
                else if (xletter == "|")
                {
                    Myxletter = "e";
                }
                else if (xletter == "*")
                {
                    Myxletter = "f";
                }
                else if (xletter == "@")
                {
                    Myxletter = "g";
                }
                else if (xletter == "&")
                {
                    Myxletter = "h";
                }
                else if (xletter == "?")
                {
                    Myxletter = "i";
                }
                else if (xletter == "!")
                {
                    Myxletter = "j";
                }
                else if (xletter == "-")
                {
                    Myxletter = "k";
                }
                else if (xletter == "+")
                {
                    Myxletter = "l";
                }
                else if (xletter == "/")
                {
                    Myxletter = "m";
                }
                else if (xletter == ">")
                {
                    Myxletter = "n";
                }
                else if (xletter == "<")
                {
                    Myxletter = "o";
                }
                else if (xletter == "$")
                {
                    Myxletter = "p";
                }
                else if (xletter == "[")
                {
                    Myxletter = "q";
                }
                else if (xletter == "]")
                {
                    Myxletter = "r";
                }
                else if (xletter == "(")
                {
                    Myxletter = "s";
                }
                else if (xletter == ")")
                {
                    Myxletter = "t";
                }
                else if (xletter == "=")
                {
                    Myxletter = "u";
                }
                else if (xletter == "v")
                {
                    Myxletter = "~";
                }
                else if (xletter == ":")
                {
                    Myxletter = "w";
                }
                else if (xletter == ";")
                {
                    Myxletter = "x";
                }
                else if (xletter == "_")
                {
                    Myxletter = "y";
                }
                else if (xletter == ".")
                {
                    Myxletter = "z";
                }
                else
                {
                    Myxletter = ".";
                }

                return Myxletter;
            }
            public static string FncEncodex(ref string xletter)
            {
                string Myxletter = null;
                //UPPER CASE XTERS
                if (xletter == "A")
                {
                    Myxletter = "P";
                }
                else if (xletter == "B")
                {
                    Myxletter = "1";
                }
                else if (xletter == "C")
                {
                    Myxletter = "M";
                }
                else if (xletter == "D")
                {
                    Myxletter = "O";
                }
                else if (xletter == "E")
                {
                    Myxletter = "2";
                }
                else if (xletter == "F")
                {
                    Myxletter = "J";
                }
                else if (xletter == "G")
                {
                    Myxletter = "W";
                }
                else if (xletter == "H")
                {
                    Myxletter = "3";
                }
                else if (xletter == "I")
                {
                    Myxletter = "B";
                }
                else if (xletter == "J")
                {
                    Myxletter = "E";
                }
                else if (xletter == "K")
                {
                    Myxletter = "4";
                }
                else if (xletter == "L")
                {
                    Myxletter = "H";
                }
                else if (xletter == "M")
                {
                    Myxletter = "R";
                }
                else if (xletter == "N")
                {
                    Myxletter = "5";
                }
                else if (xletter == "O")
                {
                    Myxletter = "A";
                }
                else if (xletter == "P")
                {
                    Myxletter = "S";
                }
                else if (xletter == "Q")
                {
                    Myxletter = "6";
                }
                else if (xletter == "R")
                {
                    Myxletter = "M";
                }
                else if (xletter == "S")
                {
                    Myxletter = "0";
                }
                else if (xletter == "T")
                {
                    Myxletter = "7";
                }
                else if (xletter == "U")
                {
                    Myxletter = "I";
                }
                else if (xletter == "V")
                {
                    Myxletter = "F";
                }
                else if (xletter == "W")
                {
                    Myxletter = "8";
                }
                else if (xletter == "X")
                {
                    Myxletter = "9";
                }
                else if (xletter == "Y")
                {
                    Myxletter = "T";
                }
                else if (xletter == "Z")
                {
                    Myxletter = "9";
                    //LOWER CASE XTERS
                }
                else if (xletter == "a")
                {
                    Myxletter = "{";
                }
                else if (xletter == "b")
                {
                    Myxletter = "\\";
                }
                else if (xletter == "c")
                {
                    Myxletter = "}";
                }
                else if (xletter == "d")
                {
                    Myxletter = "#";
                }
                else if (xletter == "e")
                {
                    Myxletter = "|";
                }
                else if (xletter == "f")
                {
                    Myxletter = "*";
                }
                else if (xletter == "g")
                {
                    Myxletter = "@";
                }
                else if (xletter == "h")
                {
                    Myxletter = "&";
                }
                else if (xletter == "i")
                {
                    Myxletter = "?";
                }
                else if (xletter == "j")
                {
                    Myxletter = "!";
                }
                else if (xletter == "k")
                {
                    Myxletter = "-";
                }
                else if (xletter == "l")
                {
                    Myxletter = "+";
                }
                else if (xletter == "m")
                {
                    Myxletter = "/";
                }
                else if (xletter == "n")
                {
                    Myxletter = ".";
                }
                else if (xletter == "o")
                {
                    Myxletter = ".";
                }
                else if (xletter == "p")
                {
                    Myxletter = "$";
                }
                else if (xletter == "q")
                {
                    Myxletter = "[";
                }
                else if (xletter == "r")
                {
                    Myxletter = "]";
                }
                else if (xletter == "s")
                {
                    Myxletter = "(";
                }
                else if (xletter == "t")
                {
                    Myxletter = ")";
                }
                else if (xletter == "u")
                {
                    Myxletter = "=";
                }
                else if (xletter == "v")
                {
                    Myxletter = "~";
                }
                else if (xletter == "w")
                {
                    Myxletter = ":";
                }
                else if (xletter == "x")
                {
                    Myxletter = ";";
                }
                else if (xletter == "y")
                {
                    Myxletter = "_";
                }
                else if (xletter == "z")
                {
                    Myxletter = ".";
                }
                else if (xletter == " ")
                {
                    Myxletter = "£";
                    //NUMERIC XTERS
                }
                else if (xletter == "1")
                {
                    Myxletter = "B";
                }
                else if (xletter == "2")
                {
                    Myxletter = "E";
                }
                else if (xletter == "3")
                {
                    Myxletter = "H";
                }
                else if (xletter == "4")
                {
                    Myxletter = "K";
                }
                else if (xletter == "5")
                {
                    Myxletter = "N";
                }
                else if (xletter == "6")
                {
                    Myxletter = "Q";
                }
                else if (xletter == "7")
                {
                    Myxletter = "T";
                }
                else if (xletter == "8")
                {
                    Myxletter = "W";
                }
                else if (xletter == "9")
                {
                    Myxletter = "Z";
                    //SPECIAL XTERS
                }
                else if (xletter == "{")
                {
                    Myxletter = "a";
                }
                else if (xletter == "\\")
                {
                    Myxletter = "b";
                }
                else if (xletter == "}")
                {
                    Myxletter = "c";
                }
                else if (xletter == "#")
                {
                    Myxletter = "d";
                }
                else if (xletter == "|")
                {
                    Myxletter = "e";
                }
                else if (xletter == "*")
                {
                    Myxletter = "f";
                }
                else if (xletter == "@")
                {
                    Myxletter = "g";
                }
                else if (xletter == "&")
                {
                    Myxletter = "h";
                }
                else if (xletter == "?")
                {
                    Myxletter = "i";
                }
                else if (xletter == "!")
                {
                    Myxletter = "j";
                }
                else if (xletter == "-")
                {
                    Myxletter = "k";
                }
                else if (xletter == "+")
                {
                    Myxletter = "l";
                }
                else if (xletter == "/")
                {
                    Myxletter = "m";
                }
                else if (xletter == ">")
                {
                    Myxletter = "n";
                }
                else if (xletter == "<")
                {
                    Myxletter = "o";
                }
                else if (xletter == "$")
                {
                    Myxletter = "p";
                }
                else if (xletter == "[")
                {
                    Myxletter = "q";
                }
                else if (xletter == "]")
                {
                    Myxletter = "r";
                }
                else if (xletter == "(")
                {
                    Myxletter = "s";
                }
                else if (xletter == ")")
                {
                    Myxletter = "t";
                }
                else if (xletter == "=")
                {
                    Myxletter = "u";
                }
                else if (xletter == "v")
                {
                    Myxletter = "~";
                }
                else if (xletter == ":")
                {
                    Myxletter = "w";
                }
                else if (xletter == ";")
                {
                    Myxletter = "x";
                }
                else if (xletter == "_")
                {
                    Myxletter = "y";
                }
                else if (xletter == ".")
                {
                    Myxletter = "z";
                }
                else
                {
                    Myxletter = "0";
                }

                return Myxletter;
            }
            public static string FncEncodeAlphabet(ref string xletter)
            {
                string Myxletter = null;
                //UPPER CASE XTERS
                if (xletter == "A")
                {
                    Myxletter = "1";
                }
                else if (xletter == "B")
                {
                    Myxletter = "2";
                }
                else if (xletter == "C")
                {
                    Myxletter = "3";
                }
                else if (xletter == "D")
                {
                    Myxletter = "4";
                }
                else if (xletter == "E")
                {
                    Myxletter = "5";
                }
                else if (xletter == "F")
                {
                    Myxletter = "6";
                }
                else if (xletter == "G")
                {
                    Myxletter = "7";
                }
                else if (xletter == "H")
                {
                    Myxletter = "8";
                }
                else if (xletter == "I")
                {
                    Myxletter = "9";
                }
                else if (xletter == "J")
                {
                    Myxletter = "10";
                }
                else if (xletter == "K")
                {
                    Myxletter = "11";
                }
                else if (xletter == "L")
                {
                    Myxletter = "12";
                }
                else if (xletter == "M")
                {
                    Myxletter = "13";
                }
                else if (xletter == "N")
                {
                    Myxletter = "14";
                }
                else if (xletter == "O")
                {
                    Myxletter = "15";
                }
                else if (xletter == "P")
                {
                    Myxletter = "16";
                }
                else if (xletter == "Q")
                {
                    Myxletter = "17";
                }
                else if (xletter == "R")
                {
                    Myxletter = "18";
                }
                else if (xletter == "S")
                {
                    Myxletter = "19";
                }
                else if (xletter == "T")
                {
                    Myxletter = "20";
                }
                else if (xletter == "U")
                {
                    Myxletter = "21";
                }
                else if (xletter == "V")
                {
                    Myxletter = "22";
                }
                else if (xletter == "W")
                {
                    Myxletter = "23";
                }
                else if (xletter == "X")
                {
                    Myxletter = "24";
                }
                else if (xletter == "Y")
                {
                    Myxletter = "25";
                }
                else if (xletter == "Z")
                {
                    Myxletter = "26";
                    //LOWER CASE XTERS
                }
                else if (xletter == "a")
                {
                    Myxletter = "1";
                }
                else if (xletter == "b")
                {
                    Myxletter = "2";
                }
                else if (xletter == "c")
                {
                    Myxletter = "3";
                }
                else if (xletter == "d")
                {
                    Myxletter = "4";
                }
                else if (xletter == "e")
                {
                    Myxletter = "5";
                }
                else if (xletter == "f")
                {
                    Myxletter = "6";
                }
                else if (xletter == "g")
                {
                    Myxletter = "7";
                }
                else if (xletter == "h")
                {
                    Myxletter = "8";
                }
                else if (xletter == "i")
                {
                    Myxletter = "9";
                }
                else if (xletter == "j")
                {
                    Myxletter = "10";
                }
                else if (xletter == "k")
                {
                    Myxletter = "11";
                }
                else if (xletter == "l")
                {
                    Myxletter = "12";
                }
                else if (xletter == "m")
                {
                    Myxletter = "13";
                }
                else if (xletter == "n")
                {
                    Myxletter = "14";
                }
                else if (xletter == "o")
                {
                    Myxletter = "15";
                }
                else if (xletter == "p")
                {
                    Myxletter = "16";
                }
                else if (xletter == "q")
                {
                    Myxletter = "17";
                }
                else if (xletter == "r")
                {
                    Myxletter = "18";
                }
                else if (xletter == "s")
                {
                    Myxletter = "19";
                }
                else if (xletter == "t")
                {
                    Myxletter = "20";
                }
                else if (xletter == "u")
                {
                    Myxletter = "21";
                }
                else if (xletter == "v")
                {
                    Myxletter = "22";
                }
                else if (xletter == "w")
                {
                    Myxletter = "23";
                }
                else if (xletter == "x")
                {
                    Myxletter = "24";
                }
                else if (xletter == "y")
                {
                    Myxletter = "25";
                }
                else if (xletter == "z")
                {
                    Myxletter = "26";
                }
                else
                {
                    Myxletter = "0";

                }

                return Myxletter;

            }
        }
    }
}
