namespace WindowsFormsApp1
{
    partial class ReceHorno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceHorno));
            this.btt2 = new System.Windows.Forms.Button();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.panelRecetas = new System.Windows.Forms.Panel();
            this.txtReceta1 = new System.Windows.Forms.TextBox();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.btt3 = new System.Windows.Forms.Button();
            this.timerop = new System.Windows.Forms.Timer(this.components);
            this.panelGustativo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGustativo = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picBoxReceta = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxReceta2 = new System.Windows.Forms.PictureBox();
            this.picBoxReceta3 = new System.Windows.Forms.PictureBox();
            this.lblNomApartado = new System.Windows.Forms.Label();
            this.bttEnviarOpinion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmojis = new System.Windows.Forms.Panel();
            this.emojibtt5 = new System.Windows.Forms.Button();
            this.emojibtt2 = new System.Windows.Forms.Button();
            this.emojibtt4 = new System.Windows.Forms.Button();
            this.emojibtt1 = new System.Windows.Forms.Button();
            this.emojibtt3 = new System.Windows.Forms.Button();
            this.bttDejarOpinion = new System.Windows.Forms.Button();
            this.panelOpiniones = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.btt1 = new System.Windows.Forms.Button();
            this.panelRecetas.SuspendLayout();
            this.panelGustativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta3)).BeginInit();
            this.panelEmojis.SuspendLayout();
            this.panelOpiniones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt2
            // 
            this.btt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.btt2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.btt2.FlatAppearance.BorderSize = 2;
            this.btt2.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt2.Location = new System.Drawing.Point(309, 104);
            this.btt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(186, 78);
            this.btt2.TabIndex = 35;
            this.btt2.Text = "Cuy asado a la parrilla\r\n";
            this.btt2.UseVisualStyleBackColor = false;
            this.btt2.Click += new System.EventHandler(this.btt2_Click);
            // 
            // txtOpinion
            // 
            this.txtOpinion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpinion.Location = new System.Drawing.Point(788, 402);
            this.txtOpinion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.Size = new System.Drawing.Size(253, 134);
            this.txtOpinion.TabIndex = 42;
            this.txtOpinion.Visible = false;
            // 
            // panelRecetas
            // 
            this.panelRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelRecetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecetas.Controls.Add(this.txtReceta1);
            this.panelRecetas.Controls.Add(this.lblNombreReceta);
            this.panelRecetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRecetas.Location = new System.Drawing.Point(66, 203);
            this.panelRecetas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelRecetas.Name = "panelRecetas";
            this.panelRecetas.Size = new System.Drawing.Size(675, 425);
            this.panelRecetas.TabIndex = 37;
            this.panelRecetas.Visible = false;
            this.panelRecetas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecetas_Paint);
            // 
            // txtReceta1
            // 
            this.txtReceta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.txtReceta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceta1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceta1.Location = new System.Drawing.Point(18, 53);
            this.txtReceta1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReceta1.Multiline = true;
            this.txtReceta1.Name = "txtReceta1";
            this.txtReceta1.ReadOnly = true;
            this.txtReceta1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceta1.Size = new System.Drawing.Size(639, 359);
            this.txtReceta1.TabIndex = 46;
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReceta.Location = new System.Drawing.Point(14, 22);
            this.lblNombreReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(82, 32);
            this.lblNombreReceta.TabIndex = 46;
            this.lblNombreReceta.Text = "Receta...\r\n\r\n";
            // 
            // btt3
            // 
            this.btt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.btt3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.btt3.FlatAppearance.BorderSize = 2;
            this.btt3.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt3.Location = new System.Drawing.Point(554, 104);
            this.btt3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(186, 78);
            this.btt3.TabIndex = 36;
            this.btt3.Text = "Cuy con hierbas andinas";
            this.btt3.UseVisualStyleBackColor = false;
            this.btt3.Click += new System.EventHandler(this.btt3_Click);
            // 
            // timerop
            // 
            this.timerop.Tick += new System.EventHandler(this.timerop_Tick);
            // 
            // panelGustativo
            // 
            this.panelGustativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelGustativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGustativo.Controls.Add(this.label1);
            this.panelGustativo.Controls.Add(this.lblGustativo);
            this.panelGustativo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelGustativo.Location = new System.Drawing.Point(788, 402);
            this.panelGustativo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelGustativo.Name = "panelGustativo";
            this.panelGustativo.Size = new System.Drawing.Size(254, 218);
            this.panelGustativo.TabIndex = 47;
            this.panelGustativo.Visible = false;
            this.panelGustativo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Milk Days", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Evaluación del sabor";
            // 
            // lblGustativo
            // 
            this.lblGustativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(195)))));
            this.lblGustativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGustativo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGustativo.Location = new System.Drawing.Point(6, 33);
            this.lblGustativo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGustativo.Multiline = true;
            this.lblGustativo.Name = "lblGustativo";
            this.lblGustativo.ReadOnly = true;
            this.lblGustativo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblGustativo.Size = new System.Drawing.Size(243, 179);
            this.lblGustativo.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picBoxReceta
            // 
            this.picBoxReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.picBoxReceta.Image = global::WindowsFormsApp1.Properties.Resources.horno;
            this.picBoxReceta.Location = new System.Drawing.Point(8, 7);
            this.picBoxReceta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxReceta.Name = "picBoxReceta";
            this.picBoxReceta.Size = new System.Drawing.Size(294, 188);
            this.picBoxReceta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReceta.TabIndex = 48;
            this.picBoxReceta.TabStop = false;
            this.picBoxReceta.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(120)))), ((int)(((byte)(89)))));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.arrow;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 615);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(120)))), ((int)(((byte)(89)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(46)))), ((int)(((byte)(23)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize1;
            this.pictureBox2.Location = new System.Drawing.Point(1035, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(46)))), ((int)(((byte)(23)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(1063, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxReceta2
            // 
            this.picBoxReceta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.picBoxReceta2.Image = global::WindowsFormsApp1.Properties.Resources.asado;
            this.picBoxReceta2.Location = new System.Drawing.Point(6, 7);
            this.picBoxReceta2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxReceta2.Name = "picBoxReceta2";
            this.picBoxReceta2.Size = new System.Drawing.Size(294, 188);
            this.picBoxReceta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReceta2.TabIndex = 51;
            this.picBoxReceta2.TabStop = false;
            this.picBoxReceta2.Visible = false;
            // 
            // picBoxReceta3
            // 
            this.picBoxReceta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.picBoxReceta3.Image = global::WindowsFormsApp1.Properties.Resources.hierbasCuy;
            this.picBoxReceta3.Location = new System.Drawing.Point(6, 7);
            this.picBoxReceta3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoxReceta3.Name = "picBoxReceta3";
            this.picBoxReceta3.Size = new System.Drawing.Size(294, 188);
            this.picBoxReceta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReceta3.TabIndex = 52;
            this.picBoxReceta3.TabStop = false;
            this.picBoxReceta3.Visible = false;
            // 
            // lblNomApartado
            // 
            this.lblNomApartado.AutoSize = true;
            this.lblNomApartado.Font = new System.Drawing.Font("Milk Days", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomApartado.Location = new System.Drawing.Point(168, 55);
            this.lblNomApartado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomApartado.Name = "lblNomApartado";
            this.lblNomApartado.Size = new System.Drawing.Size(459, 33);
            this.lblNomApartado.TabIndex = 53;
            this.lblNomApartado.Text = "RECETAS HORNO - ASADAS";
            // 
            // bttEnviarOpinion
            // 
            this.bttEnviarOpinion.BackColor = System.Drawing.Color.LimeGreen;
            this.bttEnviarOpinion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(90)))), ((int)(((byte)(59)))));
            this.bttEnviarOpinion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEnviarOpinion.Font = new System.Drawing.Font("Cherish Moment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEnviarOpinion.Location = new System.Drawing.Point(80, 100);
            this.bttEnviarOpinion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttEnviarOpinion.Name = "bttEnviarOpinion";
            this.bttEnviarOpinion.Size = new System.Drawing.Size(133, 42);
            this.bttEnviarOpinion.TabIndex = 43;
            this.bttEnviarOpinion.Text = "Enviar opinion\r\n";
            this.bttEnviarOpinion.UseVisualStyleBackColor = false;
            this.bttEnviarOpinion.Visible = false;
            this.bttEnviarOpinion.Click += new System.EventHandler(this.bttEnviarOpinion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Milk Days", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Que te parecio la receta?\r\n";
            // 
            // panelEmojis
            // 
            this.panelEmojis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelEmojis.Controls.Add(this.emojibtt5);
            this.panelEmojis.Controls.Add(this.emojibtt2);
            this.panelEmojis.Controls.Add(this.emojibtt4);
            this.panelEmojis.Controls.Add(this.emojibtt1);
            this.panelEmojis.Controls.Add(this.emojibtt3);
            this.panelEmojis.Location = new System.Drawing.Point(4, 36);
            this.panelEmojis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelEmojis.Name = "panelEmojis";
            this.panelEmojis.Size = new System.Drawing.Size(298, 58);
            this.panelEmojis.TabIndex = 38;
            // 
            // emojibtt5
            // 
            this.emojibtt5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.excelente;
            this.emojibtt5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emojibtt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojibtt5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojibtt5.Location = new System.Drawing.Point(234, 3);
            this.emojibtt5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emojibtt5.Name = "emojibtt5";
            this.emojibtt5.Size = new System.Drawing.Size(52, 54);
            this.emojibtt5.TabIndex = 58;
            this.emojibtt5.UseVisualStyleBackColor = true;
            this.emojibtt5.Click += new System.EventHandler(this.emojiChanged);
            // 
            // emojibtt2
            // 
            this.emojibtt2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emojibtt2.BackgroundImage")));
            this.emojibtt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emojibtt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojibtt2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojibtt2.Location = new System.Drawing.Point(62, 3);
            this.emojibtt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emojibtt2.Name = "emojibtt2";
            this.emojibtt2.Size = new System.Drawing.Size(52, 54);
            this.emojibtt2.TabIndex = 59;
            this.emojibtt2.UseVisualStyleBackColor = true;
            this.emojibtt2.Click += new System.EventHandler(this.emojiChanged);
            // 
            // emojibtt4
            // 
            this.emojibtt4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rico;
            this.emojibtt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emojibtt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojibtt4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojibtt4.Location = new System.Drawing.Point(178, 3);
            this.emojibtt4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emojibtt4.Name = "emojibtt4";
            this.emojibtt4.Size = new System.Drawing.Size(52, 54);
            this.emojibtt4.TabIndex = 57;
            this.emojibtt4.UseVisualStyleBackColor = true;
            this.emojibtt4.Click += new System.EventHandler(this.emojiChanged);
            // 
            // emojibtt1
            // 
            this.emojibtt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emojibtt1.BackgroundImage")));
            this.emojibtt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emojibtt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojibtt1.FlatAppearance.BorderSize = 0;
            this.emojibtt1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojibtt1.Location = new System.Drawing.Point(4, 3);
            this.emojibtt1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emojibtt1.Name = "emojibtt1";
            this.emojibtt1.Size = new System.Drawing.Size(52, 54);
            this.emojibtt1.TabIndex = 55;
            this.emojibtt1.UseVisualStyleBackColor = true;
            this.emojibtt1.Click += new System.EventHandler(this.emojiChanged);
            // 
            // emojibtt3
            // 
            this.emojibtt3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.neutro;
            this.emojibtt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emojibtt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emojibtt3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojibtt3.Location = new System.Drawing.Point(122, 3);
            this.emojibtt3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emojibtt3.Name = "emojibtt3";
            this.emojibtt3.Size = new System.Drawing.Size(52, 54);
            this.emojibtt3.TabIndex = 56;
            this.emojibtt3.UseVisualStyleBackColor = true;
            this.emojibtt3.Click += new System.EventHandler(this.emojiChanged);
            // 
            // bttDejarOpinion
            // 
            this.bttDejarOpinion.BackColor = System.Drawing.Color.Chocolate;
            this.bttDejarOpinion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(90)))), ((int)(((byte)(59)))));
            this.bttDejarOpinion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDejarOpinion.Font = new System.Drawing.Font("Milk Days", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDejarOpinion.Location = new System.Drawing.Point(80, 100);
            this.bttDejarOpinion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttDejarOpinion.Name = "bttDejarOpinion";
            this.bttDejarOpinion.Size = new System.Drawing.Size(133, 42);
            this.bttDejarOpinion.TabIndex = 41;
            this.bttDejarOpinion.Text = "Dejar opinion\r\n";
            this.bttDejarOpinion.UseVisualStyleBackColor = false;
            this.bttDejarOpinion.Click += new System.EventHandler(this.bttDejarOpinion_Click);
            // 
            // panelOpiniones
            // 
            this.panelOpiniones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelOpiniones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpiniones.Controls.Add(this.bttDejarOpinion);
            this.panelOpiniones.Controls.Add(this.panelEmojis);
            this.panelOpiniones.Controls.Add(this.label2);
            this.panelOpiniones.Controls.Add(this.bttEnviarOpinion);
            this.panelOpiniones.Location = new System.Drawing.Point(771, 242);
            this.panelOpiniones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelOpiniones.Name = "panelOpiniones";
            this.panelOpiniones.Size = new System.Drawing.Size(293, 153);
            this.panelOpiniones.TabIndex = 49;
            this.panelOpiniones.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.fondoReceta;
            this.pictureBox4.Location = new System.Drawing.Point(-64, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1161, 683);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panelImagenes
            // 
            this.panelImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(46)))), ((int)(((byte)(23)))));
            this.panelImagenes.Controls.Add(this.picBoxReceta3);
            this.panelImagenes.Controls.Add(this.picBoxReceta);
            this.panelImagenes.Controls.Add(this.picBoxReceta2);
            this.panelImagenes.Location = new System.Drawing.Point(766, 48);
            this.panelImagenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(312, 205);
            this.panelImagenes.TabIndex = 55;
            this.panelImagenes.Visible = false;
            // 
            // btt1
            // 
            this.btt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.btt1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(58)))), ((int)(((byte)(30)))));
            this.btt1.FlatAppearance.BorderSize = 2;
            this.btt1.Font = new System.Drawing.Font("Milk Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt1.Location = new System.Drawing.Point(66, 104);
            this.btt1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(186, 78);
            this.btt1.TabIndex = 34;
            this.btt1.Text = "Cuy al horno tradicional";
            this.btt1.UseVisualStyleBackColor = false;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // ReceHorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1093, 657);
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.lblNomApartado);
            this.Controls.Add(this.panelGustativo);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.txtOpinion);
            this.Controls.Add(this.panelRecetas);
            this.Controls.Add(this.btt3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelOpiniones);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReceHorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceGastronomia";
            this.Load += new System.EventHandler(this.ReceGastronomia_Load);
            this.panelRecetas.ResumeLayout(false);
            this.panelRecetas.PerformLayout();
            this.panelGustativo.ResumeLayout(false);
            this.panelGustativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReceta3)).EndInit();
            this.panelEmojis.ResumeLayout(false);
            this.panelOpiniones.ResumeLayout(false);
            this.panelOpiniones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelImagenes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.TextBox txtOpinion;
        private System.Windows.Forms.Panel panelRecetas;
        private System.Windows.Forms.Timer timerop;
        private System.Windows.Forms.TextBox txtReceta1;
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.Panel panelGustativo;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.PictureBox picBoxReceta;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox lblGustativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxReceta2;
        private System.Windows.Forms.PictureBox picBoxReceta3;
        private System.Windows.Forms.Label lblNomApartado;
        private System.Windows.Forms.Panel panelOpiniones;
        private System.Windows.Forms.Button bttDejarOpinion;
        private System.Windows.Forms.Panel panelEmojis;
        private System.Windows.Forms.Button emojibtt5;
        private System.Windows.Forms.Button emojibtt2;
        private System.Windows.Forms.Button emojibtt4;
        private System.Windows.Forms.Button emojibtt1;
        private System.Windows.Forms.Button emojibtt3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttEnviarOpinion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Panel panelImagenes;
    }
}