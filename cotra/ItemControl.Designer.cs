namespace cotra
{
    partial class ItemControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.proEnable = new System.Windows.Forms.CheckBox();
            this.proname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exportURL = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.When = new System.Windows.Forms.Label();
            this.UA = new System.Windows.Forms.Label();
            this.InURL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AttachedCookieL = new System.Windows.Forms.Label();
            this.AttachedCookie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CookieHostL = new System.Windows.Forms.Label();
            this.CookieHost = new System.Windows.Forms.Label();
            this.cookiesL = new System.Windows.Forms.Label();
            this.RequestCookies = new System.Windows.Forms.Label();
            this.interceptedCookie = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // proEnable
            // 
            this.proEnable.AutoSize = true;
            this.proEnable.Location = new System.Drawing.Point(3, 3);
            this.proEnable.Name = "proEnable";
            this.proEnable.Size = new System.Drawing.Size(66, 16);
            this.proEnable.TabIndex = 1;
            this.proEnable.Text = "Enabled";
            this.proEnable.UseVisualStyleBackColor = true;
            this.proEnable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // proname
            // 
            this.proname.AutoSize = true;
            this.proname.Location = new System.Drawing.Point(40, 4);
            this.proname.Name = "proname";
            this.proname.Size = new System.Drawing.Size(47, 12);
            this.proname.TabIndex = 2;
            this.proname.Text = "proname";
            this.proname.Click += new System.EventHandler(this.proname_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(-2, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(-2, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Response URLMatch:";
            // 
            // exportURL
            // 
            this.exportURL.BackColor = System.Drawing.SystemColors.Window;
            this.exportURL.CheckOnClick = true;
            this.exportURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportURL.FormattingEnabled = true;
            this.exportURL.Location = new System.Drawing.Point(83, 118);
            this.exportURL.Name = "exportURL";
            this.exportURL.Size = new System.Drawing.Size(584, 74);
            this.exportURL.TabIndex = 6;
            this.exportURL.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.exportURL_ItemCheck);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.exportURL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.proEnable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 195);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.RequestCookies);
            this.panel1.Controls.Add(this.cookiesL);
            this.panel1.Controls.Add(this.interceptedCookie);
            this.panel1.Controls.Add(this.CookieHost);
            this.panel1.Controls.Add(this.CookieHostL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AttachedCookie);
            this.panel1.Controls.Add(this.AttachedCookieL);
            this.panel1.Controls.Add(this.When);
            this.panel1.Controls.Add(this.UA);
            this.panel1.Controls.Add(this.InURL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.proname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(83, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 109);
            this.panel1.TabIndex = 7;
            // 
            // When
            // 
            this.When.AutoSize = true;
            this.When.Location = new System.Drawing.Point(509, 53);
            this.When.Name = "When";
            this.When.Size = new System.Drawing.Size(29, 12);
            this.When.TabIndex = 12;
            this.When.Text = "when";
            // 
            // UA
            // 
            this.UA.Location = new System.Drawing.Point(111, 37);
            this.UA.Name = "UA";
            this.UA.Size = new System.Drawing.Size(297, 16);
            this.UA.TabIndex = 11;
            this.UA.Text = "UA";
            // 
            // InURL
            // 
            this.InURL.AutoSize = true;
            this.InURL.Location = new System.Drawing.Point(479, 37);
            this.InURL.Name = "InURL";
            this.InURL.Size = new System.Drawing.Size(35, 12);
            this.InURL.TabIndex = 10;
            this.InURL.Text = "Inurl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "When Contents:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "URLMatch:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "UAMatch:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(673, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 64);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cotra.Resource.edit;
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cotra.Resource.delete;
            this.pictureBox2.Location = new System.Drawing.Point(47, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 30);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AttachedCookieL
            // 
            this.AttachedCookieL.AutoSize = true;
            this.AttachedCookieL.Location = new System.Drawing.Point(40, 84);
            this.AttachedCookieL.Name = "AttachedCookieL";
            this.AttachedCookieL.Size = new System.Drawing.Size(95, 12);
            this.AttachedCookieL.TabIndex = 13;
            this.AttachedCookieL.Text = "AttachedCookie:";
            // 
            // AttachedCookie
            // 
            this.AttachedCookie.Location = new System.Drawing.Point(135, 84);
            this.AttachedCookie.Name = "AttachedCookie";
            this.AttachedCookie.Size = new System.Drawing.Size(273, 12);
            this.AttachedCookie.TabIndex = 14;
            this.AttachedCookie.Text = "AttachedCookie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Intercepted Request:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Intercepted Response:";
            // 
            // CookieHostL
            // 
            this.CookieHostL.AutoSize = true;
            this.CookieHostL.Location = new System.Drawing.Point(414, 84);
            this.CookieHostL.Name = "CookieHostL";
            this.CookieHostL.Size = new System.Drawing.Size(71, 12);
            this.CookieHostL.TabIndex = 17;
            this.CookieHostL.Text = "CookieHost:";
            // 
            // CookieHost
            // 
            this.CookieHost.AutoSize = true;
            this.CookieHost.Location = new System.Drawing.Point(491, 84);
            this.CookieHost.Name = "CookieHost";
            this.CookieHost.Size = new System.Drawing.Size(65, 12);
            this.CookieHost.TabIndex = 18;
            this.CookieHost.Text = "CookieHost";
            // 
            // cookiesL
            // 
            this.cookiesL.AutoSize = true;
            this.cookiesL.Location = new System.Drawing.Point(40, 53);
            this.cookiesL.Name = "cookiesL";
            this.cookiesL.Size = new System.Drawing.Size(71, 12);
            this.cookiesL.TabIndex = 20;
            this.cookiesL.Text = "CookieName:";
            // 
            // RequestCookies
            // 
            this.RequestCookies.Location = new System.Drawing.Point(111, 53);
            this.RequestCookies.Name = "RequestCookies";
            this.RequestCookies.Size = new System.Drawing.Size(297, 15);
            this.RequestCookies.TabIndex = 21;
            this.RequestCookies.Text = "RequestCookies";
            // 
            // interceptedCookie
            // 
            this.interceptedCookie.AutoSize = true;
            this.interceptedCookie.ForeColor = System.Drawing.Color.OrangeRed;
            this.interceptedCookie.Location = new System.Drawing.Point(131, 20);
            this.interceptedCookie.Name = "interceptedCookie";
            this.interceptedCookie.Size = new System.Drawing.Size(107, 12);
            this.interceptedCookie.TabIndex = 19;
            this.interceptedCookie.Text = "interceptedCookie";
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(750, 195);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox proEnable;
        private System.Windows.Forms.Label proname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox exportURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label When;
        private System.Windows.Forms.Label UA;
        private System.Windows.Forms.Label InURL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CookieHostL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AttachedCookie;
        private System.Windows.Forms.Label AttachedCookieL;
        private System.Windows.Forms.Label CookieHost;
        private System.Windows.Forms.Label RequestCookies;
        private System.Windows.Forms.Label cookiesL;
        private System.Windows.Forms.Label interceptedCookie;
    }
}
