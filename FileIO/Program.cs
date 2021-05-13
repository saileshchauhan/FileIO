using System;
using System.IO;

namespace FileIO
{
    class Program
    {
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
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Don't Exist");
            }
        }
        public static void ReadLine()
        {
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            string[] line=File.ReadAllLines(path);
            Console.WriteLine(line[0]);
            Console.WriteLine(line[1]);
            Console.WriteLine(line[2]);
        }
        public static void ReadAllLines()
        {
            string path= @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            string pathCopy = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFileCopy.txt";
            File.Copy(path,pathCopy);
        }
        public static void DeleteFile()
        {
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFileCopy.txt";
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            using (StreamReader sr = File.OpenText(path))
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
            string path = @"C:\Users\chauh\source\repos\FileIO\FileIO\TextFile.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}
