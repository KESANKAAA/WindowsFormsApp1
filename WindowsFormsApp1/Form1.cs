using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> lst = new List<string>();
        Stack<string> stc = new Stack<string>();
        public int s;
        public string path;
        FileStream fs = new FileStream(path,false);

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            
            for (int i = 0; i < comboBox1.Text.Length; i++)
            {

                switch (a[i])
                {
                    case '*': 
                        Class1 cls1 = new Class1();
                        cls1.schet1();
                        break;
                    
                    case 'L':
                        Class1 cls2 = new Class1();
                        cls2.schet2();
                        break;

                    case 'l':
                        Class1 cls3 = new Class1();
                        cls3.schet3();
                        break;

                    case '_':
                        Class1 cls4 = new Class1();
                        cls4.schet4();
                        break;

                    case 'c':
                        Class1 cls5 = new Class1();
                        cls5.schet5();
                        break;
                }

                //if (a[i]=='*')
                //{
                //    Class1 cls = new Class1();
                //    cls.schet1();
                //}

                //else if(a[i] == 'L')
                //{
                //    Class1 cls = new Class1();
                //    cls.schet2();
                //}

                //else if (a[i] == 'l')
                //{
                //    Class1 cls = new Class1();
                //    cls.schet3();
                //}

                //else if (a[i] == '_')
                //{
                //    Class1 cls = new Class1();
                //    cls.schet4();
                //}
                //else if (a[i] == 'c')
                //{
                //    Class1 cls = new Class1();
                //    cls.schet5();
                //}
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                
            s +=1;
            textBox2.Text = s.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s!=0 && s>=1)
            {
                s -= 1;
                textBox2.Text = s.ToString();

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            s += 10;
            textBox2.Text = s.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (s != 0 && s>=10)
            {
                s -= 10;
                textBox2.Text = s.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            ofd.ShowDialog();
            textBox3.Text = ofd.FileName;
            path = ofd.FileName;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //ofd.ShowDialog();
            //ofd.InitialDirectory = path;
            System.Diagnostics.Process.Start(path);
        }
    }
}
