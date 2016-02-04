using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyWFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEMR_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Hello", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            switch (ret)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    Debug.WriteLine("User pressed OK");
                    break;
                case DialogResult.Cancel:
                    Debug.WriteLine("User pressed Cancel");
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataInputForm dif = new DataInputForm();
            DialogResult ret = dif.ShowDialog();
            string nume, prenume;

            if (ret == DialogResult.OK)
            {
                if (dif.Value != null)
                {
                    this.lstPersons.Items.Add(dif.Value.ToString());
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.lblCounter.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(this.lblCounter.Text);
            this.lblCounter.Text = (n + 1).ToString();
        }
    }
}
