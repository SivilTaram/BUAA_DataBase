namespace DataBaseLogistic
{
    partial class WareHouseManager
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
            this.components = new System.ComponentModel.Container();
            this.WHdataGridView = new System.Windows.Forms.DataGridView();
            this.DataTimer = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.WHdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WHdataGridView
            // 
            this.WHdataGridView.AllowUserToAddRows = false;
            this.WHdataGridView.AllowUserToDeleteRows = false;
            this.WHdataGridView.AllowUserToResizeColumns = false;
            this.WHdataGridView.AllowUserToResizeRows = false;
            this.WHdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WHdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.WHdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WHdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WHdataGridView.GridColor = System.Drawing.SystemColors.GrayText;
            this.WHdataGridView.Location = new System.Drawing.Point(34, 63);
            this.WHdataGridView.Name = "WHdataGridView";
            this.WHdataGridView.ReadOnly = true;
            this.WHdataGridView.RowTemplate.Height = 23;
            this.WHdataGridView.Size = new System.Drawing.Size(508, 185);
            this.WHdataGridView.TabIndex = 0;
            this.WHdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WHdataGridView_CellContentClick);
            // 
            // DataTimer
            // 
            this.DataTimer.Enabled = true;
            this.DataTimer.Interval = 1000;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(230, 259);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(129, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "刷新";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // WareHouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 315);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.WHdataGridView);
            this.Name = "WareHouseManager";
            this.Text = "欢迎回来";
            ((System.ComponentModel.ISupportInitialize)(this.WHdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WHdataGridView;
        private System.Windows.Forms.Timer DataTimer;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}