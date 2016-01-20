namespace DataBaseLogistic
{
    partial class ReceiveManager
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.WaitToConfrimDataGridView = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.CheckGridView = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitToConfrimDataGridView)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(508, 309);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.WaitToConfrimDataGridView);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(500, 266);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "待确认订单";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // WaitToConfrimDataGridView
            // 
            this.WaitToConfrimDataGridView.AllowUserToAddRows = false;
            this.WaitToConfrimDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WaitToConfrimDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.WaitToConfrimDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaitToConfrimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaitToConfrimDataGridView.Location = new System.Drawing.Point(9, 10);
            this.WaitToConfrimDataGridView.Name = "WaitToConfrimDataGridView";
            this.WaitToConfrimDataGridView.ReadOnly = true;
            this.WaitToConfrimDataGridView.RowTemplate.Height = 23;
            this.WaitToConfrimDataGridView.Size = new System.Drawing.Size(484, 249);
            this.WaitToConfrimDataGridView.TabIndex = 2;
            this.WaitToConfrimDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WaitToConfrimDataGridView_CellContentClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.CheckGridView);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(500, 266);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "已确认订单";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // CheckGridView
            // 
            this.CheckGridView.AllowUserToAddRows = false;
            this.CheckGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CheckGridView.BackgroundColor = System.Drawing.Color.White;
            this.CheckGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckGridView.Location = new System.Drawing.Point(8, 9);
            this.CheckGridView.Name = "CheckGridView";
            this.CheckGridView.ReadOnly = true;
            this.CheckGridView.RowTemplate.Height = 23;
            this.CheckGridView.Size = new System.Drawing.Size(484, 249);
            this.CheckGridView.TabIndex = 3;
            this.CheckGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckGridView_CellContentClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(200, 373);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(129, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "刷新";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ReceiveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "ReceiveManager";
            this.Text = "欢迎回来";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaitToConfrimDataGridView)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView WaitToConfrimDataGridView;
        private System.Windows.Forms.DataGridView CheckGridView;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}