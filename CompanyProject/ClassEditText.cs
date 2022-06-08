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
    public partial class ClassEditText : Form
    {
        public ClassEditText()
        {
            InitializeComponent();
        }
        public TextBox textboxx1
        {
            get
            {
                return textBox1;
            }
        }
        public string NameText
        {
            get
            {
                return textBox2.Text;
            }
        }
        public string nam
        {
            set
            {
                textBox3.Text = value;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        private void Class_Update_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cp = new CompanyProjectEntities();
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox3.Text;
                MessageBox.Show("Enter Name!");
            }
            cp.Class_Update(textboxx1.Text, textBox2.Text);
            MessageBox.Show("Edited successfully!");
           textBox2.Text = string.Empty;
        }
    }
}
