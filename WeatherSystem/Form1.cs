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

namespace WeatherSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            foreach (string s in SerialPort.GetPortNames()) {
                this.listBox1.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
 //           this.serialPort1.Close();
 //           this.serialPort1.PortName = listBox1.SelectedItem.ToString(); ;
            this.serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
 //           this.richTextBox1.Text += "1 :\n";
  //          this.richTextBox1.Text += this.serialPort1.ReadLine();

            SetText(this.serialPort1.ReadLine());
        }
    }
}
