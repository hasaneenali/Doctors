namespace Doctors
{
    partial class FrmLoadPharma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadPharma));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button3 = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Note = new DevExpress.XtraEditors.TextEdit();
            this.txt_Duration = new DevExpress.XtraEditors.TextEdit();
            this.com_Time = new System.Windows.Forms.ComboBox();
            this.txt_Number = new DevExpress.XtraEditors.TextEdit();
            this.txt_Amount = new DevExpress.XtraEditors.TextEdit();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Duration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(101, 93);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(23, 24);
            this.txt_id.TabIndex = 46;
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(227, 93);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(23, 24);
            this.txtLoad.TabIndex = 48;
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(542, 100);
            this.dgv.MainView = this.gridView1;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(977, 544);
            this.dgv.TabIndex = 50;
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
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_Note);
            this.groupControl1.Controls.Add(this.txt_Duration);
            this.groupControl1.Controls.Add(this.com_Time);
            this.groupControl1.Controls.Add(this.txt_Number);
            this.groupControl1.Controls.Add(this.txt_Amount);
            this.groupControl1.Controls.Add(this.txt_Name);
            this.groupControl1.Location = new System.Drawing.Point(12, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 544);
            this.groupControl1.TabIndex = 51;
            this.groupControl1.Text = "اضافه دواء جديد";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(5, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 307);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textEdit1);
            this.groupControl2.Controls.Add(this.btn_delete);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.txtLoad);
            this.groupControl2.Controls.Add(this.txt_id);
            this.groupControl2.Controls.Add(this.btn_update);
            this.groupControl2.Location = new System.Drawing.Point(5, 416);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(514, 123);
            this.groupControl2.TabIndex = 13;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(339, 95);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(16, 22);
            this.textEdit1.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(18, 40);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 49);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "الحذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(372, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "الاضافه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(191, 40);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 49);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "التحديث";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(396, 162);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "عدد الجرعات";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(373, 215);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(111, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "وقت تناول الدواء";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(415, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "مده العلاج";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(411, 320);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 18);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "الملاحظات";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(388, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "الكميه الجرعه";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(413, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "اسم الدواء";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(63, 317);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Note.Properties.Appearance.Options.UseFont = true;
            this.txt_Note.Size = new System.Drawing.Size(297, 28);
            this.txt_Note.TabIndex = 5;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(63, 264);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Duration.Properties.Appearance.Options.UseFont = true;
            this.txt_Duration.Size = new System.Drawing.Size(297, 28);
            this.txt_Duration.TabIndex = 4;
            // 
            // com_Time
            // 
            this.com_Time.Font = new System.Drawing.Font("Tahoma", 10F);
            this.com_Time.FormattingEnabled = true;
            this.com_Time.Items.AddRange(new object[] {
            "قبل الاكل",
            "اثناء الاكل",
            "بعدالاكل",
            "في اي وقت"});
            this.com_Time.Location = new System.Drawing.Point(63, 210);
            this.com_Time.Name = "com_Time";
            this.com_Time.Size = new System.Drawing.Size(297, 29);
            this.com_Time.TabIndex = 3;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(63, 157);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Number.Properties.Appearance.Options.UseFont = true;
            this.txt_Number.Size = new System.Drawing.Size(297, 28);
            this.txt_Number.TabIndex = 2;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(63, 104);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Amount.Properties.Appearance.Options.UseFont = true;
            this.txt_Amount.Size = new System.Drawing.Size(297, 28);
            this.txt_Amount.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(63, 51);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Name.Size = new System.Drawing.Size(297, 28);
            this.txt_Name.TabIndex = 0;
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
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.TabIndex = 53;
            // 
            // FrmLoadPharma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 713);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoadPharma";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoadPharma";
            this.Load += new System.EventHandler(this.FrmLoadPharma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Duration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txtLoad;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_update;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Note;
        private DevExpress.XtraEditors.TextEdit txt_Duration;
        private System.Windows.Forms.ComboBox com_Time;
        private DevExpress.XtraEditors.TextEdit txt_Number;
        private DevExpress.XtraEditors.TextEdit txt_Amount;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}