using System;
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

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); 
            serialPort1.NewLine = "\n";

        }

        private string data;

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt16(cbBauderate.Text);
            try
            {
                serialPort1.PortName = cbPort.Text;

                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    btnBaglan.Enabled = false;
                    btnBaglantiKes.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"Baglantı Kurulamadı");
                btnBaglantiKes.Enabled = true;
            }     
    }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
             try
                {
                    lbGelenVeri.Items.Add(data);
                    try
                    {
                        const string sPath = "log.txt";
                        System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                        foreach (var item in lbGelenVeri.Items)
                        {
                            SaveFile.WriteLine(item);
                        }
                        SaveFile.Close();        //sürekli kapanması sağlıksız olabilir
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex + "Txt Kaydedilemedi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Timer Hatası, Baglantınız Kesiliyor ");
                    serialPort1.Close();
                    btnBaglan.Enabled = true;
                    btnBaglantiKes.Enabled = false;
                }
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnBaglan.Enabled = true;
            btnBaglantiKes.Enabled = false;
            MessageBox.Show("Baglantı Kesildi");
      
        }
        private void btnVeriGonder_Click(object sender, EventArgs e)
        {  
            serialPort1.Write(tbGidecekVeri.Text);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat

        }

    }
}
