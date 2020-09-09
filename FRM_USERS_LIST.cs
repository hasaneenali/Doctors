using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Doctors
{
    public partial class FRM_USERS_LIST : DevExpress.XtraEditors.XtraForm
    {
       // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        DataAccessLayer DAL = new DataAccessLayer();
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public FRM_USERS_LIST()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();
        }

      public void LoadData()
        {
            try
            {

                dt.Clear();
                da = new SqlDataAdapter("select * from TBL_USERS", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;

                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "اسم السمتخدم";
                dgv.Columns[2].HeaderText = "الاسم الكامل";
                dgv.Columns[3].HeaderText = "كلمه السر";
                dgv.Columns[4].HeaderText = "نوع المستخدم";
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FRM_USERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.txtId_Key.Text= dgv.CurrentRow.Cells[0].Value.ToString();
            frm.txtID.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            frm.txtFullName.Text= dgv.CurrentRow.Cells[2].Value.ToString();
            frm.txtPWD.Text= dgv.CurrentRow.Cells[3].Value.ToString();
            frm.txtPWDConfirm.Text= dgv.CurrentRow.Cells[3].Value.ToString();
            frm.cmbType.Text= dgv.CurrentRow.Cells[4].Value.ToString();
            frm.btnSave.Text = "تعديل المستخدم";
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter("select * from TBL_USERS where FullName like '" + txtSearch.Text + "%' ", DAL.sqlcon);
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