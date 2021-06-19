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

    }
    }
}
