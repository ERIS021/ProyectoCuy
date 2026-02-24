namespace WindowsFormsApp1
{
    partial class GestionClientesProduccion
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
            this.listClientes = new System.Windows.Forms.ListBox();
            this.btt_elimCliente = new System.Windows.Forms.Button();
            this.btt_editCliente = new System.Windows.Forms.Button();
            this.btt_Regis = new System.Windows.Forms.Button();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textNombres = new System.Windows.Forms.TextBox();
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
            // listClientes
            // 
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 15;
            this.listClientes.Location = new System.Drawing.Point(513, 170);
            this.listClientes.Name = "listClientes";
            this.listClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listClientes.Size = new System.Drawing.Size(343, 240);
            this.listClientes.TabIndex = 34;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // btt_elimCliente
            // 
            this.btt_elimCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_elimCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_elimCliente.FlatAppearance.BorderSize = 0;
            this.btt_elimCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_elimCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_elimCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_elimCliente.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_elimCliente.ForeColor = System.Drawing.Color.White;
            this.btt_elimCliente.Location = new System.Drawing.Point(730, 452);
            this.btt_elimCliente.Name = "btt_elimCliente";
            this.btt_elimCliente.Size = new System.Drawing.Size(107, 40);
            this.btt_elimCliente.TabIndex = 33;
            this.btt_elimCliente.Text = "Eliminar";
            this.btt_elimCliente.UseVisualStyleBackColor = false;
            this.btt_elimCliente.Click += new System.EventHandler(this.btt_elimCliente_Click);
            // 
            // btt_editCliente
            // 
            this.btt_editCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_editCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_editCliente.FlatAppearance.BorderSize = 0;
            this.btt_editCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_editCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_editCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_editCliente.Font = new System.Drawing.Font("Milk Days", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_editCliente.ForeColor = System.Drawing.Color.White;
            this.btt_editCliente.Location = new System.Drawing.Point(545, 445);
            this.btt_editCliente.Name = "btt_editCliente";
            this.btt_editCliente.Size = new System.Drawing.Size(91, 52);
            this.btt_editCliente.TabIndex = 32;
            this.btt_editCliente.Text = "Editar";
            this.btt_editCliente.UseVisualStyleBackColor = false;
            this.btt_editCliente.Click += new System.EventHandler(this.btt_editCliente_Click);
            // 
            // btt_Regis
            // 
            this.btt_Regis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_Regis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_Regis.FlatAppearance.BorderSize = 0;
            this.btt_Regis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_Regis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btt_Regis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Regis.Font = new System.Drawing.Font("Milk Days", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Regis.ForeColor = System.Drawing.Color.White;
            this.btt_Regis.Location = new System.Drawing.Point(154, 439);
            this.btt_Regis.Name = "btt_Regis";
            this.btt_Regis.Size = new System.Drawing.Size(131, 53);
            this.btt_Regis.TabIndex = 31;
            this.btt_Regis.Text = "REGISTRAR";
            this.btt_Regis.UseVisualStyleBackColor = false;
            this.btt_Regis.Click += new System.EventHandler(this.btt_Regis_Click);
            // 
            // textDireccion
            // 
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDireccion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(99, 378);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(253, 16);
            this.textDireccion.TabIndex = 30;
            this.textDireccion.Enter += new System.EventHandler(this.textDireccion_Enter);
            this.textDireccion.Leave += new System.EventHandler(this.textDireccion_Leave);
            // 
            // textCorreo
            // 
            this.textCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCorreo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.Location = new System.Drawing.Point(99, 319);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(253, 16);
            this.textCorreo.TabIndex = 29;
            this.textCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.textCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // textTelefono
            // 
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefono.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(99, 266);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(253, 16);
            this.textTelefono.TabIndex = 28;
            this.textTelefono.Enter += new System.EventHandler(this.textTelefono_Enter);
            this.textTelefono.Leave += new System.EventHandler(this.textTelefono_Leave);
            // 
            // textCedula
            // 
            this.textCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCedula.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCedula.Location = new System.Drawing.Point(99, 212);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(253, 16);
            this.textCedula.TabIndex = 27;
            this.textCedula.Enter += new System.EventHandler(this.textCedula_Enter);
            this.textCedula.Leave += new System.EventHandler(this.textCedula_Leave);
            // 
            // textNombres
            // 
            this.textNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombres.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombres.Location = new System.Drawing.Point(99, 170);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(253, 16);
            this.textNombres.TabIndex = 26;
            this.textNombres.TabStop = false;
            this.textNombres.Enter += new System.EventHandler(this.textNombres_Enter);
            this.textNombres.Leave += new System.EventHandler(this.textNombres_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 535);
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
            this.pictureBox3.TabIndex = 25;
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
            this.pictureBox2.TabIndex = 24;
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
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Produccion__Crianza__2_1;
            this.pictureBox4.Location = new System.Drawing.Point(-45, -29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(983, 592);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // GestionClientesProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 575);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btt_elimCliente);
            this.Controls.Add(this.btt_editCliente);
            this.Controls.Add(this.btt_Regis);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionClientesProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientesProduccion";
            this.Load += new System.EventHandler(this.GestionClientesProduccion_Load);
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
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button btt_elimCliente;
        private System.Windows.Forms.Button btt_editCliente;
        private System.Windows.Forms.Button btt_Regis;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}