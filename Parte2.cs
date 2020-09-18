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
    public partial class Parte2 : Form
    {
        public Parte2()
        {
            InitializeComponent();
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            Graphics Panel;
            Panel = Whiteboard.CreateGraphics();

            Pen contorno1 = new Pen(Color.Black, 1);
            Pen contorno2 = new Pen(Color.Black, 2);
            Pen contorno3 = new Pen(Color.Black, 5);
            Pen lineas1 = new Pen(Color.Black, 1) { DashPattern = new float[] {5, 5} };

            Color Verde = ColorTranslator.FromHtml("#00F000");
            Color Morado = ColorTranslator.FromHtml("#B266FF");
            Color Amarillo = ColorTranslator.FromHtml("#F2F200");

            SolidBrush Relleno1 = new SolidBrush(Verde);
            SolidBrush Relleno2 = new SolidBrush(Morado);
            SolidBrush Relleno3 = new SolidBrush(Amarillo);

            // FIGURAS
            // Tamaño
            int ancho = 120;
            int alto = 280;
            Size tamaño = new Size(ancho, alto); // Igual para todas las figuras

            // Ubicación
            int fila1 = 15; // Figuras 1-6 (primera fila)
            int fila2 = 305; // Figuras 7-12 (segunda fila)

            int col1 = 15;
            int col2 = 145;
            int col3 = 275;
            int col4 = 405;
            int col5 = 535;
            int col6 = 665;

            Point[] ubicacion = {
                // Fila 1
                new Point(col1, fila1), // ubicacion[0]
                new Point(col2, fila1),
                new Point(col3, fila1),
                new Point(col4, fila1),
                new Point(col5, fila1),
                new Point(col6, fila1),

                // Fila 2
                new Point(col1, fila2),
                new Point(col2, fila2),
                new Point(col3, fila2),
                new Point(col4, fila2),
                new Point(col5, fila2),
                new Point(col6, fila2)
            };

            Rectangle[] rectangulo = {
                new Rectangle(ubicacion[0], tamaño), // Fig 1
                new Rectangle(ubicacion[1], tamaño), // Fig 2
                new Rectangle(ubicacion[2], tamaño), // Fig 3
                new Rectangle(ubicacion[3], tamaño),
                new Rectangle(ubicacion[4], tamaño),
                new Rectangle(ubicacion[5], tamaño),
                new Rectangle(ubicacion[6], tamaño),
                new Rectangle(ubicacion[7], tamaño),
                new Rectangle(ubicacion[8], tamaño),
                new Rectangle(ubicacion[9], tamaño),
                new Rectangle(ubicacion[10], tamaño),
                new Rectangle(ubicacion[11], tamaño)
            };

            // Fig 1. Diagonal
            Point[] diagonal = {
                new Point(col1, fila1 + alto), // Inicio
                new Point(col1 + ancho, fila1) // Final
            };
            Panel.DrawLine(contorno1, diagonal[0], diagonal[1]);

            // Fig 2. Borde de rectángulo
            Panel.DrawRectangle(contorno2, rectangulo[1]);

            // Fig 3. Borde redondo y dashed de rectángulo
            DrawRoundedRectangle(Panel, lineas1, col3, fila1, ancho, alto, 25, 25);
            //Panel.DrawRectangle(lineas1, rectangulo[2]);

            // Fig 4. Arco
            float aInicial4 = 135; // Angulo inicial
            float barrido4 = 160; // Barrido
            Panel.DrawArc(contorno3, rectangulo[3], aInicial4, barrido4);

            // Fig 5. Borde de elipse
            Panel.DrawEllipse(contorno3, rectangulo[4]);

            // Fig 6. Collate
            Point[] figura6 = {
                new Point(col6, fila1),
                new Point(col6 + ancho, fila1),
                new Point(col6, fila1 + alto),
                new Point(col6 + ancho, fila1 + alto),
                new Point(col6,fila1)
            };
            Panel.DrawLines(contorno2, figura6);

            // Fig 7. Semi collate
            Point[] figura7 = {
                new Point(col1, fila2),
                new Point(col1 + ancho, fila2 + alto),
                new Point(col1, fila2 + alto),
                new Point(col1 + ancho, fila2)
            };
            Panel.DrawLines(contorno2, figura7);

            // Fig 8. Relleno de rectángulo
            Panel.FillRectangle(Relleno1, rectangulo[7]);

            // Fig 9. Relleno de rectángulo con borde redondo
            LinearGradientBrush Degradado1 = new LinearGradientBrush(rectangulo[8], Verde, Morado, LinearGradientMode.Horizontal);
            Degradado1.GammaCorrection = true;
            FillRoundedRectangle(Panel, Degradado1, col3, fila2, ancho, alto, 25, 25);
            //Panel.FillRectangle(Degradado1, rectangulo[8]);

            // Fig 10. Pie o arco relleno
            float aInicial10 = 135; // Angulos
            float barrido10 = 135;
            Panel.FillPie(Relleno2, rectangulo[9], aInicial10, barrido10);

            // Fig 11. Relleno de elipse
            LinearGradientBrush Degradado2 = new LinearGradientBrush(rectangulo[10], Morado, Amarillo, LinearGradientMode.Horizontal);
            Degradado2.GammaCorrection = true;
            Panel.FillEllipse(Degradado2, rectangulo[10]);

            // Fig 12. Collate relleno con borde
            Point[] fig12 = {
                new Point(col6, fila2),
                new Point(col6 + ancho, fila2),
                new Point(col6, fila2 + alto),
                new Point(col6 + ancho,fila2 + alto),
                new Point(col6, fila2)
            };
            GraphicsPath figura12 = new GraphicsPath();
            figura12.AddLines(fig12);
            Panel.FillPath(Relleno3, figura12);
            Panel.DrawPath(contorno3, figura12);
        }

        static void DrawRoundedRectangle(Graphics g, Pen p, int x, int y, int w, int h, int rx, int ry)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, rx + rx, ry + ry, 180, 90);
            path.AddLine(x + rx, y, x + w - rx, y);
            path.AddArc(x + w - 2 * rx, y, 2 * rx, 2 * ry, 270, 90);
            path.AddLine(x + w, y + ry, x + w, y + h - ry);
            path.AddArc(x + w - 2 * rx, y + h - 2 * ry, rx + rx, ry + ry, 0, 91);
            path.AddLine(x + rx, y + h, x + w - rx, y + h);
            path.AddArc(x, y + h - 2 * ry, 2 * rx, 2 * ry, 90, 91);
            path.CloseFigure();
            g.DrawPath(p, path);
        }

        static void FillRoundedRectangle(Graphics g, Brush b, int x, int y, int w, int h, int rx, int ry)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, rx + rx, ry + ry, 180, 90);
            path.AddLine(x + rx, y, x + w - rx, y);
            path.AddArc(x + w - 2 * rx, y, 2 * rx, 2 * ry, 270, 90);
            path.AddLine(x + w, y + ry, x + w, y + h - ry);
            path.AddArc(x + w - 2 * rx, y + h - 2 * ry, rx + rx, ry + ry, 0, 91);
            path.AddLine(x + rx, y + h, x + w - rx, y + h);
            path.AddArc(x, y + h - 2 * ry, 2 * rx, 2 * ry, 90, 91);
            path.CloseFigure();
            g.FillPath(b, path);
        }

        private void Parte1_Click(object sender, EventArgs e)
        {
            Parte1 ir = new Parte1();
            ir.Show();
            this.Hide();
        }
    }
}
