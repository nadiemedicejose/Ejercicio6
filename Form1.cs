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

namespace Ejercicio6
{
    public partial class Parte1 : Form
    {
        public Parte1()
        {
            InitializeComponent();
        }

        private void Parte2_Click(object sender, EventArgs e)
        {
            Parte2 ir = new Parte2();
            ir.Show();
            this.Hide();
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            Graphics Panel;
            Panel = Whiteboard.CreateGraphics();

            Color[] color =
            {
                Color.Black,
                ColorTranslator.FromHtml("#4218b8"),
                ColorTranslator.FromHtml("#00c0ff"),
                ColorTranslator.FromHtml("#a32cdf"),
                ColorTranslator.FromHtml("#10cad2")
            };

            Pen contorno = new Pen(color[1], 1.5f);
            Pen contorno2 = new Pen(color[1], 3);

            SolidBrush relleno1 = new SolidBrush(color[2]);
            Rectangle rect1 = new Rectangle(15, 15, 200, 150);
            Panel.FillRectangle(relleno1, rect1);
            Panel.DrawRectangle(contorno, rect1);

            SolidBrush relleno2 = new SolidBrush(color[4]);
            Rectangle rect2 = new Rectangle(225, 15, 200, 150);
            Panel.FillRectangle(relleno2, rect2);
            Panel.DrawRectangle(contorno, rect2);

            Rectangle rect3 = new Rectangle(15, 175, 200, 200);
            LinearGradientBrush lgb1 = new LinearGradientBrush(rect3, color[1], color[2], LinearGradientMode.Vertical);
            lgb1.GammaCorrection = true;
            Panel.FillEllipse(lgb1, rect3);
            Panel.DrawEllipse(contorno, rect3);

            Rectangle rect4 = new Rectangle(225, 175, 200, 200);
            LinearGradientBrush lgb2 = new LinearGradientBrush(rect4, color[3], color[4], LinearGradientMode.Vertical);
            lgb2.GammaCorrection = true;
            Panel.FillEllipse(lgb2, rect4);
            Panel.DrawEllipse(contorno, rect4);

            // MOSAICO
            Rectangle mosaico2 = new Rectangle(535, 15, 100, 100);
            Panel.FillRectangle(relleno1, mosaico2);
            Panel.DrawRectangle(contorno, mosaico2);

            Rectangle mosaico3 = new Rectangle(435, 115, 100, 100);
            Panel.FillRectangle(relleno1, mosaico3);
            Panel.DrawRectangle(contorno, mosaico3);

            Rectangle mosaico1 = new Rectangle(435, 15, 100, 100);
            LinearGradientBrush lgb3 = new LinearGradientBrush(mosaico1, color[1], color[2], LinearGradientMode.Vertical);
            lgb1.GammaCorrection = true;
            Panel.FillRectangle(lgb3, mosaico1);
            Panel.DrawRectangle(contorno2, mosaico1);

            Rectangle mosaico4 = new Rectangle(535, 115, 100, 100);
            LinearGradientBrush lgb4 = new LinearGradientBrush(mosaico4, color[1], color[2], LinearGradientMode.Vertical);
            lgb1.GammaCorrection = true;
            Panel.FillRectangle(lgb4, mosaico4);
            Panel.DrawRectangle(contorno2, mosaico4);
        }
    }
}
