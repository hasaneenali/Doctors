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
    public partial class FrmDoctro : XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
      
        SqlDataAdapter da;
        SqlCommand cmd;
        string s;
        DataTable dt = new DataTable();
        public FrmDoctro()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                FrmLoadSecretary frm = new FrmLoadSecretary();
                frm.ShowDialog();
                if (frm.dgv.CurrentRow != null)
                {


                    txtid.Text = frm.dgv.CurrentRow.Cells[0].Value.ToString();
                    txt_name.Text = frm.dgv.CurrentRow.Cells[1].Value.ToString();
                    txt_adress.Text = frm.dgv.CurrentRow.Cells[2].Value.ToString();
                    txt_mobile.Text = frm.dgv.CurrentRow.Cells[3].Value.ToString();
                    txt_age.Text = frm.dgv.CurrentRow.Cells[4].Value.ToString();
                    txt_sex.Text = frm.dgv.CurrentRow.Cells[5].Value.ToString();

                    bool IsChecked = (bool)frm.dgv.CurrentRow.Cells[6].Value;
                    if (IsChecked == true)
                    {


                        label4.Enabled = true;
                        label3.Enabled = true;
                        label13.Enabled = true;
                        label11.Enabled = true;
                        check_Patients.Checked = true;
                    }

                    else
                    {
                        label4.Enabled = false;
                        label3.Enabled = false;
                        label13.Enabled = false;
                        label11.Enabled = false;
                        check_Patients.Checked = true;
                        check_Patients.Checked = false;
                    }

                }


                else
                {
                    txtid.Text = "";
                    txt_name.Text = "";
                    txt_adress.Text = "";
                    txt_mobile.Text = "";
                    txt_age.Text = "";
                    txt_sex.Text = "";

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
            FrmLoadPharma frm = new FrmLoadPharma(txtid.Text);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTest frm = new FrmTest(txtid.Text);
            frm.ShowDialog();
        }

       


        

        private void FrmDoctro_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_Patients.Checked == false)
                {
                    MessageBox.Show("الرجاء اجراء الفحص", "الفحص", MessageBoxButtons.OK);
                    return;
                }


                cmd = new SqlCommand("update Tbl_Patients set Name='" + txt_name.Text + "',Adress='" + txt_adress.Text + "',Mobile='" + txt_mobile.Text + "',Age='" + txt_age.Text + "',Sex='" + txt_sex.Text + "',check_Patients='" + check_Patients.Checked + "'  where ID_Patient=" + txtid.Text + " ", DAL.sqlcon);
                DAL.sqlcon.Open();
                cmd.ExecuteNonQuery();
                DAL.sqlcon.Close();
                dt.Clear();
               MessageBox.Show("تمت التعديل بنجاح", "التعديل", MessageBoxButtons.OK);

                //button3.Enabled = true;
                //button5.Enabled = true;
                //btn_CradReport.Enabled = true;
                //button4.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("التاكد", "خطا", MessageBoxButtons.OK);
            }
        }

        private void FrmDoctro_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDiagnosis frm = new FrmDiagnosis(txtid.Text);
            frm.ShowDialog();
        }

      

        public DataTable GetOrderDetails(int Id)
        {
           
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;


            Dt = DAL.SelectData("CardReport3", param);
            DAL.Close();
            return Dt;
        }
        private void btn_CradReport_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmLoadPharma frm = new FrmLoadPharma(txtid.Text);
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmTest frm = new FrmTest(txtid.Text);
            frm.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FrmDiagnosis frm = new FrmDiagnosis(txtid.Text);
            frm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Rpt_Card report = new Rpt_Card();
            FrmReport frm = new FrmReport();
            int Id = Convert.ToInt32(txtid.Text);
            report.SetDataSource(GetOrderDetails(Id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
          

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }
    }
}
