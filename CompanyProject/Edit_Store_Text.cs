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
    public partial class Edit_Store_Text : Form
    {
        public Edit_Store_Text()
        {
            InitializeComponent();
        }
        public string nam
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public string adrs
        {
            set
            {
                textBox4.Text = value;
            }
            get
            {
                return textBox4.Text;
            }
        }
        public string mngr
        {
            set
            {
                textBox5.Text = value;
            }
            get
            {
                return textBox5.Text;
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            if (textBox2.Text == "")
            {
                textBox2.Text=adrs; 
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = mngr;
            }
            cpe.Store_Update(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Updated successfully");
            textBox2.Text = textBox3.Text = string.Empty;
        }
    }
}
