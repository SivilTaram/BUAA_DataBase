namespace DataBaseLogistic
{
    partial class MorInform
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
            this.OrderIdLabel = new MetroFramework.Controls.MetroLabel();
            this.ReceiveIdLabel = new MetroFramework.Controls.MetroLabel();
            this.CountLabel = new MetroFramework.Controls.MetroLabel();
            this.StateLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(23, 32);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(83, 20);
            this.OrderIdLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.OrderIdLabel.TabIndex = 0;
            this.OrderIdLabel.Text = " 订单编号：";
            this.OrderIdLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OrderIdLabel.UseStyleColors = true;
            // 
            // ReceiveIdLabel
            // 
            this.ReceiveIdLabel.AutoSize = true;
            this.ReceiveIdLabel.Location = new System.Drawing.Point(23, 76);
            this.ReceiveIdLabel.Name = "ReceiveIdLabel";
            this.ReceiveIdLabel.Size = new System.Drawing.Size(93, 20);
            this.ReceiveIdLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReceiveIdLabel.TabIndex = 1;
            this.ReceiveIdLabel.Text = "收货方账号：";
            this.ReceiveIdLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReceiveIdLabel.UseStyleColors = true;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(23, 123);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(79, 20);
            this.CountLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "订单金额：";
            this.CountLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountLabel.UseStyleColors = true;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(19, 166);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(83, 20);
            this.StateLabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.StateLabel.TabIndex = 5;
            this.StateLabel.Text = " 订单状态：";
            this.StateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StateLabel.UseStyleColors = true;
            // 
            // MorInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 215);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ReceiveIdLabel);
            this.Controls.Add(this.OrderIdLabel);
            this.Name = "MorInform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel OrderIdLabel;
        private MetroFramework.Controls.MetroLabel ReceiveIdLabel;
        private MetroFramework.Controls.MetroLabel CountLabel;
        private MetroFramework.Controls.MetroLabel StateLabel;
    }
}