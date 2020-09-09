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
    public partial class FrmDiagnosis : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        //DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public FrmDiagnosis(string txtid)
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
                da = new SqlDataAdapter("select * from Tbl_Diagnosis where ID_Patient='" + txtLoad.Text + "' ", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "التشخيص";
                gridView1.Columns[2].Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

                cmd = new SqlCommand("insert into Tbl_Diagnosis(Name,ID_Patient) values('" + txt_Name.Text + "','" + txtLoad.Text + "')", DAL.sqlcon);
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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDiagnosis_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
