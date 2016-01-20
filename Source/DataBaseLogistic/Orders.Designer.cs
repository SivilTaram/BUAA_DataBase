namespace DataBaseLogistic
{
    partial class Orders
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cargoTypeText = new MetroFramework.Controls.MetroComboBox();
            this.weightText = new MetroFramework.Controls.MetroTextBox();
            this.receiverText = new MetroFramework.Controls.MetroTextBox();
            this.volumeText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.confirmButton = new MetroFramework.Controls.MetroTile();
            this.moneyLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(116, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 24);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "订单";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "货物类型";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "货物体积";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "货物重量";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 264);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "收货方账号";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(118, 191);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 5;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(34, 309);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 20);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "金额";
            // 
            // cargoTypeText
            // 
            this.cargoTypeText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cargoTypeText.FormattingEnabled = true;
            this.cargoTypeText.ItemHeight = 24;
            this.cargoTypeText.Items.AddRange(new object[] {
            "普通货物",
            "易碎货物",
            ""});
            this.cargoTypeText.Location = new System.Drawing.Point(116, 68);
            this.cargoTypeText.Name = "cargoTypeText";
            this.cargoTypeText.Size = new System.Drawing.Size(121, 30);
            this.cargoTypeText.TabIndex = 7;
            this.cargoTypeText.UseSelectable = true;
            this.cargoTypeText.UseStyleColors = true;
            // 
            // weightText
            // 
            this.weightText.Lines = new string[0];
            this.weightText.Location = new System.Drawing.Point(116, 168);
            this.weightText.MaxLength = 32767;
            this.weightText.Name = "weightText";
            this.weightText.PasswordChar = '\0';
            this.weightText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.weightText.SelectedText = "";
            this.weightText.Size = new System.Drawing.Size(121, 23);
            this.weightText.TabIndex = 9;
            this.weightText.UseSelectable = true;
            this.weightText.UseStyleColors = true;
            // 
            // receiverText
            // 
            this.receiverText.Lines = new string[0];
            this.receiverText.Location = new System.Drawing.Point(116, 261);
            this.receiverText.MaxLength = 32767;
            this.receiverText.Name = "receiverText";
            this.receiverText.PasswordChar = '\0';
            this.receiverText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receiverText.SelectedText = "";
            this.receiverText.Size = new System.Drawing.Size(121, 23);
            this.receiverText.TabIndex = 10;
            this.receiverText.UseSelectable = true;
            this.receiverText.UseStyleColors = true;
            // 
            // volumeText
            // 
            this.volumeText.Lines = new string[0];
            this.volumeText.Location = new System.Drawing.Point(116, 123);
            this.volumeText.MaxLength = 32767;
            this.volumeText.Name = "volumeText";
            this.volumeText.PasswordChar = '\0';
            this.volumeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.volumeText.SelectedText = "";
            this.volumeText.Size = new System.Drawing.Size(121, 23);
            this.volumeText.TabIndex = 12;
            this.volumeText.UseSelectable = true;
            this.volumeText.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 218);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 20);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "货物名称";
            // 
            // nameText
            // 
            this.nameText.Lines = new string[0];
            this.nameText.Location = new System.Drawing.Point(116, 215);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.Size = new System.Drawing.Size(121, 23);
            this.nameText.TabIndex = 14;
            this.nameText.UseSelectable = true;
            this.nameText.UseStyleColors = true;
            // 
            // confirmButton
            // 
            this.confirmButton.ActiveControl = null;
            this.confirmButton.Location = new System.Drawing.Point(131, 350);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 33);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "确认";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmButton.UseSelectable = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(131, 309);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(93, 20);
            this.moneyLabel.TabIndex = 16;
            this.moneyLabel.Text = "metroLabel9";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 406);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.volumeText);
            this.Controls.Add(this.receiverText);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.cargoTypeText);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cargoTypeText;
        private MetroFramework.Controls.MetroTextBox weightText;
        private MetroFramework.Controls.MetroTextBox receiverText;
        private MetroFramework.Controls.MetroTextBox volumeText;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroTile confirmButton;
        private MetroFramework.Controls.MetroLabel moneyLabel;


    }
}