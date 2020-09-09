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
    public partial class FrmAllPharma : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmAllPharma()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            try
            {
               
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_NewPharma", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "اسم الدواء";
                dgv.Columns[2].HeaderText = "كميه الجرعه";
                dgv.Columns[3].HeaderText = "عدد الجرعات";
                dgv.Columns[4].HeaderText = "وقت تناول الدواء";
                dgv.Columns[5].HeaderText = "مده العلاج";
                dgv.Columns[6].HeaderText = "الملاحظات";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmAllPharma_Load(object sender, EventArgs e)
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
                da = new SqlDataAdapter("select * from TBL_USERS where Name ='" + textBox1.Text + "' ", DAL.sqlcon);
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
