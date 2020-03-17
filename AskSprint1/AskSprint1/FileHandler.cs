using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AskSprint1
{
    public class FileHandler
    { 
        public List<Questions> questions;
        public FileHandler()
        {
            questions = new List<Questions>();
        }
        public void ProcessFile(string path = "questions.csv")
        {
            //C:\Users\Public\AllFileNames.txt
            //C:\Users\Én\Desktop\valami
            TextWriter tw = new StreamWriter("questions.csv", true);

            tw.WriteLine(path);
            tw.Close();
        }
        public void ReadCSV()
        {
            using (StreamReader sr = new StreamReader("questions.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');
                    var q = new Questions(values[0], values[1]);
                    questions.Add(q);
                }
            }
        }
    }
}
