using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] portlar = SerialPort.GetPortNames();  //port cagırmak
            foreach (string portAdi in portlar)
            {
                cbPort.Items.Add(portAdi);
            }
            

            cbBauderate.Items.AddRange(new string[]
            { "300", "600", "1200", "2400", "4800", "9600", "19200" }); //bauderate degerleri

        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt16(cbBauderate.Text);
            try
            {
                serialPort1.PortName = cbPort.Text;

                if (!serialPort1.IsOpen)
                {
                    timer1.Start();
                    serialPort1.Open();

                    btnBaglan.Enabled = false;
                    btnBaglantiKes.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baglantı Kurulamadı");
                btnBaglantiKes.Enabled = true;
            }     
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {                               //read existing de kullanılabilir
                string sonuc = serialPort1.ReadLine();             //satır satır oku serail portu
                string[] paket = sonuc.Split('#');                 //split türü

                double degisken1 = Convert.ToDouble(paket[0]);
                lbGelenVeri.Items.Add(degisken1);

            //    double degisken2 = Convert.ToDouble(paket[1]);     
            //   double degisken3 = Convert.ToDouble(paket[2]);    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Timer Hatası, baglantı kesiliyor ");
                timer1.Stop();
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) //formun yenilenme hızı 
        {
            timer1.Interval = 1000;
           
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            btnBaglan.Enabled = true;
            btnBaglantiKes.Enabled = false;
            MessageBox.Show("Baglantı Kesildi");
        }

        private void btnVeriGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(tbGidecekVeri.Text);
                    //serialPort1.Write(tbGidecekVeri.Text);
                   
                    lbGidenVeri.Items.Add(tbGidecekVeri.Text);
                    tbGidecekVeri.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Port Bağlantısı Yok, Yeniden Baglanmaya Calısınız");
                timer1.Stop();
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)//formun yenilenme hızı
        {
                timer1.Interval = 1000;    

        }
    }
}
