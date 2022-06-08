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
    public partial class EditReleaseOrder : Form
    {
        public EditReleaseOrder()
        {
            InitializeComponent();
        }
        public string releanum
        {
            set
            {
                textBox3.Text = value;
            }
        }
        public string stornam
        {
            set
            {
                textBox4.Text = value;
            }
        }
        public string releadate
        {
            set
            {
                textBox5.Text = value;
            }
        }
        public string supnam
        {
            set
            {
                textBox6.Text = value;
            }
        }
        public string classnam
        {
            set
            {
                textBox10.Text = value;
            }
        }
        public string quant
        {
            set
            {
                textBox11.Text = value;
            }
        }
        public string prodat
        {
            set
            {
                textBox12.Text = value;
            }
        }
        public string expdat
        {
            set
            {
                textBox13.Text = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditReleaseOrder_Load(object sender, EventArgs e)
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
            foreach (var clas in classn)
            {
                comboBox3.Items.Add(clas.C_Name);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox3.Text;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox5.Text;
            }
            if (comboBox1.Text == "")
            {
                comboBox1.Text = textBox4.Text;
            }
            if (comboBox2.Text == "")
            {
                comboBox2.SelectedItem = textBox6.Text;
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = textBox11.Text;
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = textBox12.Text;
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = textBox13.Text;
            }
            if (comboBox3.Text == "")
            {
                comboBox3.SelectedItem = textBox10.Text;
            }
            textBox1.Text = textBox3.Text;
            cpe.CommonBetweenRelease_Update2(comboBox1.SelectedItem.ToString(), int.Parse(textBox1.Text), DateTime.Parse(textBox2.Text), comboBox3.SelectedItem.ToString(), textBox7.Text, comboBox2.SelectedItem.ToString(), DateTime.Parse(textBox8.Text), DateTime.Parse(textBox9.Text));
            MessageBox.Show("Updated Successfully!");
            textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text =textBox7.Text=textBox8.Text=textBox9.Text=comboBox3.Text= string.Empty;
        }
    }
}
