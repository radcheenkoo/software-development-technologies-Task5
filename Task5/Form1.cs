using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Прізвище, Ім'я: Радченко Дмитро\nГрупа: ІПЗ-21 к2\nНомер варіанту: 3", "About");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                using (Graphics g = pb.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black);
                    SolidBrush redBrush = new SolidBrush(Color.Red);
                    SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
                    SolidBrush greenBrush = new SolidBrush(Color.Green);
                    SolidBrush backgroundBrush = new SolidBrush(Color.Olive);
                    SolidBrush borderBrush = new SolidBrush(Color.Gray);

                    // Задній план
                    g.FillRectangle(borderBrush, 10, 10, 80, 200);
                    g.FillRectangle(backgroundBrush, 15, 15, 70, 190);

                    // Червоний круг
                    g.FillEllipse(redBrush, 25, 25, 50, 50);
                    g.DrawEllipse(pen, 25, 25, 50, 50);

                    // Жовтий круг
                    g.FillEllipse(yellowBrush, 25, 75, 50, 50);
                    g.DrawEllipse(pen, 25, 75, 50, 50);

                    // Зелений круг
                    g.FillEllipse(greenBrush, 25, 125, 50, 50);
                    g.DrawEllipse(pen, 25, 125, 50, 50);

                    // Очистка ресурсів
                    pen.Dispose();
                    redBrush.Dispose();
                    yellowBrush.Dispose();
                    greenBrush.Dispose();
                    backgroundBrush.Dispose();
                    borderBrush.Dispose();
                }
            }

        }
    }
}
