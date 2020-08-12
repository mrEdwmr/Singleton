namespace PrySingleton
{
    partial class frmDetalles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecVenta = new System.Windows.Forms.TextBox();
            this.txtPrecComp = new System.Windows.Forms.TextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.cmbProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtprecVenta);
            this.panel1.Controls.Add(this.txtPrecComp);
            this.panel1.Controls.Add(this.txtGanancia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 432);
            this.panel1.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(505, 315);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 99;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(251, 28);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(205, 33);
            this.cmbProd.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ganancia";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtStock.Location = new System.Drawing.Point(254, 260);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(205, 33);
            this.txtStock.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // txtprecVenta
            // 
            this.txtprecVenta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtprecVenta.Location = new System.Drawing.Point(254, 179);
            this.txtprecVenta.Name = "txtprecVenta";
            this.txtprecVenta.Size = new System.Drawing.Size(205, 33);
            this.txtprecVenta.TabIndex = 13;
            // 
            // txtPrecComp
            // 
            this.txtPrecComp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPrecComp.Location = new System.Drawing.Point(251, 97);
            this.txtPrecComp.Name = "txtPrecComp";
            this.txtPrecComp.Size = new System.Drawing.Size(208, 33);
            this.txtPrecComp.TabIndex = 12;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtGanancia.Location = new System.Drawing.Point(251, 332);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(208, 33);
            this.txtGanancia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Producto";
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 452);
            this.Controls.Add(this.panel1);
            this.Name = "frmDetalles";
            this.Text = "frmDetalles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtprecVenta;
        public System.Windows.Forms.TextBox txtPrecComp;
        public System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnInsert;
    }
}