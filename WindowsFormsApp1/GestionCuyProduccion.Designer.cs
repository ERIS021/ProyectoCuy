namespace WindowsFormsApp1
{
    partial class GestionCuyProduccion
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
            this.listCuy = new System.Windows.Forms.ListBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.btt_elimCuy = new System.Windows.Forms.Button();
            this.btt_editCuy = new System.Windows.Forms.Button();
            this.btt_aggCuy = new System.Windows.Forms.Button();
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
            // listCuy
            // 
            this.listCuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCuy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCuy.FormattingEnabled = true;
            this.listCuy.Location = new System.Drawing.Point(91, 190);
            this.listCuy.Name = "listCuy";
            this.listCuy.Size = new System.Drawing.Size(420, 195);
            this.listCuy.TabIndex = 43;
            this.listCuy.SelectedIndexChanged += new System.EventHandler(this.listCuy_SelectedIndexChanged);
            // 
            // textStock
            // 
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStock.Location = new System.Drawing.Point(598, 370);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(231, 13);
            this.textStock.TabIndex = 42;
            this.textStock.Enter += new System.EventHandler(this.textStock_Enter);
            this.textStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            this.textStock.Leave += new System.EventHandler(this.textStock_Leave);
            // 
            // textPrecio
            // 
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(598, 315);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(229, 13);
            this.textPrecio.TabIndex = 41;
            this.textPrecio.Enter += new System.EventHandler(this.textPrecio_Enter);
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            this.textPrecio.Leave += new System.EventHandler(this.textPrecio_Leave);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(598, 259);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(229, 21);
            this.cmbColor.TabIndex = 40;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbRaza
            // 
            this.cmbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(598, 203);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(223, 21);
            this.cmbRaza.TabIndex = 39;
            this.cmbRaza.SelectedIndexChanged += new System.EventHandler(this.cmbRaza_SelectedIndexChanged);
            this.cmbRaza.Enter += new System.EventHandler(this.cmbRaza_Enter);
            // 
            // btt_elimCuy
            // 
            this.btt_elimCuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_elimCuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_elimCuy.FlatAppearance.BorderSize = 0;
            this.btt_elimCuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_elimCuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_elimCuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_elimCuy.Font = new System.Drawing.Font("Milk Days", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_elimCuy.ForeColor = System.Drawing.Color.White;
            this.btt_elimCuy.Location = new System.Drawing.Point(671, 461);
            this.btt_elimCuy.Name = "btt_elimCuy";
            this.btt_elimCuy.Size = new System.Drawing.Size(158, 60);
            this.btt_elimCuy.TabIndex = 38;
            this.btt_elimCuy.Text = "eliminar";
            this.btt_elimCuy.UseVisualStyleBackColor = false;
            this.btt_elimCuy.Click += new System.EventHandler(this.btt_elimCuy_Click);
            // 
            // btt_editCuy
            // 
            this.btt_editCuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_editCuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_editCuy.FlatAppearance.BorderSize = 0;
            this.btt_editCuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_editCuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_editCuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_editCuy.Font = new System.Drawing.Font("Milk Days", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_editCuy.ForeColor = System.Drawing.Color.White;
            this.btt_editCuy.Location = new System.Drawing.Point(421, 461);
            this.btt_editCuy.Name = "btt_editCuy";
            this.btt_editCuy.Size = new System.Drawing.Size(137, 60);
            this.btt_editCuy.TabIndex = 37;
            this.btt_editCuy.Text = "editar";
            this.btt_editCuy.UseVisualStyleBackColor = false;
            this.btt_editCuy.Click += new System.EventHandler(this.btt_editCuy_Click);
            // 
            // btt_aggCuy
            // 
            this.btt_aggCuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_aggCuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_aggCuy.FlatAppearance.BorderSize = 0;
            this.btt_aggCuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_aggCuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.btt_aggCuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_aggCuy.Font = new System.Drawing.Font("Milk Days", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_aggCuy.ForeColor = System.Drawing.Color.White;
            this.btt_aggCuy.Location = new System.Drawing.Point(124, 461);
            this.btt_aggCuy.Name = "btt_aggCuy";
            this.btt_aggCuy.Size = new System.Drawing.Size(156, 60);
            this.btt_aggCuy.TabIndex = 36;
            this.btt_aggCuy.Text = "agregar";
            this.btt_aggCuy.UseVisualStyleBackColor = false;
            this.btt_aggCuy.Click += new System.EventHandler(this.btt_aggCuy_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 530);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(886, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(910, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Produccion__Crianza__3_;
            this.pictureBox4.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(954, 605);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // GestionCuyProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.listCuy);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.btt_elimCuy);
            this.Controls.Add(this.btt_editCuy);
            this.Controls.Add(this.btt_aggCuy);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCuyProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCuyProduccion";
            this.Load += new System.EventHandler(this.GestionCuyProduccion_Load);
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
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listCuy;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Button btt_elimCuy;
        private System.Windows.Forms.Button btt_editCuy;
        private System.Windows.Forms.Button btt_aggCuy;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}