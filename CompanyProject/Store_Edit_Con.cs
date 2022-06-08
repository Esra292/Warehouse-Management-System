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
    public partial class Store_Edit_Con : Form
    {
        public Store_Edit_Con()
        {
            InitializeComponent();
        }
        public string showc
        {
            set
            {
                textBox1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowClass sc = new ShowClass();
            sc.stonam = textBox1.Text;
            DialogResult dresult = sc.ShowDialog();
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var data=cpe.ShowClass(textBox1.Text);
            sc.datag.DataSource = data;
        }
    }
}
