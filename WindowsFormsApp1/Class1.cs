using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Class1
    {

        Random rnd = new Random();
        private char[] m = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] m1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] n = { '1', '2', '3', '4', '5','6','7','8','9','0'};
        private char[] n1 = { '!', '@', '#', '$', '%', '&', '?', '-', '+', '=', '~' };
        public static List<char> mas = new List<char>();
        


        public void schet1()
        {
            int a = rnd.Next(2); 

            switch (a)
            {
                case 0:
                    char b = m1[rnd.Next(m1.Length)];
                    mas.Add(b);
                    
                    break;
                    
                case 1:
                    char c = m[rnd.Next(m.Length)];
                    mas.Add(c);
                    break;
                       
                case 2:
                    char d = n[rnd.Next(n.Length)];
                    mas.Add(d);
                    break;
                case 3:
                    char e = n1[rnd.Next(n1.Length)];
                    break;
                    
            }                       
        
        }

        public void schet2()
        {
            char a = m1[rnd.Next(m1.Length)];
            mas.Add(a);
           
         
        }

        public void schet3()
        {
            char a = m[rnd.Next(m.Length)];
            mas.Add(a);
                
        }

        public void schet4()
        {
            char a = ' ';
            mas.Add(a);
        }

        public void schet5() 
        {
            char a = n[rnd.Next(n.Length)];
            mas.Add(a);   
        
        }
        public void schet6()
        {
            char a = n1[rnd.Next(n1.Length)];
            mas.Add(a);
        }

        public void obnul() 
        {
                mas.Clear();
        }
        public void dob()
        {
            Form1.lst1.Add(mas.ToArray());
            Console.WriteLine(mas.ToArray());
        }


        
    }
}
