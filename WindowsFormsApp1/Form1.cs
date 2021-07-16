using System;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET.MapProviders;
using GMap.NET;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {

        //DEGİSKENLER
        public static double lat = 0.0, longt = 0.0; int zoom = 5;       //harita degiskenleri
        public string data; //data degiskeni

        public Form1()
        {
            InitializeComponent();

            string[] portlar = SerialPort.GetPortNames();  //port getir
            foreach (string portAdi in portlar)
            {
                cbPort.Items.Add(portAdi);
            }
            
            cbBauderate.Items.AddRange(new string[]
            { "300", "600", "1200", "2400", "4800", "9600", "19200" }); //bauderate atama


            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //gelen veri yakalama
            serialPort1.NewLine = "\n";

        }


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

        //seri port yakalayıcının satır okuma tetiklemesi
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine(); //satır satır oku serail portu

            this.Invoke(new EventHandler(displayData_event));
        }

        //seri port yakalayıcının, veri geldiğinde uygulayacağı tüm işlemleri burada
        private void displayData_event(object sender, EventArgs e)
        {
            try
            {
                string[] paket = data.Split('#');                   //split türü
                double hizdeger = Convert.ToDouble(paket[0]);       //grafik hız
                lat = Convert.ToDouble(paket[1]);                   //gps longh
                longt = Convert.ToDouble(paket[2]);                 //gps longh

                this.chart1.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), hizdeger);        //chart1 hız 
                txbHiz.Text = (hizdeger) + "";

                this.chart2.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), lat);        //chart1 hız 
                txbHiz.Text = (lat) + "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Veri Isleme Hatası, Baglantınız Kesiliyor ");
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }

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
                        SaveFile.Close();        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex + "Txt Kaydedilemedi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Txt Kayıt Hatası, Baglantınız Kesiliyor ");
                    serialPort1.Close();
                    btnBaglan.Enabled = true;
                    btnBaglantiKes.Enabled = false;
                }

            {

                //harita konumu revize
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.Position = new PointLatLng(lat, longt);  //lat longt 
                gMapControl1.MinZoom = 5;
                gMapControl1.MaxZoom = 100;
                gMapControl1.Zoom = 10;
            }

        }

        //HARİTA
        private void btnArti_Click(object sender, EventArgs e) //harita yakınlastırma
        {
            if (zoom < 100)
                zoom += 1;
            gMapControl1.MinZoom = zoom;
            gMapControl1.Zoom = zoom;
        }

        private void btnEksi_Click(object sender, EventArgs e) //harita uzaklaştırma
        {
            if (zoom > 0)
                zoom -= 1;
            gMapControl1.MinZoom = zoom;
            gMapControl1.Zoom = zoom;
        }

        private void btnBul_Click(object sender, EventArgs e)  //haritada konum bulma
        {
            if (serialPort1.IsOpen)
            {
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.Position = new PointLatLng(lat, longt);  //lat longt
                gMapControl1.MinZoom = 5;
                gMapControl1.MaxZoom = 100;
                gMapControl1.Zoom = 10;
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
            if (serialPort1.IsOpen) serialPort1.Close();    
        }

    }
}
