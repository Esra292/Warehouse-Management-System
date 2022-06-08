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
    public partial class Form1 : Form
    {
        DialogResult dresultClassEdit;
        DialogResult dresulAddClass;
        DialogResult dresulAddStore;
        string CodeString;
        string NameString;
        string ClassCode;
        string cc;
        string d;
        string clsnm;
        string d1;
        string adrs;
        string mngr;
        string supName;
        string supTele;
        string supPho;
        string supMail;
        string supSite;
        string supFax;
        string strnam;
        string clinam;
        string clitel;
        string clipho;
        string clifax;
        string climail;
        string clisite;
        ClassEditText cet = new ClassEditText();
        Edit_Store_Text est = new Edit_Store_Text();
        DataTable Suptable = new DataTable("SupplierA");
        public Form1()
        {
            InitializeComponent();
            label1.Size = new Size(200,50);
        }
        public string Classc
        {
            get
            {
                return d;
            }
        }
        public DataGridView data
        {
            get
            {
                return this.dataGridView1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyProjectDataSet.Class_SelectAll' table. You can move, or remove it, as needed.
            //this.class_SelectAllTableAdapter.Fill(this.companyProjectDataSet.Class_SelectAll);
            CompanyProjectEntities cpe = new CompanyProjectEntities();
           
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet1);
            sqlDataAdapter2.Fill(dataSet2);
            sqlDataAdapter3.Fill(dataSet3);
            sqlDataAdapter4.Fill(dataSet5);
            sqlDataAdapter5.Fill(dataSet6);
            sqlDataAdapter6.Fill(dataSet7);
            sqlConnection1.Close();
            dataGridView1.DataSource = dataSet1.Tables[0];
            dataGridView2.DataSource = dataSet2.Tables[0];
            dataGridView3.DataSource = dataSet3.Tables[0];
            dataGridView4.DataSource = dataSet5.Tables[0];
            dataGridView5.DataSource = dataSet6.Tables[0];
            dataGridView6.DataSource = dataSet7.Tables[0];
        }


private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet1.Tables[0].Rows[e.RowIndex];
                d = dr[0].ToString();
                clsnm = dr[1].ToString();
                Edit_Class ec = new Edit_Class();
                DialogResult dresult;
                dresult = ec.ShowDialog();
                if (dresult == DialogResult.OK)
                {
                    cet.textboxx1.Text = d;
                    cet.textboxx1.ForeColor = Color.Snow;
                    cet.nam = clsnm;
                    dresultClassEdit = cet.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a class to edit.");
            }
            
            

        }

        private void Add_Class_Click(object sender, EventArgs e)
        {
            AddClass adc = new AddClass();
            dresulAddClass = adc.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStore ads= new AddStore();
            dresulAddStore = ads.ShowDialog();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet2.Tables[0].Rows[e.RowIndex];
                d1 = dr[0].ToString();
                adrs = dr[1].ToString();
                mngr = dr[2].ToString();
                strnam= dr[0].ToString();
                Store_Edit_Con ste = new Store_Edit_Con();
                ste.showc = dr[0].ToString();
                est.nam = d1;
                est.adrs = adrs;
                est.mngr = mngr;
                DialogResult dresult = ste.ShowDialog();
                if (dresult == DialogResult.OK)
                {
                    DialogResult dresult1 = est.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a store to edit.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSupplier ads = new AddSupplier();
            DialogResult dresult = ads.ShowDialog();
            CompanyProjectEntities cpe = new CompanyProjectEntities();

        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet3.Tables[0].Rows[e.RowIndex];
                Supplier_Edit se = new Supplier_Edit();
                DialogResult dresult = se.ShowDialog();
                if (dresult == DialogResult.OK)
                {
                    SupplierEditText set = new SupplierEditText();
                    set.nam = dr[0].ToString();
                    set.tele = dr[1].ToString();
                    set.pho = dr[2].ToString();
                    set.nfax = dr[3].ToString();
                    set.mail = dr[4].ToString();
                    set.sit = dr[5].ToString();
                    DialogResult dresult1 = set.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a supplier!");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClient adc = new AddClient();
            DialogResult dresult = adc.ShowDialog();    
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet5.Tables[0].Rows[e.RowIndex];
                clinam = dr[0].ToString();
                clitel = dr[1].ToString();
                clipho = dr[2].ToString();
                clifax = dr[3].ToString();
                climail = dr[4].ToString();
                clisite = dr[5].ToString();
                Edit_Client ec = new Edit_Client();
                DialogResult dresult = ec.ShowDialog();
                if (dresult == DialogResult.OK)
                {
                    ClientEditText cet = new ClientEditText();
                    cet.clinam = clinam;
                    cet.clitele = clitel;
                    cet.clipho = clipho;
                    cet.clifax = clifax;
                    cet.climail = climail;
                    cet.clisit = clisite;
                    DialogResult dresult1 = cet.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a client to edit!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddSalesOrder ads = new AddSalesOrder();
            DialogResult dlg = ads.ShowDialog();
            CompanyProjectEntities cpe = new CompanyProjectEntities();

        }

        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet6.Tables[0].Rows[e.RowIndex];
                EditSaleOrder eds = new EditSaleOrder();
                eds.salnum = dr[1].ToString();
                eds.stonam = dr[0].ToString();
                eds.saldate = dr[2].ToString();
                eds.clinam = dr[4].ToString();
                eds.clasnam = dr[3].ToString();
                eds.quant = dr[5].ToString();
                DialogResult dresult = eds.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a sale order to edit!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddReleaseOrder adr = new AddReleaseOrder();
            DialogResult dresult = adr.ShowDialog();
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataRow dr = dataSet7.Tables[0].Rows[e.RowIndex];
                EditReleaseOrder edr = new EditReleaseOrder();
                edr.releanum = dr[1].ToString();
                edr.stornam = dr[0].ToString();
                edr.releadate = dr[2].ToString();
                edr.supnam = dr[5].ToString();
                edr.classnam = dr[3].ToString();
                edr.quant = dr[4].ToString();
                edr.prodat = dr[6].ToString();
                edr.expdat = dr[7].ToString();
                DialogResult dresult = edr.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please select a release order to edit!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transfer tra = new Transfer();
            DialogResult dresult = tra.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stores_Report sr = new Stores_Report();
            DialogResult dresult = sr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Classes_Report cr = new Classes_Report();
            DialogResult dresult = cr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClassP cl = new ClassP();
            DialogResult dresult = cl.ShowDialog();
        }

        
    }
}
