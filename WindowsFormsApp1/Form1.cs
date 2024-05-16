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
            Person person = null;
            if (txtname.Text == " ")
            {
                MessageBox.Show("Введіть ім`я");
            }
            if (txtage.Text != " ")
            {
                if (txtprof.Text != " ")
                {
                    person = new Person(txtname.Text, Convert.ToInt32(txtage.Text), txtprof.Text);
                }
                else
                {
                   person = new Person(txtname.Text, Convert.ToInt32(txtage.Text));
                }
            }
            else
            {
                if (txtprof.Text != " ")
                {
                    person = new Person(txtname.Text, 0, txtprof.Text);
                }
                else
                {
                    person = new Person(txtname.Text);
                }
            }
            if (person != null)
            {
                txtresult.Text += person.GetInformation() + "\r\n";
            }
        }
    }
}
