using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doctors
{
    public partial class FrmPharma : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        //DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        string s;
        DataTable dt = new DataTable();
        public FrmPharma()
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
               
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "اسم الدواء";
                gridView1.Columns[2].Caption = "كميه الجرعه";
                gridView1.Columns[3].Caption = "عدد الجرعات";
                gridView1.Columns[4].Caption = "وقت تناول الدواء";
                gridView1.Columns[5].Caption = "مده العلاج";
                gridView1.Columns[6].Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmPharma_Load(object sender, EventArgs e)
        {

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

                cmd = new SqlCommand("insert into Tbl_NewPharma(Name,Amount,Number,Time,Duration,Note) values('" + txt_Name.Text + "','" + txt_Amount.Text + "','" + txt_Number.Text + "','" + com_Time.Text + "','" + txt_Duration.Text + "','"+txt_Note.Text+"')", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();

                MessageBox.Show("تم اضافه اسم الدواء بنجاح", "حفظ", MessageBoxButtons.OK);
                LoadData();
                //ClearData();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("الرجاء تحديد الصف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                cmd = new SqlCommand("update Tbl_NewPharma set Name='" + txt_Name.Text + "',Amount='" + txt_Amount.Text + "',Number='" + txt_Number.Text + "',Time='" + com_Time.Text + "',Duration='" + txt_Duration.Text + "',Note='" + txt_Note.Text + "'  where ID=" + txt_id.Text + " ", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();
                dt.Clear();
                LoadData();
                MessageBox.Show("تمت التعديل بنجاح", "التعديل", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("التاكد", "خطا", MessageBoxButtons.OK);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("الرجاء تحديد الصف", "خطا", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                if ((MessageBox.Show("هل تريد فعلا حذف هذا القيد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    cmd = new SqlCommand("delete from Tbl_NewPharma where ID=" + txt_id.Text + " ", DAL.sqlcon);
                    DAL.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    DAL.sqlcon.Close();
                    dt.Clear();
                    LoadData();
                    MessageBox.Show("تمت الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("تاكد من العملية", "خطا", MessageBoxButtons.OK);
                return;

            }
        }

        private void dgv2_Click(object sender, EventArgs e)
        {
           
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txt_Name.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txt_Amount.Text = gridView1.GetFocusedRowCellValue("Amount").ToString();
            txt_Number.Text = gridView1.GetFocusedRowCellValue("Number").ToString();
            com_Time.Text = gridView1.GetFocusedRowCellValue("Time").ToString();
            txt_Duration.Text = gridView1.GetFocusedRowCellValue("Duration").ToString();
            txt_Note.Text = gridView1.GetFocusedRowCellValue("Note").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMain frm=new FrmMain();  
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
