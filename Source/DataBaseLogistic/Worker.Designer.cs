namespace DataBaseLogistic
{
    partial class Worker
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.pwdText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.occupText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.confirmButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nativeText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.phoneText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.genderText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.birthText = new System.Windows.Forms.DateTimePicker();
            this.adminText = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.MintCream;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(111, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 24);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "员工";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(23, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "员工姓名";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // nameText
            // 
            this.nameText.Lines = new string[0];
            this.nameText.Location = new System.Drawing.Point(111, 68);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.Size = new System.Drawing.Size(117, 23);
            this.nameText.TabIndex = 2;
            this.nameText.UseSelectable = true;
            // 
            // pwdText
            // 
            this.pwdText.Lines = new string[0];
            this.pwdText.Location = new System.Drawing.Point(111, 117);
            this.pwdText.MaxLength = 32767;
            this.pwdText.Name = "pwdText";
            this.pwdText.PasswordChar = '\0';
            this.pwdText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdText.SelectedText = "";
            this.pwdText.Size = new System.Drawing.Size(117, 23);
            this.pwdText.TabIndex = 4;
            this.pwdText.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(23, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "员工密码";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // occupText
            // 
            this.occupText.Lines = new string[0];
            this.occupText.Location = new System.Drawing.Point(111, 169);
            this.occupText.MaxLength = 32767;
            this.occupText.Name = "occupText";
            this.occupText.PasswordChar = '\0';
            this.occupText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.occupText.SelectedText = "";
            this.occupText.Size = new System.Drawing.Size(117, 23);
            this.occupText.TabIndex = 8;
            this.occupText.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel5.Location = new System.Drawing.Point(23, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 20);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "员工职务";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(79, 480);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(123, 41);
            this.confirmButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "确定";
            this.confirmButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmButton.UseCustomBackColor = true;
            this.confirmButton.UseSelectable = true;
            this.confirmButton.UseStyleColors = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(23, 230);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "出生日期";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // nativeText
            // 
            this.nativeText.Lines = new string[0];
            this.nativeText.Location = new System.Drawing.Point(111, 278);
            this.nativeText.MaxLength = 32767;
            this.nativeText.Name = "nativeText";
            this.nativeText.PasswordChar = '\0';
            this.nativeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nativeText.SelectedText = "";
            this.nativeText.Size = new System.Drawing.Size(117, 23);
            this.nativeText.TabIndex = 13;
            this.nativeText.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel6.Location = new System.Drawing.Point(23, 281);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 20);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "员工籍贯";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // phoneText
            // 
            this.phoneText.Lines = new string[0];
            this.phoneText.Location = new System.Drawing.Point(111, 328);
            this.phoneText.MaxLength = 32767;
            this.phoneText.Name = "phoneText";
            this.phoneText.PasswordChar = '\0';
            this.phoneText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneText.SelectedText = "";
            this.phoneText.Size = new System.Drawing.Size(117, 23);
            this.phoneText.TabIndex = 15;
            this.phoneText.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel7.Location = new System.Drawing.Point(23, 331);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 20);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "员工电话";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel8.Location = new System.Drawing.Point(23, 381);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 20);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "工作时间";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // genderText
            // 
            this.genderText.Lines = new string[0];
            this.genderText.Location = new System.Drawing.Point(111, 422);
            this.genderText.MaxLength = 32767;
            this.genderText.Name = "genderText";
            this.genderText.PasswordChar = '\0';
            this.genderText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderText.SelectedText = "";
            this.genderText.Size = new System.Drawing.Size(117, 23);
            this.genderText.TabIndex = 19;
            this.genderText.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel9.Location = new System.Drawing.Point(23, 425);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 20);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "员工性别";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // birthText
            // 
            this.birthText.Location = new System.Drawing.Point(111, 229);
            this.birthText.Name = "birthText";
            this.birthText.Size = new System.Drawing.Size(117, 21);
            this.birthText.TabIndex = 20;
            this.birthText.Value = new System.DateTime(2015, 2, 4, 0, 0, 0, 0);
            // 
            // adminText
            // 
            this.adminText.Location = new System.Drawing.Point(111, 380);
            this.adminText.Name = "adminText";
            this.adminText.Size = new System.Drawing.Size(117, 21);
            this.adminText.TabIndex = 21;
            this.adminText.Value = new System.DateTime(2015, 2, 4, 0, 0, 0, 0);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 534);
            this.Controls.Add(this.adminText);
            this.Controls.Add(this.birthText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.nativeText);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.occupText);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Worker";
            this.Load += new System.EventHandler(this.Worker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroTextBox pwdText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox occupText;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton confirmButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox nativeText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox phoneText;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox genderText;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker birthText;
        private System.Windows.Forms.DateTimePicker adminText;
    }
}