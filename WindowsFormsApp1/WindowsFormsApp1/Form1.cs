using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public Graphics plato;
        Pen p1 = new Pen(Color.Blue,3);
        Pen p2 = new Pen(Color.HotPink, 2);
        Brush br = new SolidBrush(Color.AliceBlue);
        public float ug1, ug2;

        public List<List<(float, float)>> list = new List<List<(float, float)>>();

        public List<(float, float)> lst = new List<(float, float)>();
        public List<(float, float)> lst1 = new List<(float, float)>();
        public List<(float, float)> lst2 = new List<(float, float)>();
        public List<(float, float)> lst3 = new List<(float, float)>();

        public int sw;

        private void button1_Click(object sender, EventArgs e)
        {
            plato.Clear(Color.White);
            lst.Clear();
            lst1.Clear();
            lst2.Clear();
            lst3.Clear();

            switch (sw)
            {
                case 3:
                    kr3();
                    break;

                case 6:
                    kr6();
                    break;

                case 9:
                    kr9();
                    break;

                case 12:
                    kr12();
                    break;
            }


        }
        public void postr(Pen p, float gr1, float gr2,int k,int size1,int size2)
        {
            for (int i = 0; i < k; i++)
            {
                Rectangle r = new Rectangle();
                r.Size = new Size(size1,size2);
                r.X = pictureBox1.Width / 2 - r.Size.Width / 2;
                r.Y = pictureBox1.Height / 2 - r.Size.Height / 2;
                plato.DrawArc(p1, r, gr1, gr2);

                //Рисование точек
                double a, b;
                a = (pictureBox1.Width / 2) + r.Size.Width / 2 * Math.Cos((gr1 * Math.PI) / 180);
                b = (pictureBox1.Height / 2) + r.Size.Height / 2 * Math.Sin((gr1 * Math.PI) / 180);
                plato.DrawEllipse(p2, (float)a - 2, (float)b - 2, 4, 4);
                lst.Add(((float)a,(float)b));
                gr1 += gr2;
            }
        }

        

        public void kr3()
        {     
            postr(p1, 0,30,12,200,200);
            postr(p1,0,30,12,150,150);
            postr(p1, 0, 60, 6, 100, 100);
            zapis();
            ris();
        }

        public void kr6() 
        {
            postr(p1, 0, 15, 24, 300, 300);
            postr(p1, 0, 15, 24, 250, 250);
            postr(p1, 0, 30, 12, 200, 200);
            postr(p1, 0, 30, 12, 150, 150);
            postr(p1, 0, 60, 6, 100, 100);
            postr(p1, 0, 60, 6, 50, 50);
            zapis();
            ris();
        }
        public void kr9()
        {
            postr(p1, 0, 7.5F, 48, 450, 450);
            postr(p1, 0, 7.5F, 48, 400, 400);
            postr(p1, 0, 7.5F, 48, 350, 350);

            postr(p1, 0, 15, 24, 300, 300);
            postr(p1, 0, 15, 24, 250, 250);
            postr(p1, 0, 15, 24, 200, 200);

            postr(p1, 0, 30, 12, 150, 150);
            postr(p1, 0, 30, 12, 100, 100);
            postr(p1, 0, 30, 12, 50, 50);
            zapis();
            ris();
        }
        public void kr12()
        {
            postr(p1, 0, 7.5F, 48, 420, 420);
            postr(p1, 0, 7.5F, 48, 385, 385);
            postr(p1, 0, 7.5F, 48, 350, 350);

            postr(p1, 0, 15, 24, 315, 315);
            postr(p1, 0, 15, 24, 280, 280);
            postr(p1, 0, 15, 24, 245, 245);

            postr(p1, 0, 30, 12, 210, 210);
            postr(p1, 0, 30, 12, 175,175);
            postr(p1, 0, 30, 12, 140, 140);

            postr(p1, 0, 60, 6, 105, 105);
            postr(p1, 0, 60, 6, 70, 70);
            postr(p1, 0, 60, 6, 35, 35);
            zapis();
            ris();
        }


        public void zapis() 
        {
            switch (lst.Count)
            {
                case 30:

                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(new List<(float, float)>());
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        list[0].Add(lst[i]);
                        Console.WriteLine(list[0][i]);
                    }

                    Console.WriteLine("");

                    for (int i = 12; i < 24; i++)
                    {
                        list[1].Add(lst[i]);
                        Console.WriteLine(list[1][i - 12]);
                    }
                    Console.WriteLine("");

                    for (int i = 24; i < 30; i++)
                    {
                        list[2].Add(lst[i]);
                        Console.WriteLine(list[2][i - 24]);
                    }

                    Console.WriteLine("");

                    break;

                case 84:

                    for (int i = 0; i < 6; i++)
                    {
                        list.Add(new List<(float, float)>());
                        Console.WriteLine(list.Count);
                    }
                  
                    for (int i = 0; i < 24; i++)
                    {
                        list[0].Add(lst[i]);                      
                    }

                    for (int i = 24; i < 48; i++)
                    {
                        list[1].Add(lst[i]);
                    }

                    for (int i = 48; i < 60; i++)
                    {
                        list[2].Add(lst[i]);
                    }

                    for (int i = 60; i < 72; i++)
                    {
                        list[3].Add(lst[i]);
                    }

                    for (int i = 72; i < 78; i++)
                    {
                        list[4].Add(lst[i]);
                    }
                    for (int i = 78; i < 84; i++)
                    {
                        list[5].Add(lst[i]);
                    }
                    break;

                case 252:

                    for (int i = 0; i < 9; i++)
                    {
                        list.Add(new List<(float, float)>());
                        Console.WriteLine(list.Count);
                    }
                    Console.WriteLine();

                    for (int i = 0; i < 48; i++)
                    {
                        list[0].Add(lst[i]);
                        Console.WriteLine(list[0][i]);
                    }
                    Console.WriteLine("");

                    for (int i = 48; i < 96; i++)
                    {
                        list[1].Add(lst[i]);
                        Console.WriteLine(list[1][i - 48]);
                    }
                    Console.WriteLine("");

                    for (int i = 96; i < 144; i++)
                    {
                        list[2].Add(lst[i]);
                        Console.WriteLine(list[2][i - 96]);
                    }
                    Console.WriteLine("");

                    for (int i = 144; i < 168; i++)
                    {
                        list[3].Add(lst[i]);
                        Console.WriteLine(list[3][i - 144]);
                    }
                    Console.WriteLine("");

                    for (int i = 168; i < 192; i++)
                    {
                        list[4].Add(lst[i]);
                        Console.WriteLine(list[4][i - 168]);
                    }
                    Console.WriteLine("");

                    for (int i = 192; i < 216; i++)
                    {
                        list[5].Add(lst[i]);
                        Console.WriteLine(list[5][i - 192]);
                    }
                    Console.WriteLine("");

                    for (int i = 216; i < 228; i++)
                    {
                        list[6].Add(lst[i]);
                        Console.WriteLine(list[6][i - 216]);
                    }
                    Console.WriteLine("");

                    for (int i = 228; i < 240; i++)
                    {
                        list[7].Add(lst[i]);
                        Console.WriteLine(list[7][i - 228]);
                    }
                    Console.WriteLine("");

                    for (int i = 240; i < 252; i++)
                    {
                        list[8].Add(lst[i]);
                        Console.WriteLine(list[8][i - 240]);
                    }
                    Console.WriteLine("");

                    break;

                case 270:
                    for (int i = 0; i < 12; i++)
                    {
                        list.Add(new List<(float, float)>());
                        Console.WriteLine(list.Count);
                    }
                    Console.WriteLine();

                    for (int i = 0; i < 48; i++)
                    {
                        list[0].Add(lst[i]);
                        Console.WriteLine(list[0][i]);
                    }
                    Console.WriteLine("");
                    for (int i = 48; i < 96; i++)
                    {
                        list[1].Add(lst[i]);
                        Console.WriteLine(list[1][i - 48]);
                    }
                    Console.WriteLine("");
                    for (int i = 96; i < 144; i++)
                    {
                        list[2].Add(lst[i]);
                        Console.WriteLine(list[2][i - 96]);
                    }
                    Console.WriteLine("");


                    for (int i = 144; i < 168; i++)
                    {
                        list[3].Add(lst[i]);
                        Console.WriteLine(list[3][i - 144]);
                    }
                    Console.WriteLine("");
                    for (int i = 168; i < 192; i++)
                    {
                        list[4].Add(lst[i]);
                        Console.WriteLine(list[4][i - 168]);
                    }
                    Console.WriteLine("");
                    for (int i = 192; i < 216; i++)
                    {
                        list[5].Add(lst[i]);
                        Console.WriteLine(list[5][i - 192]);
                    }
                    Console.WriteLine("");


                    for (int i = 216; i < 228; i++)
                    {
                        list[6].Add(lst[i]);
                        Console.WriteLine(list[6][i - 216]);
                    }
                    Console.WriteLine("");
                    for (int i = 228; i < 240; i++)
                    {
                        list[7].Add(lst[i]);
                        Console.WriteLine(list[7][i - 228]);
                    }
                    Console.WriteLine("");
                    for (int i = 240; i < 252; i++)
                    {
                        list[8].Add(lst[i]);
                        Console.WriteLine(list[8][i - 240]);
                    }
                    Console.WriteLine("");


                    for (int i = 252; i < 258; i++)
                    {
                        list[9].Add(lst[i]);
                        Console.WriteLine(list[9][i - 252]);
                    }
                    Console.WriteLine("");
                    for (int i = 258; i < 264; i++)
                    {
                        list[10].Add(lst[i]);
                        Console.WriteLine(list[10][i - 258]);
                    }
                    Console.WriteLine("");
                    for (int i = 264; i < 270; i++)
                    {
                        list[11].Add(lst[i]);
                        Console.WriteLine(list[11][i - 264]);
                    }
                    Console.WriteLine("");
                    break;
            }
        }
        //lst1 - 6
        //lst1 - 12
        //lst1 - 12

        public void risv1() 
        {
            int j = 0;
        }
        public void ris()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Count);
            }

            int j = 0;
            switch (lst.Count)
            {
                case 30:
                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[2][i].Item1, list[2][i].Item2, list[1][j].Item1, list[1][j].Item2);
                        j += 2;
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[0][i].Item1, list[0][i].Item2, list[1][i].Item1, list[1][i].Item2);
                    }
                    break;

                case 84:
                    int ks = 0;

                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[4][i].Item1, list[4][i].Item2, list[5][i].Item1, list[5][i].Item2);
                    }

                    Console.WriteLine(list[4].Count + " " + list[5].Count);

                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[3][ks].Item1, list[3][ks].Item2, list[4][i].Item1, list[4][i].Item2);
                        ks += 2;
                    }
                    ks = 0;
                    for (int i = 0; i < 12; i++) 
                    {
                        plato.DrawLine(p1, list[2][i].Item1, list[2][i].Item2, list[3][i].Item1, list[3][i].Item2);
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[1][ks].Item1, list[1][ks].Item2, list[2][i].Item1, list[2][i].Item2);
                        ks += 2;
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[0][i].Item1, list[0][i].Item2, list[1][i].Item1, list[1][i].Item2);
                    }

                    break;

                case 252:
                    int rs = 0;

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[7][i].Item1, list[7][i].Item2, list[8][i].Item1, list[8][i].Item2);
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[6][i].Item1, list[6][i].Item2, list[7][i].Item1, list[7][i].Item2);
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[5][rs].Item1, list[5][rs].Item2, list[6][i].Item1, list[6][i].Item2);
                        rs += 2;
                    }


                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[4][i].Item1, list[4][i].Item2, list[5][i].Item1, list[5][i].Item2);
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[3][i].Item1, list[3][i].Item2, list[4][i].Item1, list[4][i].Item2);
                    }
                    rs = 0;
                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[2][rs].Item1, list[2][rs].Item2, list[3][i].Item1, list[3][i].Item2);
                        rs += 2;
                    }

                    for (int i = 0; i < 48; i++)
                    {
                        plato.DrawLine(p1, list[1][i].Item1, list[1][i].Item2, list[2][i].Item1, list[2][i].Item2);
                    }

                    for (int i = 0; i < 48; i++)
                    {
                        plato.DrawLine(p1, list[0][i].Item1, list[0][i].Item2, list[1][i].Item1, list[1][i].Item2);
                    }
                    break;

                case 270:
                    int ms = 0;

                    for (int i = 0; i < 48; i++)
                    {
                        plato.DrawLine(p1, list[0][i].Item1, list[0][i].Item2, list[1][i].Item1, list[1][i].Item2);
                    }

                    for (int i = 0; i < 48; i++)
                    {
                        plato.DrawLine(p1, list[1][i].Item1, list[1][i].Item2, list[2][i].Item1, list[2][i].Item2);
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[2][ms].Item1, list[2][ms].Item2, list[3][i].Item1, list[3][i].Item2);
                        ms += 2;
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[3][i].Item1, list[3][i].Item2, list[4][i].Item1, list[4][i].Item2);
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        plato.DrawLine(p1, list[4][i].Item1, list[4][i].Item2, list[5][i].Item1, list[5][i].Item2);
                    }
                    ms = 0;

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[5][ms].Item1, list[5][ms].Item2, list[6][i].Item1, list[6][i].Item2);
                        ms += 2;
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[6][i].Item1, list[6][i].Item2, list[7][i].Item1, list[7][i].Item2);
                    }

                    for (int i = 0; i < 12; i++)
                    {
                        plato.DrawLine(p1, list[7][i].Item1, list[7][i].Item2, list[8][i].Item1, list[8][i].Item2);
                    }
                    ms= 0;
                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[8][ms].Item1, list[8][ms].Item2, list[9][i].Item1, list[9][i].Item2);
                        ms += 2;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[9][i].Item1, list[9][i].Item2, list[10][i].Item1, list[10][i].Item2);
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        plato.DrawLine(p1, list[10][i].Item1, list[10][i].Item2, list[11][i].Item1, list[11][i].Item2);
                    }
                    break;

            }
            lst.Clear();
            list.Clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            sw = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            sw = 6;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sw = 9;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            sw = 12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plato = pictureBox1.CreateGraphics();
        }
    } 
}
