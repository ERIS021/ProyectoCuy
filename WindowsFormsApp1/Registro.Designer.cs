namespace WindowsFormsApp1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.button1 = new System.Windows.Forms.Button();
            this.contra = new System.Windows.Forms.TextBox();
            this.contracfm = new System.Windows.Forms.TextBox();
            this.userr = new System.Windows.Forms.TextBox();
            this.ojoCerrado = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ojoCerrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Milk Days", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.button1.Location = new System.Drawing.Point(564, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.Color.White;
            this.contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contra.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.contra.Location = new System.Drawing.Point(445, 329);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(426, 26);
            this.contra.TabIndex = 5;
            this.contra.Text = "INGRESAR CONTRASEÑA:";
            this.contra.Enter += new System.EventHandler(this.contra_Enter);
            this.contra.Leave += new System.EventHandler(this.contra_Leave);
            // 
            // contracfm
            // 
            this.contracfm.BackColor = System.Drawing.Color.White;
            this.contracfm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contracfm.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contracfm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.contracfm.Location = new System.Drawing.Point(445, 405);
            this.contracfm.Name = "contracfm";
            this.contracfm.Size = new System.Drawing.Size(426, 26);
            this.contracfm.TabIndex = 6;
            this.contracfm.Text = "CONFIRMAR CONTRASEÑA:";
            this.contracfm.TextChanged += new System.EventHandler(this.contracfm_TextChanged);
            this.contracfm.Enter += new System.EventHandler(this.contracfm_Enter);
            this.contracfm.Leave += new System.EventHandler(this.contracfm_Leave);
            // 
            // userr
            // 
            this.userr.BackColor = System.Drawing.Color.White;
            this.userr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userr.Font = new System.Drawing.Font("Milk Days", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.userr.Location = new System.Drawing.Point(445, 251);
            this.userr.Name = "userr";
            this.userr.Size = new System.Drawing.Size(382, 26);
            this.userr.TabIndex = 7;
            this.userr.Text = "INGRESAR USUARIO:";
            this.userr.TextChanged += new System.EventHandler(this.userr_TextChanged);
            this.userr.Enter += new System.EventHandler(this.userr_Enter);
            this.userr.Leave += new System.EventHandler(this.userr_Leave);
            // 
            // ojoCerrado
            // 
            this.ojoCerrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.ojoCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ojoCerrado.Image = global::WindowsFormsApp1.Properties.Resources.ojocerrado;
            this.ojoCerrado.Location = new System.Drawing.Point(885, 319);
            this.ojoCerrado.Name = "ojoCerrado";
            this.ojoCerrado.Size = new System.Drawing.Size(48, 42);
            this.ojoCerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ojoCerrado.TabIndex = 15;
            this.ojoCerrado.TabStop = false;
            this.ojoCerrado.Click += new System.EventHandler(this.ojoCerrado_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(881, 319);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.arrow2;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 530);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(885, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(909, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.registro2;
            this.pictureBox3.Location = new System.Drawing.Point(31, -31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(882, 605);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.ojoCerrado);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.contracfm);
            this.Controls.Add(this.userr);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ojoCerrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.TextBox contracfm;
        private System.Windows.Forms.TextBox userr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox ojoCerrado;
    }
}