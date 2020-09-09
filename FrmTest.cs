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
    public partial class FrmTest : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
       // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmTest(string txtid)
        {
            InitializeComponent();
            txtLoad.Text = txtid;
            LoadData();
        }

        void LoadData()
        {
            try
            {
               
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_Test where ID_Patient='" + txtLoad.Text + "' ", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "اسم التحليل";
                gridView1.Columns[2].Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك اسم الفحص فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }
               
                cmd = new SqlCommand("insert into Tbl_Test(Name,ID_Patient) values('" + txt_Name.Text + "','" + txtLoad.Text + "')", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();

                MessageBox.Show("تم اضافه اسم الفحص بنجاح", "حفظ", MessageBoxButtons.OK);
                LoadData();
                //  ClearData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
