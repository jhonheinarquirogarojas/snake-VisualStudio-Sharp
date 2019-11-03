namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNosotros = new System.Windows.Forms.Label();
            this.ptbMusica = new System.Windows.Forms.PictureBox();
            this.lbContinuar = new System.Windows.Forms.Label();
            this.lbPausar = new System.Windows.Forms.Label();
            this.lbReglas = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxBorders = new System.Windows.Forms.CheckBox();
            this.A10 = new System.Windows.Forms.Label();
            this.A9 = new System.Windows.Forms.Label();
            this.A8 = new System.Windows.Forms.Label();
            this.A7 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeLengthLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNosotros
            // 
            this.lblNosotros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNosotros.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblNosotros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNosotros.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNosotros.ForeColor = System.Drawing.Color.White;
            this.lblNosotros.Location = new System.Drawing.Point(384, 822);
            this.lblNosotros.Name = "lblNosotros";
            this.lblNosotros.Size = new System.Drawing.Size(149, 37);
            this.lblNosotros.TabIndex = 68;
            this.lblNosotros.Text = "Acerca de Nosotros";
            this.lblNosotros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNosotros.Click += new System.EventHandler(this.lblNosotros_Click);
            // 
            // ptbMusica
            // 
            this.ptbMusica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbMusica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMusica.Image = ((System.Drawing.Image)(resources.GetObject("ptbMusica.Image")));
            this.ptbMusica.Location = new System.Drawing.Point(48, 606);
            this.ptbMusica.Name = "ptbMusica";
            this.ptbMusica.Size = new System.Drawing.Size(58, 58);
            this.ptbMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMusica.TabIndex = 64;
            this.ptbMusica.TabStop = false;
            this.ptbMusica.Click += new System.EventHandler(this.ptbMusica_Click);
            // 
            // lbContinuar
            // 
            this.lbContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContinuar.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuar.ForeColor = System.Drawing.Color.White;
            this.lbContinuar.Location = new System.Drawing.Point(282, 630);
            this.lbContinuar.Name = "lbContinuar";
            this.lbContinuar.Size = new System.Drawing.Size(118, 34);
            this.lbContinuar.TabIndex = 37;
            this.lbContinuar.Text = "Continuar";
            this.lbContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbContinuar.Click += new System.EventHandler(this.lbContinuar_Click);
            // 
            // lbPausar
            // 
            this.lbPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPausar.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPausar.ForeColor = System.Drawing.Color.White;
            this.lbPausar.Location = new System.Drawing.Point(145, 630);
            this.lbPausar.Name = "lbPausar";
            this.lbPausar.Size = new System.Drawing.Size(118, 34);
            this.lbPausar.TabIndex = 36;
            this.lbPausar.Text = "Pausar";
            this.lbPausar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPausar.Click += new System.EventHandler(this.lbPausar_Click);
            // 
            // lbReglas
            // 
            this.lbReglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbReglas.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReglas.ForeColor = System.Drawing.Color.White;
            this.lbReglas.Location = new System.Drawing.Point(383, 766);
            this.lbReglas.Name = "lbReglas";
            this.lbReglas.Size = new System.Drawing.Size(149, 37);
            this.lbReglas.TabIndex = 35;
            this.lbReglas.Text = "Reglas";
            this.lbReglas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbReglas.Click += new System.EventHandler(this.lbReglas_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(417, 616);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 60;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(490, 616);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Varsity Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(331, 896);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 58);
            this.label5.TabIndex = 58;
            this.label5.Text = "Snake 98";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Reiniciar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(381, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 56;
            this.label3.Text = "Restart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoxBorders
            // 
            this.BoxBorders.AutoSize = true;
            this.BoxBorders.Checked = true;
            this.BoxBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BoxBorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxBorders.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBorders.ForeColor = System.Drawing.Color.Black;
            this.BoxBorders.Location = new System.Drawing.Point(206, 591);
            this.BoxBorders.Name = "BoxBorders";
            this.BoxBorders.Size = new System.Drawing.Size(164, 27);
            this.BoxBorders.TabIndex = 55;
            this.BoxBorders.Text = "SALUDA A SNAKE";
            this.BoxBorders.UseVisualStyleBackColor = true;
            // 
            // A10
            // 
            this.A10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A10.ForeColor = System.Drawing.Color.Red;
            this.A10.Location = new System.Drawing.Point(156, 70);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(26, 23);
            this.A10.TabIndex = 54;
            this.A10.Text = "10";
            this.A10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A10.Click += new System.EventHandler(this.A10_Click);
            // 
            // A9
            // 
            this.A9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9.ForeColor = System.Drawing.Color.Red;
            this.A9.Location = new System.Drawing.Point(129, 70);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(26, 23);
            this.A9.TabIndex = 53;
            this.A9.Text = "9";
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A9.Click += new System.EventHandler(this.A9_Click);
            // 
            // A8
            // 
            this.A8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A8.ForeColor = System.Drawing.Color.Red;
            this.A8.Location = new System.Drawing.Point(102, 70);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(26, 23);
            this.A8.TabIndex = 52;
            this.A8.Text = "8";
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A8.Click += new System.EventHandler(this.A8_Click);
            // 
            // A7
            // 
            this.A7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7.ForeColor = System.Drawing.Color.Red;
            this.A7.Location = new System.Drawing.Point(75, 70);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(26, 23);
            this.A7.TabIndex = 51;
            this.A7.Text = "7";
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            // 
            // A6
            // 
            this.A6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A6.ForeColor = System.Drawing.Color.Red;
            this.A6.Location = new System.Drawing.Point(48, 70);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(26, 23);
            this.A6.TabIndex = 50;
            this.A6.Text = "6";
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A6.Click += new System.EventHandler(this.A6_Click);
            // 
            // A5
            // 
            this.A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.ForeColor = System.Drawing.Color.Red;
            this.A5.Location = new System.Drawing.Point(156, 46);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(26, 23);
            this.A5.TabIndex = 49;
            this.A5.Text = "5";
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A5.Click += new System.EventHandler(this.A5_Click);
            // 
            // A4
            // 
            this.A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.ForeColor = System.Drawing.Color.Red;
            this.A4.Location = new System.Drawing.Point(129, 46);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(26, 23);
            this.A4.TabIndex = 48;
            this.A4.Text = "4";
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // A3
            // 
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Red;
            this.A3.Location = new System.Drawing.Point(102, 46);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(26, 23);
            this.A3.TabIndex = 47;
            this.A3.Text = "3";
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A2
            // 
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Red;
            this.A2.Location = new System.Drawing.Point(75, 46);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(26, 23);
            this.A2.TabIndex = 46;
            this.A2.Text = "2";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A1
            // 
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Lime;
            this.A1.Location = new System.Drawing.Point(48, 46);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(26, 23);
            this.A1.TabIndex = 45;
            this.A1.Text = "1";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "CANTIDAD DE COMIDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "PUNTUACIÓN:";
            // 
            // SnakeLengthLabel
            // 
            this.SnakeLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.SnakeLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeLengthLabel.ForeColor = System.Drawing.Color.Lime;
            this.SnakeLengthLabel.Location = new System.Drawing.Point(471, 5);
            this.SnakeLengthLabel.Name = "SnakeLengthLabel";
            this.SnakeLengthLabel.Size = new System.Drawing.Size(81, 56);
            this.SnakeLengthLabel.TabIndex = 14;
            this.SnakeLengthLabel.Text = "1";
            this.SnakeLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(48, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 485);
            this.panel1.TabIndex = 3;
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.BackColor = System.Drawing.Color.Black;
            this.EndGameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameLabel.ForeColor = System.Drawing.Color.Red;
            this.EndGameLabel.Location = new System.Drawing.Point(151, 224);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(248, 171);
            this.EndGameLabel.TabIndex = 40;
            this.EndGameLabel.Text = "PERDISTE! \r\n\r\nLa serpiente se estrello\r\n\r\nClick Aquí para jugar de nuevo :3\r\n";
            this.EndGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EndGameLabel.Visible = false;
            this.EndGameLabel.Click += new System.EventHandler(this.EndGameLabel_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(56, 837);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 88);
            this.listBox1.TabIndex = 69;
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Enabled = false;
            this.txtRegistrar.Location = new System.Drawing.Point(148, 711);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(177, 20);
            this.txtRegistrar.TabIndex = 70;
            //this.txtRegistrar.TextChanged += new System.EventHandler(this.txtRegistrar_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(170, 754);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 34);
            this.btnRegistrar.TabIndex = 71;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 36);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nombre del\r\n Jugador :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(583, 971);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNosotros);
            this.Controls.Add(this.ptbMusica);
            this.Controls.Add(this.lbContinuar);
            this.Controls.Add(this.lbPausar);
            this.Controls.Add(this.lbReglas);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxBorders);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnakeLengthLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndGameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblNosotros;
        private System.Windows.Forms.PictureBox ptbMusica;
        private System.Windows.Forms.Label lbContinuar;
        private System.Windows.Forms.Label lbPausar;
        private System.Windows.Forms.Label lbReglas;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox BoxBorders;
        private System.Windows.Forms.Label A10;
        private System.Windows.Forms.Label A9;
        private System.Windows.Forms.Label A8;
        private System.Windows.Forms.Label A7;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SnakeLengthLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EndGameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
    }
}

