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
    public partial class AddReleaseOrder : Form
    {
        public AddReleaseOrder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddReleaseOrder_Load(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var stornam = cpe.Store_SelectAll();
            var storna = from storn in stornam select storn;
            foreach(var stor in storna)
            {
                comboBox1.Items.Add(stor.C_Name);
            }
            var supnam = cpe.Supplier_SelectAll();
            var supna = from supn in supnam select supn;
            foreach(var sup in supna)
            {
                comboBox2.Items.Add(sup.C_Name);
            }
            var classna = cpe.Class_SelectAll();
            var classn = from clasn in classna select clasn;
            foreach(var clas in classn)
            {
                comboBox3.Items.Add(clas.C_Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox3.Text != "" && comboBox2.Text != "")
            {
                CompanyProjectEntities cpe = new CompanyProjectEntities();
                cpe.CommonBetweenRelease_Insert(comboBox1.SelectedItem.ToString(), int.Parse(textBox1.Text), DateTime.Parse(textBox2.Text), comboBox3.SelectedItem.ToString(), textBox3.Text, comboBox2.SelectedItem.ToString(), DateTime.Parse(textBox4.Text), DateTime.Parse(textBox5.Text));
                MessageBox.Show("Added successfully!");
                textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Please enter required fields!");
            }
        }
    }
}
