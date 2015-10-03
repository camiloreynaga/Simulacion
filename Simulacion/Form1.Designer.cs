namespace Simulacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbXIni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYIni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInclinada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHorizontal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVertical = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGradiente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbXFin = new System.Windows.Forms.TextBox();
            this.tbYFin = new System.Windows.Forms.TextBox();
            this.tbZFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbXIni
            // 
            this.tbXIni.Location = new System.Drawing.Point(101, 36);
            this.tbXIni.Name = "tbXIni";
            this.tbXIni.Size = new System.Drawing.Size(100, 20);
            this.tbXIni.TabIndex = 0;
            this.tbXIni.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // tbYIni
            // 
            this.tbYIni.Location = new System.Drawing.Point(101, 62);
            this.tbYIni.Name = "tbYIni";
            this.tbYIni.Size = new System.Drawing.Size(100, 20);
            this.tbYIni.TabIndex = 0;
            this.tbYIni.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // tbZIni
            // 
            this.tbZIni.Location = new System.Drawing.Point(101, 88);
            this.tbZIni.Name = "tbZIni";
            this.tbZIni.Size = new System.Drawing.Size(100, 20);
            this.tbZIni.TabIndex = 0;
            this.tbZIni.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z";
            // 
            // tbInclinada
            // 
            this.tbInclinada.Location = new System.Drawing.Point(101, 126);
            this.tbInclinada.Name = "tbInclinada";
            this.tbInclinada.Size = new System.Drawing.Size(100, 20);
            this.tbInclinada.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inclinada";
            // 
            // tbHorizontal
            // 
            this.tbHorizontal.Location = new System.Drawing.Point(101, 152);
            this.tbHorizontal.Name = "tbHorizontal";
            this.tbHorizontal.Size = new System.Drawing.Size(100, 20);
            this.tbHorizontal.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Horizontal";
            // 
            // tbVertical
            // 
            this.tbVertical.Location = new System.Drawing.Point(101, 178);
            this.tbVertical.Name = "tbVertical";
            this.tbVertical.Size = new System.Drawing.Size(100, 20);
            this.tbVertical.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vertical";
            // 
            // tbGradiente
            // 
            this.tbGradiente.Location = new System.Drawing.Point(101, 204);
            this.tbGradiente.Name = "tbGradiente";
            this.tbGradiente.Size = new System.Drawing.Size(100, 20);
            this.tbGradiente.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gradiente";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(459, 36);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbXFin
            // 
            this.tbXFin.Location = new System.Drawing.Point(217, 36);
            this.tbXFin.Name = "tbXFin";
            this.tbXFin.Size = new System.Drawing.Size(100, 20);
            this.tbXFin.TabIndex = 0;
            this.tbXFin.Text = "10";
            // 
            // tbYFin
            // 
            this.tbYFin.Location = new System.Drawing.Point(217, 62);
            this.tbYFin.Name = "tbYFin";
            this.tbYFin.Size = new System.Drawing.Size(100, 20);
            this.tbYFin.TabIndex = 0;
            this.tbYFin.Text = "10";
            // 
            // tbZFin
            // 
            this.tbZFin.Location = new System.Drawing.Point(217, 88);
            this.tbZFin.Name = "tbZFin";
            this.tbZFin.Size = new System.Drawing.Size(100, 20);
            this.tbZFin.TabIndex = 0;
            this.tbZFin.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 346);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGradiente);
            this.Controls.Add(this.tbVertical);
            this.Controls.Add(this.tbHorizontal);
            this.Controls.Add(this.tbInclinada);
            this.Controls.Add(this.tbZFin);
            this.Controls.Add(this.tbYFin);
            this.Controls.Add(this.tbZIni);
            this.Controls.Add(this.tbXFin);
            this.Controls.Add(this.tbYIni);
            this.Controls.Add(this.tbXIni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInclinada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHorizontal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVertical;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGradiente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbXFin;
        private System.Windows.Forms.TextBox tbYFin;
        private System.Windows.Forms.TextBox tbZFin;
    }
}

