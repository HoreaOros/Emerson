using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWFormApp
{
    public partial class DataInputForm : Form
    {
        Persoana pers = null;
        public DataInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pers = new Persoana(this.txtNume.Text, this.txtPrenume.Text, this.dateTimePicker.Value);
            this.Close();
        }
        public Persoana Value
        {
            get
            {
                return pers;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
