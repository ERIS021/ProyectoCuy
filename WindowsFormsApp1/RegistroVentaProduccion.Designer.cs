namespace WindowsFormsApp1
{
    partial class RegistroVentaProduccion
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btt_regisV = new System.Windows.Forms.Button();
            this.r_tarjeta = new System.Windows.Forms.RadioButton();
            this.r_transferencia = new System.Windows.Forms.RadioButton();
            this.r_efectivo = new System.Windows.Forms.RadioButton();
            this.metodo_pagos = new System.Windows.Forms.GroupBox();
            this.cmbCuy = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.metodo_pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Milk Days", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(223, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 19);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = ".";
            // 
            // numCantidad
            // 
            this.numCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(173, 354);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(194, 18);
            this.numCantidad.TabIndex = 32;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // btt_regisV
            // 
            this.btt_regisV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_regisV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_regisV.FlatAppearance.BorderSize = 0;
            this.btt_regisV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_regisV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_regisV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_regisV.Font = new System.Drawing.Font("Milk Days", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_regisV.ForeColor = System.Drawing.Color.White;
            this.btt_regisV.Location = new System.Drawing.Point(396, 440);
            this.btt_regisV.Name = "btt_regisV";
            this.btt_regisV.Size = new System.Drawing.Size(180, 65);
            this.btt_regisV.TabIndex = 29;
            this.btt_regisV.Text = "Registrar";
            this.btt_regisV.UseVisualStyleBackColor = false;
            this.btt_regisV.Click += new System.EventHandler(this.btt_regisV_Click);
            // 
            // r_tarjeta
            // 
            this.r_tarjeta.AutoSize = true;
            this.r_tarjeta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_tarjeta.Location = new System.Drawing.Point(29, 120);
            this.r_tarjeta.Name = "r_tarjeta";
            this.r_tarjeta.Size = new System.Drawing.Size(130, 26);
            this.r_tarjeta.TabIndex = 2;
            this.r_tarjeta.TabStop = true;
            this.r_tarjeta.Text = "Tarjeta 💳";
            this.r_tarjeta.UseVisualStyleBackColor = true;
            // 
            // r_transferencia
            // 
            this.r_transferencia.AutoSize = true;
            this.r_transferencia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_transferencia.Location = new System.Drawing.Point(29, 81);
            this.r_transferencia.Name = "r_transferencia";
            this.r_transferencia.Size = new System.Drawing.Size(190, 26);
            this.r_transferencia.TabIndex = 1;
            this.r_transferencia.TabStop = true;
            this.r_transferencia.Text = "Transferencia 📲";
            this.r_transferencia.UseVisualStyleBackColor = true;
            // 
            // r_efectivo
            // 
            this.r_efectivo.AutoSize = true;
            this.r_efectivo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_efectivo.Location = new System.Drawing.Point(29, 38);
            this.r_efectivo.Name = "r_efectivo";
            this.r_efectivo.Size = new System.Drawing.Size(140, 26);
            this.r_efectivo.TabIndex = 0;
            this.r_efectivo.TabStop = true;
            this.r_efectivo.Text = "Efectivo 💵";
            this.r_efectivo.UseVisualStyleBackColor = true;
            // 
            // metodo_pagos
            // 
            this.metodo_pagos.BackColor = System.Drawing.Color.White;
            this.metodo_pagos.Controls.Add(this.r_tarjeta);
            this.metodo_pagos.Controls.Add(this.r_transferencia);
            this.metodo_pagos.Controls.Add(this.r_efectivo);
            this.metodo_pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metodo_pagos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodo_pagos.ForeColor = System.Drawing.Color.Black;
            this.metodo_pagos.Location = new System.Drawing.Point(543, 211);
            this.metodo_pagos.Name = "metodo_pagos";
            this.metodo_pagos.Size = new System.Drawing.Size(250, 180);
            this.metodo_pagos.TabIndex = 34;
            this.metodo_pagos.TabStop = false;
            this.metodo_pagos.Text = "METODOS DE PAGOS";
            // 
            // cmbCuy
            // 
            this.cmbCuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuy.FormattingEnabled = true;
            this.cmbCuy.Location = new System.Drawing.Point(153, 221);
            this.cmbCuy.Name = "cmbCuy";
            this.cmbCuy.Size = new System.Drawing.Size(214, 24);
            this.cmbCuy.TabIndex = 31;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(153, 283);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(214, 26);
            this.cmbCliente.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 532);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(886, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(910, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Produccion__Crianza__1_1;
            this.pictureBox4.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(954, 600);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // RegistroVentaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btt_regisV);
            this.Controls.Add(this.metodo_pagos);
            this.Controls.Add(this.cmbCuy);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroVentaProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroVentaProduccion";
            this.Load += new System.EventHandler(this.RegistroVentaProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.metodo_pagos.ResumeLayout(false);
            this.metodo_pagos.PerformLayout();
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btt_regisV;
        private System.Windows.Forms.RadioButton r_tarjeta;
        private System.Windows.Forms.RadioButton r_transferencia;
        private System.Windows.Forms.RadioButton r_efectivo;
        private System.Windows.Forms.GroupBox metodo_pagos;
        private System.Windows.Forms.ComboBox cmbCuy;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}