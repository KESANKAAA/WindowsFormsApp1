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
        
        Stack<string> stc = new Stack<string>();
        public int s;
        public string path;
        
        //FileStream fs = new FileStream(path,false);
        public string m;


        public static int k1;
        public static List<char[]> lst1 = new List<char[]>();
        public static string[] kes;
        public static int r1;



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
            m = a;
           
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
            System.Diagnostics.Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k1 = comboBox1.Text.Length;

            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                r1 = i;
                for (int j = 0; j < comboBox1.Text.Length; j++)
                {
                    Class1 cls1 = new Class1();
                    switch (m[j])
                    {
                        case '*':
                            cls1.schet1(); 
                            break;

                        case 'L':
                            cls1.schet2();
                            break;

                        case 'l':
                            cls1.schet3();
                            break;

                        case '_':
                            cls1.schet4();
                            break;

                        case 'c':
                            cls1.schet5();
                            break;
                    }
                    cls1.dob();
                    cls1.obnul();

                 
                }
            }
            listBox1.Items.Add(kes.ToList);
        }
    }
}
