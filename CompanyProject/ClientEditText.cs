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
    public partial class ClientEditText : Form
    {
        public ClientEditText()
        {
            InitializeComponent();
        }
        public string clinam
        {
            set
            {
                textBox8.Text = value;
            }
        }
        public string clitele
        {
            set
            {
                textBox9.Text = value;
            }
        }
        public string clipho
        {
            set
            {
                textBox10.Text = value;
            }
        }
        public string clifax
        {
            set
            {
                textBox7.Text = value;
            }
        }
        public string climail
        {
            set
            {
                textBox11.Text = value;
            }
        }
        public string clisit
        {
            set
            {
                textBox12.Text = value;
            }
        }

        private void ClientEditText_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            cpe.Client_Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox7.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show("Updated Successfully");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = string.Empty;
        }
    }
}
