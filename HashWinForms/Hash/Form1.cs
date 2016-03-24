using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace Hash
{
    public partial class Form1 : Form
    {
        enum Algoritmi
        {
            MD5,
            SHA1, 
            SHA256,
            SHA384, 
            SHA512
        }
        HashAlgorithm ha;
        Thread t;
        private string filename = "";
        private Algoritmi algoritm = Algoritmi.SHA1;
        private bool filenameSetat = false;
        public Form1()
        {
            InitializeComponent();
            string[] enumValues = Enum.GetNames(typeof(Algoritmi));
            foreach (string s in enumValues)
            {
                comboBox1.Items.Add(s);
            }
            
        }
        private void ComputeMyHash()
        {
            if (this.label4.InvokeRequired)
            {
                this.Invoke(new Action(() => this.label4.Text = "Status: Working ..."));
            }
            //label4.Text = "Status: Working ...";
            byte[] valoareHash = ha.ComputeHash(new FileStream(filename, FileMode.Open, FileAccess.Read));

            if (this.label4.InvokeRequired)
            {
                this.Invoke(new Action(() => this.label4.Text = "Status: FINISHED"));
            }
            //label4.Text = "Status: FINISHED";
            StringBuilder sb = new StringBuilder();
            foreach (byte b in valoareHash)
                sb.AppendFormat("{0:X2}", b);

            if(this.textBox2.InvokeRequired)
            {
                this.Invoke(new Action(() => textBox2.Text = sb.ToString()));
            }
            //textBox2.Text = sb.ToString();

            if (this.button3.InvokeRequired)
            {
                this.Invoke(new Action(() => button3.Enabled = false));
            }
            //button3.Enabled = false;    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                filenameSetat = true;
                textBox1.Text = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filenameSetat)
            {
                
                switch (comboBox1.Text)
                {
                    case "MD5":
                        algoritm = Algoritmi.MD5;
                        break;
                    case "SHA1":
                        algoritm = Algoritmi.SHA1;
                        break;
                    case "SHA256":
                        algoritm = Algoritmi.SHA256;
                        break;
                    case "SHA384":
                        algoritm = Algoritmi.SHA384;
                        break;
                    case "SHA512":
                        algoritm = Algoritmi.SHA512;
                        break;
                }
                switch (algoritm)
                {
                    case Algoritmi.MD5:
                        ha = new MD5CryptoServiceProvider();
                        break;
                    case Algoritmi.SHA1:
                        ha = new SHA1CryptoServiceProvider();
                        break;
                    case Algoritmi.SHA256:
                        ha = new SHA256CryptoServiceProvider();
                        break;
                    case Algoritmi.SHA384:
                        ha = new SHA384CryptoServiceProvider();
                        break;
                    case Algoritmi.SHA512:
                        ha = new SHA512CryptoServiceProvider();
                        break;
                    default:
                        ha = new MD5CryptoServiceProvider();
                        break;
                }
                t = new Thread(new ThreadStart(ComputeMyHash));
                button3.Enabled = true;
                t.IsBackground = true; // daca se tremina programul trebuie sa se termine si thread-ul
                
                t.Start();

            }
            else{
                MessageBox.Show("Nu este ales fisierul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Abort();
            button3.Enabled = false;
            label4.Text = "Status: ABORTED";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t.IsBackground)
                MessageBox.Show("Background Thread");
            else
                MessageBox.Show("Foreground Thread");
        }//functia
    }
}
