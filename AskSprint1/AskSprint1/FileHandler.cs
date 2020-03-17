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
        public List<Answers> answers;
        public FileHandler()
        {
            questions = new List<Questions>();
            answers = new List<Answers>();
        }
        public void ProcessFile(string path = "questions.csv")
        {
            //C:\Users\Public\AllFileNames.txt
            //C:\Users\Én\Desktop\valami
            TextWriter tw = new StreamWriter("answers.csv", true);

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
                    var q = new Questions(line);
                    questions.Add(q);
                }
            }
            using (StreamReader sr = new StreamReader("answers.csv"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var a = new Answers(line);
                    answers.Add(a);
                }
            }
        }
    }
}
