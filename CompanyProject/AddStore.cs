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
    public partial class AddStore : Form
    {
        public AddStore()
        {
            InitializeComponent();
        }

        private void AddStore_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            cpe.Store_Insert(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Added successfully!");
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter required fields!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
