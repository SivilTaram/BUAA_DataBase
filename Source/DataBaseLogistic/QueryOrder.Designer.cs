namespace DataBaseLogistic
{
    partial class QueryOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryOrder));
            this.QueryOrderTab = new MetroFramework.Controls.MetroTabControl();
            this.MyOrder = new MetroFramework.Controls.MetroTabPage();
            this.BackOrderButton = new MetroFramework.Controls.MetroTile();
            this.UpdateTimeLabel = new MetroFramework.Controls.MetroLink();
            this.NumberLabel = new MetroFramework.Controls.MetroLabel();
            this.MoreInformLink = new MetroFramework.Controls.MetroLink();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeliverPic = new System.Windows.Forms.PictureBox();
            this.DTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.QueryOrderTab.SuspendLayout();
            this.MyOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryOrderTab
            // 
            this.QueryOrderTab.Controls.Add(this.MyOrder);
            this.QueryOrderTab.Location = new System.Drawing.Point(9, 56);
            this.QueryOrderTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QueryOrderTab.Name = "QueryOrderTab";
            this.QueryOrderTab.SelectedIndex = 0;
            this.QueryOrderTab.Size = new System.Drawing.Size(683, 339);
            this.QueryOrderTab.TabIndex = 0;
            this.QueryOrderTab.UseSelectable = true;
            // 
            // MyOrder
            // 
            this.MyOrder.Controls.Add(this.BackOrderButton);
            this.MyOrder.Controls.Add(this.UpdateTimeLabel);
            this.MyOrder.Controls.Add(this.NumberLabel);
            this.MyOrder.Controls.Add(this.MoreInformLink);
            this.MyOrder.Controls.Add(this.pictureBox6);
            this.MyOrder.Controls.Add(this.pictureBox5);
            this.MyOrder.Controls.Add(this.pictureBox4);
            this.MyOrder.Controls.Add(this.pictureBox3);
            this.MyOrder.Controls.Add(this.pictureBox2);
            this.MyOrder.Controls.Add(this.pictureBox1);
            this.MyOrder.Controls.Add(this.DeliverPic);
            this.MyOrder.Controls.Add(this.DTrackBar);
            this.MyOrder.HorizontalScrollbarBarColor = true;
            this.MyOrder.HorizontalScrollbarHighlightOnWheel = false;
            this.MyOrder.HorizontalScrollbarSize = 1;
            this.MyOrder.Location = new System.Drawing.Point(4, 39);
            this.MyOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyOrder.Name = "MyOrder";
            this.MyOrder.Size = new System.Drawing.Size(675, 296);
            this.MyOrder.TabIndex = 0;
            this.MyOrder.Text = "我下的订单";
            this.MyOrder.VerticalScrollbarBarColor = true;
            this.MyOrder.VerticalScrollbarHighlightOnWheel = false;
            this.MyOrder.VerticalScrollbarSize = 2;
            this.MyOrder.Click += new System.EventHandler(this.MyOrder_Click);
            // 
            // BackOrderButton
            // 
            this.BackOrderButton.ActiveControl = null;
            this.BackOrderButton.Location = new System.Drawing.Point(71, 219);
            this.BackOrderButton.Name = "BackOrderButton";
            this.BackOrderButton.Size = new System.Drawing.Size(76, 21);
            this.BackOrderButton.Style = MetroFramework.MetroColorStyle.Red;
            this.BackOrderButton.TabIndex = 14;
            this.BackOrderButton.Text = "撤销订单";
            this.BackOrderButton.UseSelectable = true;
            this.BackOrderButton.Click += new System.EventHandler(this.BackOrderButton_Click);
            // 
            // UpdateTimeLabel
            // 
            this.UpdateTimeLabel.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.UpdateTimeLabel.Location = new System.Drawing.Point(164, 247);
            this.UpdateTimeLabel.Name = "UpdateTimeLabel";
            this.UpdateTimeLabel.Size = new System.Drawing.Size(336, 46);
            this.UpdateTimeLabel.TabIndex = 13;
            this.UpdateTimeLabel.Text = "订单最近更新时间：";
            this.UpdateTimeLabel.UseSelectable = true;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(125, 47);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(79, 20);
            this.NumberLabel.TabIndex = 12;
            this.NumberLabel.Text = "订单编号：";
            // 
            // MoreInformLink
            // 
            this.MoreInformLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.MoreInformLink.Location = new System.Drawing.Point(414, 40);
            this.MoreInformLink.Name = "MoreInformLink";
            this.MoreInformLink.Size = new System.Drawing.Size(172, 33);
            this.MoreInformLink.TabIndex = 11;
            this.MoreInformLink.Text = "点我查看订单详细信息";
            this.MoreInformLink.UseSelectable = true;
            this.MoreInformLink.UseStyleColors = true;
            this.MoreInformLink.Click += new System.EventHandler(this.MoreInformLink_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 59);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox6, "上一个");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(607, 101);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 59);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox5, "下一个");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(353, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 53);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox4, "入库完毕，等待配送");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(251, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 54);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox3, "取货完毕，等待入库");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 46);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox2, "订单确认，等待取货中");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 53);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox1, "成功下单，等待确认");
            // 
            // DeliverPic
            // 
            this.DeliverPic.BackColor = System.Drawing.Color.Transparent;
            this.DeliverPic.Image = ((System.Drawing.Image)(resources.GetObject("DeliverPic.Image")));
            this.DeliverPic.Location = new System.Drawing.Point(477, 150);
            this.DeliverPic.Name = "DeliverPic";
            this.DeliverPic.Size = new System.Drawing.Size(70, 46);
            this.DeliverPic.TabIndex = 4;
            this.DeliverPic.TabStop = false;
            this.metroToolTip1.SetToolTip(this.DeliverPic, "配送中，等待送达");
            // 
            // DTrackBar
            // 
            this.DTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.DTrackBar.Enabled = false;
            this.DTrackBar.Location = new System.Drawing.Point(103, 79);
            this.DTrackBar.Maximum = 50;
            this.DTrackBar.Name = "DTrackBar";
            this.DTrackBar.Size = new System.Drawing.Size(473, 59);
            this.DTrackBar.TabIndex = 2;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // QueryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 401);
            this.Controls.Add(this.QueryOrderTab);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryOrder";
            this.Padding = new System.Windows.Forms.Padding(27, 100, 27, 33);
            this.Text = "订单管理";
            this.QueryOrderTab.ResumeLayout(false);
            this.MyOrder.ResumeLayout(false);
            this.MyOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl QueryOrderTab;
        private MetroFramework.Controls.MetroTabPage MyOrder;
        private MetroFramework.Controls.MetroTrackBar DTrackBar;
        private System.Windows.Forms.PictureBox DeliverPic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink MoreInformLink;
        private MetroFramework.Controls.MetroLink UpdateTimeLabel;
        private MetroFramework.Controls.MetroLabel NumberLabel;
        private MetroFramework.Controls.MetroTile BackOrderButton;
    }
}