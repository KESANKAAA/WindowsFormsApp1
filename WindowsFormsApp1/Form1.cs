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
        public string path2;
        public string path3;


        //FileStream fs = new FileStream(path,false);
        public string m;


       
        public static List<char[]> lst1 = new List<char[]>();
        public static string[] kes;
       



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
  
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = sv.FileName;
                    using (Stream s = File.Open(sv.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        for (int i = 0; i < lst1.Count; i++)
                        {
                            sw.WriteLine(lst1[i]);
                        }
                    }
                }
                catch (Exception) { }
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            Class1 cls1 = new Class1();
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {  
                for (int j = 0; j < comboBox1.Text.Length; j++)
                {
                    
                    switch (comboBox1.Text[j])
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
                        default:
                            Class1.mas.Add(comboBox1.Text[j]);
                            break;   
                    }
                }
                cls1.dob();
                cls1.obnul();
                
            }
            for (int k = 0; k < lst1.Count; k++)
            {
                string a = new string(lst1[k]);
                listBox2.Items.Add(a);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path2 = sv.FileName;
                    using (Stream s = File.Open(sv.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        for (int i = 0; i < lst1.Count; i++)
                        {
                            sw.WriteLine(comboBox1.Items[i]);
                        }
                    }
                }
                catch (Exception) { }
                button2.Enabled = true;
            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                path3 = ofd.FileName;
                using (StreamReader sw = new StreamReader(path3))
                {
                    string line;
                    
                    while ((line = sw.ReadLine()) != null)
                    {
                        comboBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
