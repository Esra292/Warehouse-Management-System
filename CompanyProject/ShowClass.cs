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
    public partial class ShowClass : Form
    {
        public ShowClass()
        {
            InitializeComponent();
        }
        public DataGridView datag
        {
            get
            {
                return this.dataGridView1;
            }
        }
        public string stonam
        {
            set
            {
                textBox1.Text = value; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ShowClass_Load(object sender, EventArgs e)
        {
            CompanyProjectEntities cpe = new CompanyProjectEntities();
            var data = cpe.ShowClass(textBox1.Text);
            dataGridView1.DataSource = data;
        }
    }
}
