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
       
        private char[] m = {'y','t','b','g','a'};
        private char[] n = { '1', '2', '3', '4', '5'};

        public void schet1()
        {
            
        }

        public void schet2()
        {
            char[] a = m[rnd.Next(m.Length)].ToString().ToUpper().ToCharArray();
            char b = a[1];
        }

        public void schet3()
        {
            char[] a = m[rnd.Next(m.Length)].ToString().ToCharArray();
            char b = a[1];
        }

        public void schet4()
        {
            char a = ' ';
        }

        public void schet5()
        {
            char a = n[rnd.Next(m.Length)];
        
        }

        public void file()
        {
            string path = @"C:\Users\student.ISTU\Desktop";
            FileStream fs = File.Create(path);
        }
    }
}
