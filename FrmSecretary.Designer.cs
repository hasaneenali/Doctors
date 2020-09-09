namespace Doctors
{
    partial class FrmSecretary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretary));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.ch_male = new System.Windows.Forms.CheckBox();
            this.ch_fmale = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_IDReservation = new System.Windows.Forms.TextBox();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(388, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "جنس المريض";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_name.Location = new System.Drawing.Point(63, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(297, 28);
            this.txt_name.TabIndex = 4;
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_adress.Location = new System.Drawing.Point(63, 160);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(297, 28);
            this.txt_adress.TabIndex = 5;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_mobile.Location = new System.Drawing.Point(63, 209);
            this.txt_mobile.MaxLength = 11;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(297, 28);
            this.txt_mobile.TabIndex = 6;
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_KeyPress);
            // 
            // ch_male
            // 
            this.ch_male.AutoSize = true;
            this.ch_male.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ch_male.Location = new System.Drawing.Point(305, 329);
            this.ch_male.Name = "ch_male";
            this.ch_male.Size = new System.Drawing.Size(55, 25);
            this.ch_male.TabIndex = 9;
            this.ch_male.Text = "ذكر";
            this.ch_male.UseVisualStyleBackColor = true;
            this.ch_male.CheckedChanged += new System.EventHandler(this.ch_male_CheckedChanged);
            // 
            // ch_fmale
            // 
            this.ch_fmale.AutoSize = true;
            this.ch_fmale.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ch_fmale.Location = new System.Drawing.Point(171, 329);
            this.ch_fmale.Name = "ch_fmale";
            this.ch_fmale.Size = new System.Drawing.Size(64, 25);
            this.ch_fmale.TabIndex = 10;
            this.ch_fmale.Text = "انثى";
            this.ch_fmale.UseVisualStyleBackColor = true;
            this.ch_fmale.CheckedChanged += new System.EventHandler(this.ch_fmale_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(363, 46);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 53);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(199, 49);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 53);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "تحديث";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(35, 49);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 53);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_age.Location = new System.Drawing.Point(63, 265);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(297, 28);
            this.txt_age.TabIndex = 15;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(33, 386);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(13, 24);
            this.txt_id.TabIndex = 16;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(5, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 193);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_IDReservation
            // 
            this.txt_IDReservation.Location = new System.Drawing.Point(5, 386);
            this.txt_IDReservation.Name = "txt_IDReservation";
            this.txt_IDReservation.Size = new System.Drawing.Size(13, 24);
            this.txt_IDReservation.TabIndex = 18;
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(542, 97);
            this.dgv.MainView = this.gridView1;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(984, 544);
            this.dgv.TabIndex = 19;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.Row.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.gridView1.AppearancePrint.Row.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.txt_name);
            this.groupControl3.Controls.Add(this.txt_id);
            this.groupControl3.Controls.Add(this.txt_IDReservation);
            this.groupControl3.Controls.Add(this.txt_adress);
            this.groupControl3.Controls.Add(this.button1);
            this.groupControl3.Controls.Add(this.txt_mobile);
            this.groupControl3.Controls.Add(this.txt_age);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.ch_male);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.ch_fmale);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(12, 97);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(524, 544);
            this.groupControl3.TabIndex = 21;
            this.groupControl3.Text = "اضافه دواء جديد";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btn_delete);
            this.groupControl4.Controls.Add(this.btn_update);
            this.groupControl4.Controls.Add(this.btn_add);
            this.groupControl4.Location = new System.Drawing.Point(5, 416);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(514, 123);
            this.groupControl4.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(411, 214);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "العدد";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(411, 270);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "الوقت";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(402, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "الكميه";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(388, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "اسم الدواء";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1856, 58);
            this.panel1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(661, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "برنامج عيادتي";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1856, 58);
            this.panel2.TabIndex = 23;
            // 
            // FrmSecretary
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 713);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSecretary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.CheckBox ch_male;
        private System.Windows.Forms.CheckBox ch_fmale;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_IDReservation;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

