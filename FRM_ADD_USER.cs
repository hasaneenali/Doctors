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
    public partial class FRM_ADD_USER : DevExpress.XtraEditors.XtraForm
    {
        DataAccessLayer DAL = new DataAccessLayer();
        SqlDataAdapter da;
        SqlCommand cmd,cmd2;
        DataTable dt = new DataTable();
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void FRM_ADD_USER_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtID.Text == string.Empty || txtPWD.Text == string.Empty
                || txtFullName.Text == string.Empty || txtPWDConfirm.Text == string.Empty)
                {
                    MessageBox.Show("رجاء أدخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPWD.Text != txtPWDConfirm.Text)
                {
                    MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbType.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاء اختيار  نوع المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                if (btnSave.Text== "حفظ المستخدم")
                {
                    cmd = new SqlCommand("insert into TBL_USERS(ID,PWD,UserType,FullName) values('" + txtID.Text + "','" + txtPWD.Text + "','" + cmbType.Text + "','" + txtFullName.Text + "')",DAL.sqlcon);
                    DAL.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                   DAL.sqlcon.Close();
                    MessageBox.Show("تم اضافه اسم المستخدم بنجاح", "حفظ", MessageBoxButtons.OK);
                }

                else if (btnSave.Text == "تعديل المستخدم")
                {
                    cmd2 = new SqlCommand("update TBL_USERS set ID='" + txtID.Text + "',PWD='" + txtPWD.Text + "',UserType='" + cmbType.Text + "',FullName='" + txtFullName.Text + "' where ID_Key='"+txtId_Key.Text+"'  ",DAL.sqlcon);
                   DAL.sqlcon.Open();
                    cmd2.ExecuteNonQuery();
                   DAL.sqlcon.Close();
                    MessageBox.Show("تم تعديل اسم المستخدم بنجاح", "تعديل", MessageBoxButtons.OK);
                }
               
               
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}