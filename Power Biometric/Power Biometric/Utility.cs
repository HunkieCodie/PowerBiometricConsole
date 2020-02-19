using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Biometric
{
    public static class Utility
    {
        public static string FILE_NAME = Directory.GetCurrentDirectory() + "\\" + "ConfigFile.txt";
        public static StreamReader objReader = new StreamReader(FILE_NAME);

        public static string CONNECTION_STRING = objReader.ReadLine();
        public static string connectionString = CONNECTION_STRING;



        public static string FileContentRead = Directory.GetCurrentDirectory() + "\\" + "Token.txt";
        public static StreamReader objReader2 = new StreamReader(FileContentRead);
        public static string FileContent = objReader2.ReadLine();
        public static string content = FileContentRead;

        static char[] delimeter = new char[] { '|' };

        static string[] FileContentArray = FileContent.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
        public static string Token = FileContentArray[0];
        public static string APIBaseURL = FileContentArray[1];




    } 
}
