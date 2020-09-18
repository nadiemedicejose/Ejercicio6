namespace Ejercicio6
{
    partial class Parte1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Parte2 = new System.Windows.Forms.Button();
            this.Whiteboard = new System.Windows.Forms.PictureBox();
            this.dibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Whiteboard)).BeginInit();
            this.SuspendLayout();
            // 
            // Parte2
            // 
            this.Parte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parte2.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parte2.Location = new System.Drawing.Point(668, 10);
            this.Parte2.Name = "Parte2";
            this.Parte2.Size = new System.Drawing.Size(144, 41);
            this.Parte2.TabIndex = 5;
            this.Parte2.Text = "Parte 2";
            this.Parte2.UseVisualStyleBackColor = true;
            this.Parte2.Click += new System.EventHandler(this.Parte2_Click);
            // 
            // Whiteboard
            // 
            this.Whiteboard.BackColor = System.Drawing.Color.Transparent;
            this.Whiteboard.Location = new System.Drawing.Point(12, 57);
            this.Whiteboard.Name = "Whiteboard";
            this.Whiteboard.Size = new System.Drawing.Size(800, 381);
            this.Whiteboard.TabIndex = 4;
            this.Whiteboard.TabStop = false;
            // 
            // dibujar
            // 
            this.dibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dibujar.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibujar.Location = new System.Drawing.Point(12, 10);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(144, 41);
            this.dibujar.TabIndex = 3;
            this.dibujar.Text = "Dibujar";
            this.dibujar.UseVisualStyleBackColor = true;
            this.dibujar.Click += new System.EventHandler(this.dibujar_Click);
            // 
            // Parte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.Parte2);
            this.Controls.Add(this.Whiteboard);
            this.Controls.Add(this.dibujar);
            this.Name = "Parte1";
            this.Text = "Actividad 7. Solución de Ejercicios. Parte 1";
            ((System.ComponentModel.ISupportInitialize)(this.Whiteboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Parte2;
        private System.Windows.Forms.PictureBox Whiteboard;
        private System.Windows.Forms.Button dibujar;
    }
}

