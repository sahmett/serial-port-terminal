using System;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {

        //DEGİSKENLER
        public static double gps_lat = 0.0, gps_long = 0.0; int zoom = 5;       //harita degiskenleri
        public string data; //data degiskeni
        GMapMarker rocket_marker;
        GMapMarker ground_marker;
        public static double arttirma = 1.0;
        public static int deg = 1;

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


            //fonksyonlar
            setUpMap();


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
            data = serialPort1.ReadLine(); //serail portu satır satır oku 
            this.Invoke(new EventHandler(displayData_event));
        }

        //seri port yakalayıcının, veri geldiğinde uygulayacağı tüm işlemleri burada
        private void displayData_event(object sender, EventArgs e)
        {
            arttirma += 0.00; //haritada hareket sağlamak icun

            //fonksyonlar
            splitData();
            saveTxt();
            setLocation();

        }
        private void splitData()
        {
            try
            {
                string[] paket = data.Split('#');                   //split türü
                double hizdeger = Convert.ToDouble(paket[0]);       //grafik hız
                gps_lat = Convert.ToDouble(paket[1]);                   //gps longh
                gps_long = Convert.ToDouble(paket[2]);                 //gps longh

                gps_lat += arttirma;   //hareket simüle etme
                gps_long += arttirma;


                this.chart1.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), hizdeger);        //chart1 hız 
                txbHiz.Text = (hizdeger) + "";

                this.chart2.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), (hizdeger) );             //chart2 hız 
                txbHiz.Text = (hizdeger + 10) + "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Veri Isleme Hatası, Baglantınız Kesiliyor ");
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }
        }

        #region TXT
        //TXT
        private void saveTxt()
        {
            try //txt kaydetme V1 eski
            {
                lbGelenVeri.Items.Add(data);
                const string sPath = "log.txt";
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath, append: true);
                foreach (var item in lbGelenVeri.Items)
                {
                    SaveFile.WriteLine(item);
                }
                SaveFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Txt Kayıt Hatası, Baglantınız Kesiliyor ");
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }


            try  //txt kaydetme v2
            {
                const string sPath = "logV2.txt";
                using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath, append: true))
                {
                    SaveFile.WriteLine(data);
                    SaveFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Txt Kayıt Hatası, Baglantınız Kesiliyor ");
                serialPort1.Close();
                btnBaglan.Enabled = true;
                btnBaglantiKes.Enabled = false;
            }
        }
        #endregion

        #region Harita 
        //HARİTA
        private void setUpMap()
        {
            //mapView.Position = new PointLatLng(42, 21);

            
            GMapProviders.GoogleMap.ApiKey = "AIzaSyBqKYJKZ4KuUNK7_PeOPUFFeV5MYQdkTvI";
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.MaxZoom = 70;
            gMapControl1.MinZoom = 5;
            gMapControl1.Zoom = 15;
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
        }

        private void setLocation()
        {

            if (gps_lat != 0 && gps_long != 0)
            {
                gMapControl1.Position = new PointLatLng(gps_lat, gps_long);
                rocket_marker.Position = new PointLatLng(gps_lat, gps_long);
                ground_marker.Position = new PointLatLng(gps_lat, gps_long);
            }
            else
            {
                MessageBox.Show("Konum değeri okunamadı.");
            }
        }

        private void setGroundMaker(double longitude, double latitude)
        {
           
            ground_marker = new GMapMarker(new PointLatLng(444, 55));
            gMapControl1.Markers.Add(ground_marker);
           

            try
            {
                ground_marker.Shape = new System.Windows.Controls.Image
                {
                    Width = 50,
                    Height = 50,
                    Source = new BitmapImage(new Uri(@"C:\Users\faruk\source\repos\TaliaGroundStation\TaliaGroundStation\groundStation.png"))
                };
                MessageBox.Show("Yer istasyonunu konumu setlendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ground MARKER " + ex.Message);
            }
        }

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
                gMapControl1.Position = new PointLatLng(gps_lat, gps_long);  //gps_lat gps_long
                gMapControl1.MinZoom = 5;
                gMapControl1.MaxZoom = 100;
                gMapControl1.Zoom = 10;
            }
        }

        #endregion

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
