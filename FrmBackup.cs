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
using DevExpress.XtraEditors;

namespace Doctors
{
    public partial class FrmBackup : XtraForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=master;Trusted_Connection=True");
        SqlCommand cmd;
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //انشاء نسخه مع الوقت والتاريخ
            string fileName = txtFileName.Text + "\\Doctor" + DateTime.Now.ToShortDateString().Replace('/', '-')
                            + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string strQuery = "Backup Database Doctor to Disk='" + fileName + ".bak'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            //غلق قاعد اللبيانات ALTER Database Doctor SET OFFLINE WITH ROLLBACK IMMEDIATE

            string strQuery = "ALTER Database Doctor SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Doctor From Disk='" + txtFileName2.Text + "'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName2.Text = openFileDialog1.FileName;
            }
        }

        private void l_Click(object sender, EventArgs e)
        {

        }
    }
}
