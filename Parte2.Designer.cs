namespace Ejercicio6
{
    partial class Parte2
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
            this.dibujar = new System.Windows.Forms.Button();
            this.Whiteboard = new System.Windows.Forms.PictureBox();
            this.Parte1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Whiteboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dibujar
            // 
            this.dibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dibujar.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibujar.Location = new System.Drawing.Point(12, 12);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(144, 41);
            this.dibujar.TabIndex = 0;
            this.dibujar.Text = "Dibujar";
            this.dibujar.UseVisualStyleBackColor = true;
            this.dibujar.Click += new System.EventHandler(this.dibujar_Click);
            // 
            // Whiteboard
            // 
            this.Whiteboard.BackColor = System.Drawing.Color.Transparent;
            this.Whiteboard.Location = new System.Drawing.Point(12, 59);
            this.Whiteboard.Name = "Whiteboard";
            this.Whiteboard.Size = new System.Drawing.Size(800, 600);
            this.Whiteboard.TabIndex = 1;
            this.Whiteboard.TabStop = false;
            // 
            // Parte1
            // 
            this.Parte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parte1.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parte1.Location = new System.Drawing.Point(668, 12);
            this.Parte1.Name = "Parte1";
            this.Parte1.Size = new System.Drawing.Size(144, 41);
            this.Parte1.TabIndex = 2;
            this.Parte1.Text = "Parte 1";
            this.Parte1.UseVisualStyleBackColor = true;
            this.Parte1.Click += new System.EventHandler(this.Parte1_Click);
            // 
            // Parte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 671);
            this.Controls.Add(this.Parte1);
            this.Controls.Add(this.Whiteboard);
            this.Controls.Add(this.dibujar);
            this.Name = "Parte2";
            this.Text = "Actividad 7. Solución de Ejercicios. Parte 2";
            ((System.ComponentModel.ISupportInitialize)(this.Whiteboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dibujar;
        private System.Windows.Forms.PictureBox Whiteboard;
        private System.Windows.Forms.Button Parte1;
    }
}