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
    public partial class AddSalesOrder : Form
    {
        public AddSalesOrder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddSalesOrder_Load(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var sto = cpe.Store_SelectAll();
            var stor = from st in sto select st;
            foreach(var s in stor)
            {
                comboBox1.Items.Add(s.C_Name);
            }
            var clie = cpe.Client_SelectAll();
            var cli = from cl in clie select cl;
            foreach(var c in cli)
            {
                comboBox2.Items.Add(c.C_Name);
            }
            var clasname = cpe.Class_SelectAll();
            var clasnam = from clasna in clasname select clasna;
            foreach (var clas in clasnam)
            {
                comboBox3.Items.Add(clas.C_Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox3.Text != "" && comboBox2.Text != "")
            {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            cpe.CommonBetweenSale_Insert(comboBox1.SelectedItem.ToString(),int.Parse(textBox1.Text),DateTime.Parse(textBox3.Text),comboBox3.SelectedItem.ToString(),comboBox2.SelectedItem.ToString(),textBox2.Text);
            MessageBox.Show("Added successfully!");
            textBox1.Text = textBox3.Text = comboBox1.Text = comboBox2.Text =comboBox3.Text=textBox2.Text= string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter required fields!");
            }

        }
    }
}
