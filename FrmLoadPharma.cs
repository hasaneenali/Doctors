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
    public partial class FrmLoadPharma : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
       // DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        string s;
        DataTable dt = new DataTable();
        public FrmLoadPharma(string txtid)
        {
            InitializeComponent();
            txtLoad.Text = txtid;
            LoadData();
        }

        void LoadData()
        {
            try
            {
                FrmDoctro frm = new FrmDoctro();
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_Pharma where ID_Patient='"+ txtLoad.Text + "' ", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "اسم الدواء";
                gridView1.Columns[2].Caption = "كميه الجرعه";
                gridView1.Columns[3].Caption = "عدد الجرعات";
                gridView1.Columns[4].Caption = "وقت تناول الدواء";
                gridView1.Columns[5].Caption = "مده العلاج";
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmLoadPharma_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Click(object sender, EventArgs e)
        {
            //txt_id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            //txt_Name.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            //txt_Amount.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            //txt_Number.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            //com_Time.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            //txt_Duration.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            //txt_Note.Text = dgv.CurrentRow.Cells[6].Value.ToString();
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (com_Time.SelectedIndex == -1)
                {
                    MessageBox.Show("الرجاء عدم ترك وقت الدواء فارغ ", "خطا", MessageBoxButtons.OK);
                    return;
                }


                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك اسم الدواء فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txt_Amount.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك كميه الجرعات فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txt_Number.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك عدد الجرعات فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(txt_Duration.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك مده العلاج فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                cmd = new SqlCommand("insert into Tbl_Pharma(Name,Amount,Number,Time,Duration,Note,ID_Patient) values('" + txt_Name.Text + "','" + txt_Amount.Text + "','" + txt_Number.Text + "','" + com_Time.Text + "','" + txt_Duration.Text + "','" + txt_Note.Text + "','" + txtLoad.Text + "')", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();

                MessageBox.Show("تم اضافه اسم الدواء بنجاح", "حفظ", MessageBoxButtons.OK);
                LoadData();
              //  ClearData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAllPharma frm = new FrmAllPharma();
                frm.ShowDialog();
                if (frm.dgv.CurrentRow != null)
                {
                    txt_Name.Text = frm.dgv.CurrentRow.Cells[1].Value.ToString();
                    txt_Amount.Text = frm.dgv.CurrentRow.Cells[2].Value.ToString();
                    txt_Number.Text = frm.dgv.CurrentRow.Cells[3].Value.ToString();
                    com_Time.Text = frm.dgv.CurrentRow.Cells[4].Value.ToString();
                    txt_Duration.Text = frm.dgv.CurrentRow.Cells[5].Value.ToString();
                    txt_Note.Text = frm.dgv.CurrentRow.Cells[6].Value.ToString();
                }

                else
                {
                    txt_Name.Text = "";
                    txt_Amount.Text = "";
                    txt_Number.Text = "";
                    com_Time.Text = "";
                    txt_Duration.Text = "";
                    txt_Note.Text = "";
                }
               
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
           
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
