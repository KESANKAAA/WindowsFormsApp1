using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
                if (a[i]=='*')
                {
                    Class1 cls = new Class1();
                    cls.schet1();
                }

                else if(a[i] == 'L')
                {
                    Class1 cls = new Class1();
                    cls.schet2();
                }
                
                else if (a[i] == 'l')
                {
                    Class1 cls = new Class1();
                    cls.schet3();
                }
                
                else if (a[i] == '_')
                {
                    Class1 cls = new Class1();
                    cls.schet4();
                }
                else if (a[i] == 'c')
                {
                    Class1 cls = new Class1();
                    cls.schet5();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
