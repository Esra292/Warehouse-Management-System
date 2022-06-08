using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyProject
{
    public partial class SupplierEditText : Form
    {
        public string nam
        {
            set
            {
                textBox8.Text = value;
            }
        }
        public string tele
        {
            set
            {
                textBox9.Text = value;
            }
        }
        public string pho
        {
            set
            {
                textBox10.Text = value;
            }
        }
        public string fax
        {
            set
            {
                textBox11.Text = value;
            }
        }
        public string mail
        {
            set
            {
                textBox11.Text = value;
            }
        }
        public string sit
        {
            set
            {
                textBox12.Text = value;
            }
        }
        public string nfax
        {
            set
            {
                textBox7.Text = value;
            }
        }
        public SupplierEditText()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox8.Text;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox9.Text;
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = textBox10.Text;
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = textBox11.Text;
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = textBox12.Text;
            }
            textBox4.Text = textBox7.Text;
            cpe.Supplier_Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox7.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show("Updated successfully!");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = string.Empty;
        }
    }
}
