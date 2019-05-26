//Заміна рядків
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' };
            string otvet;

            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                
                inputText = MyFile.ReadToEnd().Replace('\n', ' ');
            }
            string[] words = inputText.Split(separator);

          
                    otvet = inputText.Replace("Work", "Job");
                    Console.WriteLine(otvet);
            Console.WriteLine("------------------");
            for(int i=0; i<words.Length;i++)
            {
                if (words[i] == "life")
                { Console.WriteLine("Index:" + i); break; }
            }
            Console.ReadLine();
          

        }

      
    }
}
