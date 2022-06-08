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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var storess = cpe.Store_SelectAll();
            var stores = from store in storess select store;
            foreach(var store in stores)
            {
                comboBox1.Items.Add(store.C_Name);
                comboBox2.Items.Add(store.C_Name);
            }
            var classes = cpe.Class_SelectAll();
            var classe = from clase in classes select clase;
            foreach(var clas in classe)
            {
                comboBox3.Items.Add(clas.Code);
            }
            var supplie = cpe.Supplier_SelectAll();
            var suppli = from suppl in supplie select suppl;
            foreach (var supp in suppli)
            {
                comboBox4.Items.Add(supp.C_Name);
            }
            var release = cpe.Release_Order_SelectAll();
            var releas = from relea in release select relea;
            foreach (var rel in releas)
            {
                comboBox7.Items.Add(rel.Num);
            }
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet1);
            sqlDataAdapter2.Fill(dataSet2);
            sqlConnection1.Close();
            foreach(DataRow dr in dataSet1.Tables[0].Rows)
            {
                comboBox5.Items.Add(dr[6]);
            }
            foreach(DataRow dr in dataSet2.Tables[0].Rows)
            {
                comboBox6.Items.Add(dr[7]);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "" && comboBox7.Text != "")
            {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            cpe.Transfer_Classes(int.Parse(comboBox7.SelectedItem.ToString()), comboBox3.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(),textBox1.Text,comboBox4.SelectedItem.ToString(), DateTime.Parse(comboBox5.SelectedItem.ToString()), DateTime.Parse(comboBox6.SelectedItem.ToString()));
            MessageBox.Show("Transferred successfully!");
            textBox1.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = comboBox5.Text = comboBox6.Text = comboBox7.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter required fields!");
            }
        }
    }
}
