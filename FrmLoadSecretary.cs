using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors
{
    public partial class FrmLoadSecretary : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
       // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        string s;
        DataTable dt = new DataTable();
        public FrmLoadSecretary()
        {
            InitializeComponent();
            LoadData();
        }

        private void FrmLoadSecretary_Load(object sender, EventArgs e)
        {
           
        }

        void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("select * from Tbl_Patients", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "اسم المريض";
                dgv.Columns[2].HeaderText = "العنوان";
                dgv.Columns[3].HeaderText = "رقم الموبايل";
                dgv.Columns[4].HeaderText = "عمر المريض";
                dgv.Columns[5].HeaderText = "جنس المريض";
                dgv.Columns[6].HeaderText = "الفحص";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            Close();
        }

       

       

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter("select * from Tbl_Patients where Name like '" + textBox1.Text + "%' ", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show("الرجاء اعادة البحث من جديد", "البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
