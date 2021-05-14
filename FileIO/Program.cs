using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        const string FILE_PATH = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
        static void Main(string[] args)
        {
            FileExist();
            ReadLine();
            ReadAllLines();
            FileCopy();
            DeleteFile();
            ReadFromStreamReader();
            WriteusingStreamWriter();
        }
        public static void FileExist()
        {
            if (File.Exists(FILE_PATH))
                Console.WriteLine("File Exists");
            else
            {
                Console.WriteLine("File Don't Exist");
            }
        }
        public static void ReadLine()
        {
            //validation for file path 
            FileExist();
            string[] line=File.ReadAllLines(FILE_PATH);
            Console.WriteLine(line[0]);
            Console.WriteLine(line[1]);
            Console.WriteLine(line[2]);
        }
        public static void ReadAllLines()
        {
            FileExist();
            string lines = File.ReadAllText(FILE_PATH);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            FileExist();
            try
            {
                string path = FILE_PATH;
                if(File.Exists(FILE_PATH))
                    Console.WriteLine("Source file exists");
                string pathCopy = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFileCopy.txt";
                File.Copy(path, pathCopy);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteFile()
        {
            FileExist();
            File.Delete(FILE_PATH);
        }
        public static void ReadFromStreamReader()
        {
            FileExist();
            using (StreamReader sr = File.OpenText(FILE_PATH))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }
        }
        public static void WriteusingStreamWriter()
        {
            FileExist();
            using (StreamWriter sr = File.AppendText(FILE_PATH))
            {
                sr.WriteLine("Hello World");
                sr.Close();
                Console.WriteLine(File.ReadAllText(FILE_PATH));
            }
            Console.ReadKey();
        }
    }
}
