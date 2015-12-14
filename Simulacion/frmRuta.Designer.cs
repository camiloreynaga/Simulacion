namespace Simulacion
{
    partial class frmRuta
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSrg = new System.Windows.Forms.Button();
            this.tbCoordenada1 = new System.Windows.Forms.TextBox();
            this.chkOrigen1 = new System.Windows.Forms.CheckBox();
            this.tbCoordenada2 = new System.Windows.Forms.TextBox();
            this.chkOrigen2 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 103);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(464, 211);
            this.dgvGrilla.TabIndex = 15;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 74);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Open Srv file";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSrg
            // 
            this.btnSrg.Location = new System.Drawing.Point(12, 12);
            this.btnSrg.Name = "btnSrg";
            this.btnSrg.Size = new System.Drawing.Size(87, 23);
            this.btnSrg.TabIndex = 14;
            this.btnSrg.Text = "Open Srg file";
            this.btnSrg.UseVisualStyleBackColor = true;
            this.btnSrg.Click += new System.EventHandler(this.btnSrg_Click);
            // 
            // tbCoordenada1
            // 
            this.tbCoordenada1.Location = new System.Drawing.Point(134, 14);
            this.tbCoordenada1.Name = "tbCoordenada1";
            this.tbCoordenada1.Size = new System.Drawing.Size(262, 20);
            this.tbCoordenada1.TabIndex = 16;
            // 
            // chkOrigen1
            // 
            this.chkOrigen1.AutoSize = true;
            this.chkOrigen1.Location = new System.Drawing.Point(402, 18);
            this.chkOrigen1.Name = "chkOrigen1";
            this.chkOrigen1.Size = new System.Drawing.Size(57, 17);
            this.chkOrigen1.TabIndex = 17;
            this.chkOrigen1.Text = "Origen";
            this.chkOrigen1.UseVisualStyleBackColor = true;
            // 
            // tbCoordenada2
            // 
            this.tbCoordenada2.Location = new System.Drawing.Point(134, 49);
            this.tbCoordenada2.Name = "tbCoordenada2";
            this.tbCoordenada2.Size = new System.Drawing.Size(262, 20);
            this.tbCoordenada2.TabIndex = 16;
            // 
            // chkOrigen2
            // 
            this.chkOrigen2.AutoSize = true;
            this.chkOrigen2.Location = new System.Drawing.Point(402, 51);
            this.chkOrigen2.Name = "chkOrigen2";
            this.chkOrigen2.Size = new System.Drawing.Size(57, 17);
            this.chkOrigen2.TabIndex = 17;
            this.chkOrigen2.Text = "Origen";
            this.chkOrigen2.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(400, 75);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 18;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 399);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chkOrigen2);
            this.Controls.Add(this.chkOrigen1);
            this.Controls.Add(this.tbCoordenada2);
            this.Controls.Add(this.tbCoordenada1);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnSrg);
            this.Controls.Add(this.btnImport);
            this.Name = "frmRuta";
            this.Text = "frmRuta";
            this.Load += new System.EventHandler(this.frmRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSrg;
        private System.Windows.Forms.TextBox tbCoordenada1;
        private System.Windows.Forms.CheckBox chkOrigen1;
        private System.Windows.Forms.TextBox tbCoordenada2;
        private System.Windows.Forms.CheckBox chkOrigen2;
        private System.Windows.Forms.Button btnOrder;
    }
}