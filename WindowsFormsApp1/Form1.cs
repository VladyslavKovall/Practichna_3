using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CountryMedal countryMedal = null;
            if (txtname.Text == " ")
            {
                MessageBox.Show("Введіть ім`я Країни");
            }
            if (txtspc.Text != " ")
            {
                if (txtmc.Text != " ")
                {
                    countryMedal = new CountryMedal(txtname.Text, Convert.ToInt32(txtspc.Text), Convert.ToInt32(txtmc.Text));
                }
                else
                {
                   countryMedal = new CountryMedal(txtname.Text, Convert.ToInt32(txtspc.Text));
                }
            }
            else
            {
                if (txtmc.Text != " ")
                {
                    countryMedal = new CountryMedal(txtname.Text, 0, Convert.ToInt32(txtmc.Text));
                }
                else
                {
                    countryMedal= new CountryMedal(txtname.Text);
                }
            }
            if (countryMedal != null)
            {
                txtresult.Text += countryMedal.GetInformation() + "\r\n";
            }
        }
    }
}
