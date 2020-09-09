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
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        SqlDataAdapter da;
        SqlCommand cmd, cmd2;
        DataTable dt = new DataTable();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter("select * from TBL_USERS where ID ='" + txtID.Text + "' and PWD='" + txtPWD.Text + "'  ", DAL.sqlcon);
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][4].ToString() == "مدير")
                    {
                        FrmMain frm = new FrmMain();
                        frm.label4.Enabled = true;
                        frm.label3.Enabled = true;
                        frm.label7.Enabled = true;
                        frm.label13.Enabled = true;
                        frm.label11.Enabled = true;
                        frm.label9.Enabled = true;

                        frm.Btn_seeting.Enabled = true;
                        frm.button6.Enabled = true;
                        frm.button7.Enabled = true;
                        frm.button8.Enabled = true;
                        frm.button9.Enabled = true;
                        frm.button10.Enabled = true;
                        frm.button11.Enabled = true;
                        frm.Show();
                    }

                    else if (dt.Rows[0][4].ToString() == "مستخدم")
                    {
                        FrmMain frm = new FrmMain();
                       
                        frm.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Login failed !");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("الرجاء اعادة البحث من جديد", "البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}