using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;


namespace Assignment9
{
    class ProgramProcesses
    {
        string FileExist;
        string w;
        //string[] words;
        public string IsFilePathValid(string path)
        {
            Regex rg = new Regex(@"^(?:[\w]\:|\\)(\\[a-zA-Z_\-\s0-9\.]+)+\.(txt)$");
            string IsValid = rg.IsMatch(path) ? "true" : "false";
            return IsValid;
        }

        public string DoesFileExist(string path)
        {
            StreamReader readFile;
            try
            {
               
                readFile = new StreamReader(path);
                FileExist = "true";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("File Exists");
                Console.ForegroundColor = ConsoleColor.White;
                WordCount(path);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("File path is Invalid");
                Console.ForegroundColor = ConsoleColor.White;
                FileExist = "false";
            }

            return FileExist;

        }

        public void WordCount(string path)
        {
            List<String> listOfWords = new List<String>();
            //string[] words;
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                w += sr.ReadLine();
                // words = w.Split(' ');   
                //Console.WriteLine(w);
            }
            /*Console.WriteLine(w);
            for(int i=0; i<w.Length; i++)
            {
                words = w.Split(' ');
            }
            Console.WriteLine(w);
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                count += 1;
            }*/

            listOfWords = w.Split(' ').ToList();



            /* foreach (string h in listOfWords)
             {
                 Console.WriteLine(h);
             }*/
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Using a List");
            Console.ForegroundColor = ConsoleColor.White;
            int count = listOfWords.Capacity;
            Console.WriteLine("Word count: "+count+" words.");
            Console.WriteLine("******************************");
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Using File ReadAllLines approach");
            Console.ForegroundColor = ConsoleColor.White;
            string[] FileContents = File.ReadAllLines(path);
            int wordCount = File.ReadAllText(path).Split(' ').Count();
            Console.WriteLine("Word count: "+wordCount+" words.");
            Console.WriteLine(' ');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ValidPath = "false";
            string filePath, fileExists, valid;
           
            //string fileThere = "false";
            ProgramProcesses process = new ProgramProcesses();
            do
            {
                Console.WriteLine("Please, Enter a valid file path: ");
                filePath = Console.ReadLine();      
                ValidPath = process.IsFilePathValid(filePath);
                fileExists = process.DoesFileExist(filePath);
                valid = (ValidPath == "false" || fileExists == "false") ? "false" : "true";
            } while (valid == "false");

            

        }

    }

    
}
