using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Doctors
{
    public partial class FrmSecretary : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        //DAL.sqlconnection DAL.sqlcon = new DAL.sqlconnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        SqlDataAdapter da;
        SqlCommand cmd,cmd2;
        string s;
        DataTable dt = new DataTable();
        public FrmSecretary()
        {
           InitializeComponent();
           LoadData();
        }


        void LoadData()
        {
            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select * from Tbl_Patients", DAL.sqlcon);
                da.Fill(dt);
                dgv.DataSource = dt;
                //dgv.Columns[0].Visible = false;
                //dgv.Columns[1].HeaderText = "اسم المريض";
                //dgv.Columns[2].HeaderText = "العنوان";
                //dgv.Columns[3].HeaderText = "رقم الموبايل";
                //dgv.Columns[4].HeaderText = "عمر المريض";
                //dgv.Columns[5].HeaderText = "جنس المريض";
                //dgv.Columns[6].Visible = false;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "اسم المريض";
                gridView1.Columns[2].Caption = "العنوان";
                gridView1.Columns[3].Caption = "رقم الموبايل";
                gridView1.Columns[4].Caption = "عمر المريضء";
                gridView1.Columns[5].Caption = "مده العلاج";
                gridView1.Columns[6].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmSecretary_Load(object sender, EventArgs e)
        {
            ch_male.Checked = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (ch_male.Checked)
                {
                    s = ch_male.Text;
                }

                if (ch_fmale.Checked)
                {
                    s = ch_fmale.Text;
                }

                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك الاسم فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txt_adress.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك العنوان فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txt_mobile.Text))
                {
                    MessageBox.Show("الرجاء عدم ترك رقم الموبايل فارغ", "خطا", MessageBoxButtons.OK);
                    return;
                }

                int d = 0;


                if (txt_IDReservation.Text=="")
                {
                    cmd = new SqlCommand("insert into Tbl_Patients(Name,Adress,Mobile,Age,Sex,check_Patients) values('" + txt_name.Text + "','" + txt_adress.Text + "','" + txt_mobile.Text + "','" + txt_age.Text + "','" + s + "','" + d + "')", DAL.sqlcon);
                    DAL.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    DAL.sqlcon.Close();
                }

                else
                {
                    cmd = new SqlCommand("insert into Tbl_Patients(Name,Adress,Mobile,Age,Sex,check_Patients) values('" + txt_name.Text + "','" + txt_adress.Text + "','" + txt_mobile.Text + "','" + txt_age.Text + "','" + s + "','" + d + "')", DAL.sqlcon);
                    cmd2 = new SqlCommand("delete from Tbl_Reservation where ID='" + txt_IDReservation.Text + "' ", DAL.sqlcon);
                    DAL.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    DAL.sqlcon.Close();

                }
              

              

                MessageBox.Show("تم اضافه اسم المريض بنجاح", "حفظ", MessageBoxButtons.OK);
                 LoadData();
                ClearData();
            }
            catch (Exception)
            {

                throw;
            }
        }


        void ClearData()
        {
            txt_name.Clear();
            txt_adress.Clear();
            txt_mobile.Clear();
            txt_age.Clear();
            ch_male.Checked = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ch_male.Checked)
                {
                    s = ch_male.Text;
                }

                if (ch_fmale.Checked)
                {
                    s = ch_fmale.Text;
                }
                cmd = new SqlCommand("update Tbl_Patients set Name='" + txt_name.Text + "',Adress='" + txt_adress.Text + "',Mobile='" + txt_mobile.Text + "',Age='" + txt_age.Text + "',Sex='" + s + "'  where ID_Patient=" + txt_id.Text + " ", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();
                dt.Clear();
                LoadData();
                MessageBox.Show("تمت التعديل بنجاح", "التعديل", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("التاكد", "خطا", MessageBoxButtons.OK);
            }
        }

        private void ch_fmale_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_fmale.Checked)
            {
                ch_male.Checked = false;
            }
        }

        private void ch_male_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_male.Checked)
            {
                ch_fmale.Checked = false;
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //private void dgv_Click(object sender, EventArgs e)
        //{
        //    txt_id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        //    txt_name.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        //    txt_adress.Text = dgv.CurrentRow.Cells[2].Value.ToString();
        //    txt_mobile.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        //    txt_age.Text = dgv.CurrentRow.Cells[4].Value.ToString();

        //    if (dgv.CurrentRow.Cells[5].Value.ToString() == "ذكر")
        //    {
        //        ch_male.Checked = true;

        //    }

        //    else
        //    {
        //        ch_fmale.Checked = true;
        //    }
        //}

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("الرجاء تحديد الصف", "خطا", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if ((MessageBox.Show("هل تريد فعلا حذف هذا القيد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    cmd = new SqlCommand("delete  from Tbl_Patients where ID_Patient='" + txt_id.Text + "' ", DAL.sqlcon);
                    DAL.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    DAL.sqlcon.Close();
                    dt.Clear();
                    LoadData();
                    MessageBox.Show("تمت الحذف بنجاح", "الحذف", MessageBoxButtons.OK);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("تاكد من العملية", "خطا", MessageBoxButtons.OK);
                return;

            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                FrmAllResevation frm = new FrmAllResevation();
                frm.ShowDialog();

                if (frm.dgv.CurrentRow !=null)
                {
                    txt_IDReservation.Text = frm.dgv.CurrentRow.Cells[0].Value.ToString();
                    txt_name.Text = frm.dgv.CurrentRow.Cells[2].Value.ToString();
                   
                }

                else
                {
                    txt_IDReservation.Text = "";
                    txt_name.Text = "";
                }
               
            }
            catch (Exception exception)
            {
                MessageBox.Show("لايوجد بينات للعرض", "بيانات");
            }
           
           
           
          
        }
    }
}
