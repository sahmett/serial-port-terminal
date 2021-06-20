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
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.cbBauderate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbGidenVeri = new System.Windows.Forms.ListBox();
            this.lbGelenVeri = new System.Windows.Forms.ListBox();
            this.tbGidecekVeri = new System.Windows.Forms.TextBox();
            this.btnVeriGonder = new System.Windows.Forms.Button();
            this.labelGidecekVeri = new System.Windows.Forms.Label();
            this.labelGidenVeri = new System.Windows.Forms.Label();
            this.labelGelenVeri = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaglantiKes.Location = new System.Drawing.Point(266, 82);
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
            this.btnBaglan.Location = new System.Drawing.Point(266, 27);
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
            this.labelPort.Location = new System.Drawing.Point(18, 34);
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
            this.labelBaudrate.Location = new System.Drawing.Point(17, 61);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(49, 12);
            this.labelBaudrate.TabIndex = 19;
            this.labelBaudrate.Text = "BoundR";
            // 
            // cbBauderate
            // 
            this.cbBauderate.FormattingEnabled = true;
            this.cbBauderate.Location = new System.Drawing.Point(112, 57);
            this.cbBauderate.Name = "cbBauderate";
            this.cbBauderate.Size = new System.Drawing.Size(133, 21);
            this.cbBauderate.TabIndex = 17;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(113, 30);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(132, 21);
            this.cbPort.TabIndex = 16;
            // 
            // lbGidenVeri
            // 
            this.lbGidenVeri.FormattingEnabled = true;
            this.lbGidenVeri.Location = new System.Drawing.Point(113, 185);
            this.lbGidenVeri.Name = "lbGidenVeri";
            this.lbGidenVeri.Size = new System.Drawing.Size(132, 56);
            this.lbGidenVeri.TabIndex = 22;
            // 
            // lbGelenVeri
            // 
            this.lbGelenVeri.FormattingEnabled = true;
            this.lbGelenVeri.Location = new System.Drawing.Point(112, 250);
            this.lbGelenVeri.Name = "lbGelenVeri";
            this.lbGelenVeri.Size = new System.Drawing.Size(241, 186);
            this.lbGelenVeri.TabIndex = 23;
            // 
            // tbGidecekVeri
            // 
            this.tbGidecekVeri.Location = new System.Drawing.Point(112, 147);
            this.tbGidecekVeri.Name = "tbGidecekVeri";
            this.tbGidecekVeri.Size = new System.Drawing.Size(133, 20);
            this.tbGidecekVeri.TabIndex = 24;
            // 
            // btnVeriGonder
            // 
            this.btnVeriGonder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVeriGonder.Location = new System.Drawing.Point(266, 147);
            this.btnVeriGonder.Name = "btnVeriGonder";
            this.btnVeriGonder.Size = new System.Drawing.Size(87, 94);
            this.btnVeriGonder.TabIndex = 25;
            this.btnVeriGonder.Text = "Veri Gonder";
            this.btnVeriGonder.UseVisualStyleBackColor = true;
            this.btnVeriGonder.Click += new System.EventHandler(this.btnVeriGonder_Click);
            // 
            // labelGidecekVeri
            // 
            this.labelGidecekVeri.AutoSize = true;
            this.labelGidecekVeri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelGidecekVeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGidecekVeri.Location = new System.Drawing.Point(19, 151);
            this.labelGidecekVeri.Name = "labelGidecekVeri";
            this.labelGidecekVeri.Size = new System.Drawing.Size(77, 12);
            this.labelGidecekVeri.TabIndex = 26;
            this.labelGidecekVeri.Text = "Gidecek Veri";
            // 
            // labelGidenVeri
            // 
            this.labelGidenVeri.AutoSize = true;
            this.labelGidenVeri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelGidenVeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGidenVeri.Location = new System.Drawing.Point(20, 185);
            this.labelGidenVeri.Name = "labelGidenVeri";
            this.labelGidenVeri.Size = new System.Drawing.Size(64, 12);
            this.labelGidenVeri.TabIndex = 27;
            this.labelGidenVeri.Text = "Giden Veri";
            // 
            // labelGelenVeri
            // 
            this.labelGelenVeri.AutoSize = true;
            this.labelGelenVeri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.labelGelenVeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGelenVeri.Location = new System.Drawing.Point(20, 250);
            this.labelGelenVeri.Name = "labelGelenVeri";
            this.labelGelenVeri.Size = new System.Drawing.Size(64, 12);
            this.labelGelenVeri.TabIndex = 28;
            this.labelGelenVeri.Text = "Gelen Veri";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 474);
            this.Controls.Add(this.labelGelenVeri);
            this.Controls.Add(this.labelGidenVeri);
            this.Controls.Add(this.labelGidecekVeri);
            this.Controls.Add(this.btnVeriGonder);
            this.Controls.Add(this.tbGidecekVeri);
            this.Controls.Add(this.lbGelenVeri);
            this.Controls.Add(this.lbGidenVeri);
            this.Controls.Add(this.btnBaglantiKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelBaudrate);
            this.Controls.Add(this.cbBauderate);
            this.Controls.Add(this.cbPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
        private System.Windows.Forms.ListBox lbGidenVeri;
        private System.Windows.Forms.ListBox lbGelenVeri;
        private System.Windows.Forms.TextBox tbGidecekVeri;
        private System.Windows.Forms.Button btnVeriGonder;
        private System.Windows.Forms.Label labelGidecekVeri;
        private System.Windows.Forms.Label labelGidenVeri;
        private System.Windows.Forms.Label labelGelenVeri;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

