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
    public partial class FrmReservation : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
       
        DataTable dt = new DataTable();
        public FrmReservation()
        {
            InitializeComponent();
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (string.IsNullOrEmpty(txt_number.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك رقم الحجز فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك اسم المريض فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                cmd = new SqlCommand("insert into Tbl_Reservation(Number,Name,Reservation_Dat) values('" + txt_number.Text + "','" + txt_name.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();

                MessageBox.Show("تم الحجز بنجاح", "حفظ", MessageBoxButtons.OK);
                LoadData();
                //ClearData();
            }
            catch (Exception)
            {

                throw;
            }
        }


        void LoadData()
        {
            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_Reservation", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;

                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "رقم الحجز";
                gridView1.Columns[2].Caption = "اسم المريض";
                gridView1.Columns[3].Caption = "تاريخ الحجز";

              
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }
    }
}
