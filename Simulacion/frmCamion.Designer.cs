namespace Simulacion
{
    partial class frmCamion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvSpeed = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gradient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFuel = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 396);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truck Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payload";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 2;
            // 
            // dgvSpeed
            // 
            this.dgvSpeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Use,
            this.Gradient,
            this.Full,
            this.Empty});
            this.dgvSpeed.Location = new System.Drawing.Point(13, 73);
            this.dgvSpeed.Name = "dgvSpeed";
            this.dgvSpeed.Size = new System.Drawing.Size(556, 277);
            this.dgvSpeed.TabIndex = 3;
            this.dgvSpeed.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSpeed_CellValidating);
            this.dgvSpeed.CurrentCellChanged += new System.EventHandler(this.dgvSpeed_CurrentCellChanged);
            this.dgvSpeed.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpeed_RowLeave);
            // 
            // Number
            // 
            this.Number.HeaderText = "N°";
            this.Number.Name = "Number";
            this.Number.Width = 30;
            // 
            // Use
            // 
            this.Use.HeaderText = "Use";
            this.Use.Name = "Use";
            this.Use.Width = 30;
            // 
            // Gradient
            // 
            this.Gradient.HeaderText = "Gradient";
            this.Gradient.Name = "Gradient";
            // 
            // Full
            // 
            this.Full.HeaderText = "Full";
            this.Full.Name = "Full";
            // 
            // Empty
            // 
            this.Empty.HeaderText = "Empty";
            this.Empty.Name = "Empty";
            // 
            // dgvFuel
            // 
            this.dgvFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuel.Location = new System.Drawing.Point(575, 73);
            this.dgvFuel.Name = "dgvFuel";
            this.dgvFuel.Size = new System.Drawing.Size(199, 176);
            this.dgvFuel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Speed by Gradient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fuel Consumption by Gradient";
            // 
            // frmCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 440);
            this.Controls.Add(this.dgvFuel);
            this.Controls.Add(this.dgvSpeed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmCamion";
            this.Text = "frmCamion";
            this.Load += new System.EventHandler(this.frmCamion_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.dgvSpeed, 0);
            this.Controls.SetChildIndex(this.dgvFuel, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvSpeed;
        private System.Windows.Forms.DataGridView dgvFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Use;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gradient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empty;
    }
}