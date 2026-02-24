namespace WindowsFormsApp1
{
    partial class ReportesVentasProduccion
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
            this.listVentas = new System.Windows.Forms.ListBox();
            this.lbl_stockDisponible = new System.Windows.Forms.Label();
            this.lbl_ingresosTotales = new System.Windows.Forms.Label();
            this.lbl_VentasT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listVentas
            // 
            this.listVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(231)))));
            this.listVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVentas.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVentas.FormattingEnabled = true;
            this.listVentas.ItemHeight = 10;
            this.listVentas.Location = new System.Drawing.Point(184, 188);
            this.listVentas.Name = "listVentas";
            this.listVentas.Size = new System.Drawing.Size(416, 280);
            this.listVentas.TabIndex = 36;
            // 
            // lbl_stockDisponible
            // 
            this.lbl_stockDisponible.AutoSize = true;
            this.lbl_stockDisponible.Font = new System.Drawing.Font("Milk Days", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockDisponible.Location = new System.Drawing.Point(656, 388);
            this.lbl_stockDisponible.Name = "lbl_stockDisponible";
            this.lbl_stockDisponible.Size = new System.Drawing.Size(250, 25);
            this.lbl_stockDisponible.TabIndex = 35;
            this.lbl_stockDisponible.Text = "Stock Disponible";
            // 
            // lbl_ingresosTotales
            // 
            this.lbl_ingresosTotales.AutoSize = true;
            this.lbl_ingresosTotales.Font = new System.Drawing.Font("Milk Days", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresosTotales.Location = new System.Drawing.Point(653, 298);
            this.lbl_ingresosTotales.Name = "lbl_ingresosTotales";
            this.lbl_ingresosTotales.Size = new System.Drawing.Size(253, 25);
            this.lbl_ingresosTotales.TabIndex = 34;
            this.lbl_ingresosTotales.Text = "Ingresos Totales";
            // 
            // lbl_VentasT
            // 
            this.lbl_VentasT.AutoSize = true;
            this.lbl_VentasT.Font = new System.Drawing.Font("Milk Days", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentasT.Location = new System.Drawing.Point(652, 200);
            this.lbl_VentasT.Name = "lbl_VentasT";
            this.lbl_VentasT.Size = new System.Drawing.Size(226, 25);
            this.lbl_VentasT.TabIndex = 33;
            this.lbl_VentasT.Text = "Ventas Totales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Stock Disponible:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ingresos Totales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ventas Totales:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 531);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(885, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(909, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.ventasRe;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(940, 598);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // ReportesVentasProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listVentas);
            this.Controls.Add(this.lbl_stockDisponible);
            this.Controls.Add(this.lbl_ingresosTotales);
            this.Controls.Add(this.lbl_VentasT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesVentasProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesVentasProduccion";
            this.Load += new System.EventHandler(this.ReportesVentasProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listVentas;
        private System.Windows.Forms.Label lbl_stockDisponible;
        private System.Windows.Forms.Label lbl_ingresosTotales;
        private System.Windows.Forms.Label lbl_VentasT;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}