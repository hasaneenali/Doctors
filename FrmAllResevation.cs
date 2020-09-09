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
using DevExpress.XtraEditors;

namespace Doctors
{
    public partial class FrmAllResevation : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        //DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public FrmAllResevation()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            try
            {
               
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_Reservation", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "رقم الحجز";
                dgv.Columns[2].HeaderText = "اسم المريض";
                dgv.Columns[3].HeaderText = "تاريخ الحجز";

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmAllResevation_Load(object sender, EventArgs e)
        {

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
                da = new SqlDataAdapter("select * from Tbl_Reservation where Name like '" + textBox1.Text + "%' ", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("الرجاء اعادة البحث من جديد", "البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
