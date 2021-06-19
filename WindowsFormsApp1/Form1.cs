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
            catch (Exception)
            {
                MessageBox.Show("Baglantı Kurulamadı");
                btnBaglantiKes.Enabled = true;
            }     
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort1.ReadLine();             //satır satır oku serail portu
                string[] paket = sonuc.Split('#');                 //split türü

                double degisken1 = Convert.ToDouble(paket[1]);     //gps longh
                double degisken2 = Convert.ToDouble(paket[2]);     //gps longh

                double chartdeger = Convert.ToDouble(paket[0]);    //grafik sicaklik
            }
            catch (Exception)
            {
                MessageBox.Show("Timer Hatası");
            }
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            btnBaglan.Enabled = true;
            btnBaglantiKes.Enabled = false;
            MessageBox.Show("baglantı kesildi");
        }
    }
}
