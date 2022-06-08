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
    public partial class ClassP : Form
    {
        public ClassP()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ClassP_Load(object sender, EventArgs e)
        {
            //CompanyProjectEntities cpe = new CompanyProjectEntities();
            //var release = cpe.Release_Order_SelectAll();
            //var releas = from relea in release select relea;
            //foreach (var rel in releas)
            //{
            //    comboBox1.Items.Add(rel.C_Date);
            //}
            //var sales = cpe.Sale_Order_SelectAll();
            //var sale = from sal in sales select sal;
            //foreach (var sa in sale)
            //{
            //    comboBox2.Items.Add(sa.C_Date);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var exp=cpe.EXPDA1(int.Parse(textBox1.Text));
            dataGridView1.DataSource = exp;
        }
    }
}
