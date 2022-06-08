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
    public partial class EditSaleOrder : Form
    {
        public EditSaleOrder()
        {
            InitializeComponent();
        }
        public string salnum
        {
            set
            {
                textBox2.Text = value;
            }
        }
        public string stonam
        {
            set
            {
                textBox4.Text = value;
            }
        }
        public string saldate
        {
            set
            {
                textBox5.Text = value;
            }
        }
        public string clinam
        {
            set
            {
                textBox6.Text = value;
            }
        }
        public string clasnam
        {
            set
            {
                textBox8.Text = value;
            }
        }
        public string quant
        {
            set
            {
                textBox9.Text = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditSaleOrder_Load(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var stor = cpe.Store_SelectAll();
            var sto = from st in stor select st;
            foreach(var st in sto)
            {
                comboBox1.Items.Add(st.C_Name);
            }
            var clinam= cpe.Client_SelectAll();
            var clina = from clif in clinam select clif;
            foreach(var clin in clina)
            {
                comboBox2.Items.Add(clin.C_Name);
            }
            var classnam = cpe.Class_SelectAll();
            var classna = from classn in classnam select classn;
            foreach(var clas in classna)
            {
                comboBox3.Items.Add(clas.C_Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox2.Text;
            }
            if (comboBox1.Text == "")
            {
                comboBox1.SelectedItem = textBox4.Text;
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = textBox5.Text;
            }
            if (comboBox2.Text == "")
            {
                comboBox2.SelectedItem = textBox6.Text;
            }
            if (comboBox3.Text == "")
            {
                comboBox3.SelectedItem = textBox8.Text;
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = textBox9.Text;
            }
            cpe.CommonBetweenSale_Update2(comboBox1.SelectedItem.ToString(), int.Parse(textBox1.Text), DateTime.Parse(textBox3.Text), comboBox3.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), textBox7.Text);
            MessageBox.Show("Updated successfully!");
            textBox1.Text = textBox3.Text = comboBox1.Text = comboBox2.Text=comboBox3.Text=textBox7.Text = string.Empty;
        }
    }
}
