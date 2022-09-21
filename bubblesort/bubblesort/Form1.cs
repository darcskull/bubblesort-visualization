using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace bubblesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int ssize = 0;
        int min = 0;
        int max = 1000;


        private void buttonSort_Click(object sender, EventArgs e)
        {
            listBoxColor.Items.Clear();
            textBoxSort.Clear();
            if (!String.IsNullOrEmpty(textBoxList.Text) && int.TryParse(textBoxList.Text, out ssize) && ssize >= 3 && ssize <= 10)
            {
                textBoxSort.Text = "Сортиране....";
                 var arr = new int[ssize];
                var r = new Random();
                Color[] colorarr = new Color[10] { Color.BlueViolet, Color.Red, Color.Green, Color.Blue, Color.Brown, Color.Aquamarine, Color.Orange, Color.DarkGray, Color.LightBlue, Color.Pink };
                List<DrawArray> _draws = new List<DrawArray>();
               
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(min,max);
                    listBoxColor.Items.Add(colorarr[i] + " = " + arr[i]);
                   
                }
                
                for (int i = 0; i < ssize; i++)
                {
                    DrawArray draw = new DrawArray();
                    draw.Color = colorarr[i];
                    draw.Textcolor = Color.Black;
                    draw.Text = arr[i].ToString();
                    draw.Draw(80+60 * i, 400, 30);
                    _draws.Add(draw);
                }
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            var temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                            _draws[j].Textcolor = Color.Yellow;
                            _draws[j + 1].Textcolor = Color.YellowGreen;
                            Swap(_draws[j], _draws[j + 1]);

                            this.Refresh();

                            foreach (var element in _draws)
                            {

                                element.Draw(element.x, element.y, element.Size);
                            }

                            Thread.Sleep(2000);
                            _draws[j].Textcolor = Color.Black;
                            _draws[j + 1].Textcolor = Color.Black;
                        }
                    
                    }
                }
                textBoxSort.Text = "Масивът е сортиран!";
                listBoxColor.Items.Clear();
                this.Refresh();

                foreach (var element in _draws)
                {

                    element.Draw(element.x, element.y, element.Size);
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    
                    listBoxColor.Items.Add(_draws[i].Color + " = " + arr[i]);

                }

            }
            else
            {
                Invalidate();
                MessageBox.Show("Моля въведете валидна стойност между 3 и 10!");
            }
            

          

        }


        static void Swap( DrawArray dr1,DrawArray dr2)
        {
            var temp = dr1.Color;
            dr1.Color = dr2.Color;
            dr2.Color = temp;

            var temp1 = dr1.Text;
            dr1.Text = dr2.Text;
            dr2.Text = temp1;
        }

        private void listBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
