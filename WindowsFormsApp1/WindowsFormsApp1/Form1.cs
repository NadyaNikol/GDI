using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int sizeRect = 80;

            Graphics graphics = e.Graphics;

            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();
            rect1.Size = rect2.Size = new Size(sizeRect, sizeRect);

            int step1 = 0, step2=0;
       

            HatchBrush hatchBrush1 = new HatchBrush(HatchStyle.DarkHorizontal, Color.Black);
            HatchBrush hatchBrush2 = new HatchBrush(HatchStyle.DarkHorizontal, Color.White);


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    rect1.Location = new Point(step1, step2);
                    rect2.Location = new Point(step1+ sizeRect, step2);

                    if (i % 2 == 0)
                    {
                        graphics.FillRectangle(Brushes.Black, rect1);
                        graphics.FillRectangle(Brushes.White, rect2);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Black, rect2);
                        graphics.FillRectangle(Brushes.White, rect1);
                    }


                    step1 += sizeRect*2;
                }

                step1 = 0;
                step2 += sizeRect;

     
                
            }
        }
    }
}
