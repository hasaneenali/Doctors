using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            FRMCONFIG frm = new FRMCONFIG();
            frm.ShowDialog();
           
        }

        private void Btn_seeting_Click(object sender, EventArgs e)
        {
            FRMCONFIG frm = new FRMCONFIG();
            frm.ShowDialog();
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            FrmSecretary frm = new FrmSecretary();
            frm.Show();
            this.Hide();
          

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmReservation frm = new FrmReservation();
            frm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FrmPharma frm = new FrmPharma();
            frm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FrmDoctro frm = new FrmDoctro();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_USERS_LIST frm = new FRM_USERS_LIST();
            frm.ShowDialog();
        }
    }
}
