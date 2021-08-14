namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.cbBauderate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbGelenVeri = new System.Windows.Forms.ListBox();
            this.labelGelenVeri = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txbRoketHiz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnArti = new System.Windows.Forms.Button();
            this.bt_bul = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txbFayHiz = new System.Windows.Forms.TextBox();
            this.lbYukseklik = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaglantiKes.Location = new System.Drawing.Point(290, 94);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(87, 23);
            this.btnBaglantiKes.TabIndex = 15;
            this.btnBaglantiKes.Text = "Baglantı Kes";
            this.btnBaglantiKes.UseVisualStyleBackColor = true;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaglan.Location = new System.Drawing.Point(290, 37);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(87, 51);
            this.btnBaglan.TabIndex = 14;
            this.btnBaglan.Text = "Baglan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPort.Location = new System.Drawing.Point(42, 46);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(28, 12);
            this.labelPort.TabIndex = 18;
            this.labelPort.Text = "Port";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelBaudrate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBaudrate.Location = new System.Drawing.Point(40, 80);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(49, 12);
            this.labelBaudrate.TabIndex = 19;
            this.labelBaudrate.Text = "BoundR";
            // 
            // cbBauderate
            // 
            this.cbBauderate.FormattingEnabled = true;
            this.cbBauderate.Location = new System.Drawing.Point(135, 76);
            this.cbBauderate.Name = "cbBauderate";
            this.cbBauderate.Size = new System.Drawing.Size(133, 21);
            this.cbBauderate.TabIndex = 17;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(136, 46);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(132, 21);
            this.cbPort.TabIndex = 16;
            // 
            // lbGelenVeri
            // 
            this.lbGelenVeri.FormattingEnabled = true;
            this.lbGelenVeri.Location = new System.Drawing.Point(136, 123);
            this.lbGelenVeri.Name = "lbGelenVeri";
            this.lbGelenVeri.Size = new System.Drawing.Size(241, 95);
            this.lbGelenVeri.TabIndex = 23;
            // 
            // labelGelenVeri
            // 
            this.labelGelenVeri.AutoSize = true;
            this.labelGelenVeri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelGelenVeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGelenVeri.Location = new System.Drawing.Point(40, 123);
            this.labelGelenVeri.Name = "labelGelenVeri";
            this.labelGelenVeri.Size = new System.Drawing.Size(64, 12);
            this.labelGelenVeri.TabIndex = 28;
            this.labelGelenVeri.Text = "Gelen Veri";
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.IsSoftShadows = false;
            this.chart1.Location = new System.Drawing.Point(426, 46);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Name = "Sicaklik";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(312, 209);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // txbRoketHiz
            // 
            this.txbRoketHiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txbRoketHiz.Location = new System.Drawing.Point(657, 37);
            this.txbRoketHiz.Name = "txbRoketHiz";
            this.txbRoketHiz.Size = new System.Drawing.Size(64, 20);
            this.txbRoketHiz.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(587, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Roket Hiz";
            // 
            // btnEksi
            // 
            this.btnEksi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEksi.Location = new System.Drawing.Point(1062, 41);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(33, 21);
            this.btnEksi.TabIndex = 35;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnArti
            // 
            this.btnArti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnArti.Location = new System.Drawing.Point(1023, 41);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(33, 21);
            this.btnArti.TabIndex = 33;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // bt_bul
            // 
            this.bt_bul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_bul.Location = new System.Drawing.Point(833, 37);
            this.bt_bul.Name = "bt_bul";
            this.bt_bul.Size = new System.Drawing.Size(61, 21);
            this.bt_bul.TabIndex = 34;
            this.bt_bul.Text = "Bul";
            this.bt_bul.UseVisualStyleBackColor = true;
            this.bt_bul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(135, 470);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 20);
            this.textBox9.TabIndex = 45;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(136, 359);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 20);
            this.textBox6.TabIndex = 52;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 51;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(135, 442);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(62, 20);
            this.textBox8.TabIndex = 50;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 49;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(206, 470);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(62, 20);
            this.textBox15.TabIndex = 54;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 48;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(135, 413);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(62, 20);
            this.textBox7.TabIndex = 47;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(134, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 12);
            this.label7.TabIndex = 56;
            this.label7.Text = "Faydalı Yuk";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(207, 442);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(61, 20);
            this.textBox14.TabIndex = 55;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(206, 413);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(62, 20);
            this.textBox13.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(41, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "Voltaj";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(41, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "Faydalı Yük";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(41, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 12);
            this.label10.TabIndex = 41;
            this.label10.Text = "Mod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(41, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 40;
            this.label8.Text = "Paket Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(41, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "Paket No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(40, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "GPS Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(40, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "GPS Altuitude";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(40, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "GPS Longitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(215, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "Roket";
            // 
            // chart2
            // 
            this.chart2.AllowDrop = true;
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.IsSoftShadows = false;
            this.chart2.Location = new System.Drawing.Point(426, 292);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Name = "Sicaklik";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(312, 212);
            this.chart2.TabIndex = 57;
            this.chart2.Text = "chart2";
            // 
            // txbFayHiz
            // 
            this.txbFayHiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbFayHiz.Location = new System.Drawing.Point(657, 267);
            this.txbFayHiz.Name = "txbFayHiz";
            this.txbFayHiz.Size = new System.Drawing.Size(64, 20);
            this.txbFayHiz.TabIndex = 59;
            // 
            // lbYukseklik
            // 
            this.lbYukseklik.AutoSize = true;
            this.lbYukseklik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbYukseklik.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lbYukseklik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbYukseklik.Location = new System.Drawing.Point(554, 270);
            this.lbYukseklik.Name = "lbYukseklik";
            this.lbYukseklik.Size = new System.Drawing.Size(97, 16);
            this.lbYukseklik.TabIndex = 58;
            this.lbYukseklik.Text = "Faydali Yuk Hiz";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(846, 68);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(258, 270);
            this.gMapControl1.TabIndex = 32;
            this.gMapControl1.Zoom = 0D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(846, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnArti;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.txbFayHiz);
            this.Controls.Add(this.lbYukseklik);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.bt_bul);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.txbRoketHiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelGelenVeri);
            this.Controls.Add(this.lbGelenVeri);
            this.Controls.Add(this.btnBaglantiKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelBaudrate);
            this.Controls.Add(this.cbBauderate);
            this.Controls.Add(this.cbPort);
            this.Name = "Form1";
            this.Text = "Karluk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglantiKes;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox cbBauderate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ListBox lbGelenVeri;
        private System.Windows.Forms.Label labelGelenVeri;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txbRoketHiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button bt_bul;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox txbFayHiz;
        private System.Windows.Forms.Label lbYukseklik;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

