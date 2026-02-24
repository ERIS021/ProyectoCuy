namespace WindowsFormsApp1
{
    partial class InteProduccion2
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
            this.components = new System.ComponentModel.Container();
            this.btt_rn = new System.Windows.Forms.Button();
            this.btt_click = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.timerPreview = new System.Windows.Forms.Timer(this.components);
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.pbVida3 = new System.Windows.Forms.PictureBox();
            this.pbVida2 = new System.Windows.Forms.PictureBox();
            this.pbVida1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_rn
            // 
            this.btt_rn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(23)))), ((int)(((byte)(18)))));
            this.btt_rn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_rn.FlatAppearance.BorderSize = 0;
            this.btt_rn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_rn.Font = new System.Drawing.Font("Milk Days", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_rn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt_rn.Location = new System.Drawing.Point(119, 401);
            this.btt_rn.Name = "btt_rn";
            this.btt_rn.Size = new System.Drawing.Size(121, 37);
            this.btt_rn.TabIndex = 42;
            this.btt_rn.Text = "REINICIAR";
            this.btt_rn.UseVisualStyleBackColor = false;
            this.btt_rn.Click += new System.EventHandler(this.btt_rn_Click);
            // 
            // btt_click
            // 
            this.btt_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.btt_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_click.FlatAppearance.BorderSize = 0;
            this.btt_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_click.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt_click.Location = new System.Drawing.Point(82, 331);
            this.btt_click.Name = "btt_click";
            this.btt_click.Size = new System.Drawing.Size(167, 45);
            this.btt_click.TabIndex = 41;
            this.btt_click.Text = "COMENZAR";
            this.btt_click.UseVisualStyleBackColor = false;
            this.btt_click.Click += new System.EventHandler(this.btt_click_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.lblTiempo.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(78, 281);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(117, 22);
            this.lblTiempo.TabIndex = 40;
            this.lblTiempo.Text = "Tiempo:0";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.lblMovimiento.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimiento.ForeColor = System.Drawing.Color.White;
            this.lblMovimiento.Location = new System.Drawing.Point(51, 259);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(66, 16);
            this.lblMovimiento.TabIndex = 38;
            this.lblMovimiento.Text = "label1";
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.White;
            this.panelJuego.Location = new System.Drawing.Point(325, 80);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(539, 413);
            this.panelJuego.TabIndex = 39;
            this.panelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panelJuego_Paint);
            // 
            // timerPreview
            // 
            this.timerPreview.Interval = 2000;
            this.timerPreview.Tick += new System.EventHandler(this.timerPreview_Tick);
            // 
            // timerTiempo
            // 
            this.timerTiempo.Interval = 1000;
            this.timerTiempo.Tick += new System.EventHandler(this.timerTiempo_Tick);
            // 
            // pbVida3
            // 
            this.pbVida3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.pbVida3.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_19_feb_2026__01_45_36;
            this.pbVida3.Location = new System.Drawing.Point(214, 191);
            this.pbVida3.Name = "pbVida3";
            this.pbVida3.Size = new System.Drawing.Size(46, 42);
            this.pbVida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida3.TabIndex = 46;
            this.pbVida3.TabStop = false;
            // 
            // pbVida2
            // 
            this.pbVida2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.pbVida2.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_19_feb_2026__01_45_36;
            this.pbVida2.Location = new System.Drawing.Point(171, 191);
            this.pbVida2.Name = "pbVida2";
            this.pbVida2.Size = new System.Drawing.Size(46, 42);
            this.pbVida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida2.TabIndex = 45;
            this.pbVida2.TabStop = false;
            // 
            // pbVida1
            // 
            this.pbVida1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.pbVida1.Image = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_19_feb_2026__01_45_36;
            this.pbVida1.Location = new System.Drawing.Point(128, 191);
            this.pbVida1.Name = "pbVida1";
            this.pbVida1.Size = new System.Drawing.Size(46, 42);
            this.pbVida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida1.TabIndex = 44;
            this.pbVida1.TabStop = false;
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
            this.pictureBox5.TabIndex = 37;
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
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(886, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(910, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources._40;
            this.pictureBox4.Location = new System.Drawing.Point(-2, -74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(927, 732);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(89, 474);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(0, 16);
            this.lblNivel.TabIndex = 47;
            // 
            // InteProduccion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.pbVida3);
            this.Controls.Add(this.pbVida2);
            this.Controls.Add(this.pbVida1);
            this.Controls.Add(this.btt_rn);
            this.Controls.Add(this.btt_click);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMovimiento);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InteProduccion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteProduccion2";
            this.Load += new System.EventHandler(this.InteProduccion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btt_rn;
        private System.Windows.Forms.Button btt_click;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Timer timerPreview;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbVida1;
        private System.Windows.Forms.PictureBox pbVida2;
        private System.Windows.Forms.PictureBox pbVida3;
        private System.Windows.Forms.Label lblNivel;
    }
}