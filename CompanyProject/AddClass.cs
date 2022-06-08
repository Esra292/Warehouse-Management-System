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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        public string CodeText
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string NameText
        {
            get
            {
                return textBox2.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                CompanyProjectEntities cp = new CompanyProjectEntities();
                cp.Class_Insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("Added Successfully!");
                textBox1.Text = textBox2.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter required fields");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
