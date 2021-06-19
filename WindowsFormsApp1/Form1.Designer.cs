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
            this.btn2_bkes = new System.Windows.Forms.Button();
            this.btn1_baglan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb2_bauderate = new System.Windows.Forms.ComboBox();
            this.cb1_port = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn2_bkes
            // 
            this.btn2_bkes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn2_bkes.Location = new System.Drawing.Point(272, 48);
            this.btn2_bkes.Name = "btn2_bkes";
            this.btn2_bkes.Size = new System.Drawing.Size(87, 30);
            this.btn2_bkes.TabIndex = 15;
            this.btn2_bkes.Text = "Baglantı Kes";
            this.btn2_bkes.UseVisualStyleBackColor = true;
            // 
            // btn1_baglan
            // 
            this.btn1_baglan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn1_baglan.Location = new System.Drawing.Point(272, 86);
            this.btn1_baglan.Name = "btn1_baglan";
            this.btn1_baglan.Size = new System.Drawing.Size(87, 29);
            this.btn1_baglan.TabIndex = 14;
            this.btn1_baglan.Text = "Baglan";
            this.btn1_baglan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "BoundR";
            // 
            // cb2_bauderate
            // 
            this.cb2_bauderate.FormattingEnabled = true;
            this.cb2_bauderate.Location = new System.Drawing.Point(118, 91);
            this.cb2_bauderate.Name = "cb2_bauderate";
            this.cb2_bauderate.Size = new System.Drawing.Size(116, 21);
            this.cb2_bauderate.TabIndex = 17;
            // 
            // cb1_port
            // 
            this.cb1_port.FormattingEnabled = true;
            this.cb1_port.Location = new System.Drawing.Point(118, 54);
            this.cb1_port.Name = "cb1_port";
            this.cb1_port.Size = new System.Drawing.Size(115, 21);
            this.cb1_port.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.btn2_bkes);
            this.Controls.Add(this.btn1_baglan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb2_bauderate);
            this.Controls.Add(this.cb1_port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2_bkes;
        private System.Windows.Forms.Button btn1_baglan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb2_bauderate;
        private System.Windows.Forms.ComboBox cb1_port;
    }
}

