namespace cotra
{
    partial class RuleEditorForm
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
            this.ProNameL = new System.Windows.Forms.Label();
            this.ProName = new System.Windows.Forms.TextBox();
            this.UserAgentL = new System.Windows.Forms.Label();
            this.UserAgent = new System.Windows.Forms.TextBox();
            this.InURLL = new System.Windows.Forms.Label();
            this.InURL = new System.Windows.Forms.TextBox();
            this.WhenL = new System.Windows.Forms.Label();
            this.WhenContents = new System.Windows.Forms.TextBox();
            this.WhenEnabled = new System.Windows.Forms.CheckBox();
            this.OutL = new System.Windows.Forms.Label();
            this.OutList = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AttachedCookie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CookieHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RequestCookies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProNameL
            // 
            this.ProNameL.AutoSize = true;
            this.ProNameL.Location = new System.Drawing.Point(27, 19);
            this.ProNameL.Name = "ProNameL";
            this.ProNameL.Size = new System.Drawing.Size(35, 12);
            this.ProNameL.TabIndex = 0;
            this.ProNameL.Text = "Name:";
            // 
            // ProName
            // 
            this.ProName.Location = new System.Drawing.Point(127, 16);
            this.ProName.Name = "ProName";
            this.ProName.Size = new System.Drawing.Size(367, 21);
            this.ProName.TabIndex = 1;
            // 
            // UserAgentL
            // 
            this.UserAgentL.AutoSize = true;
            this.UserAgentL.Location = new System.Drawing.Point(27, 51);
            this.UserAgentL.Name = "UserAgentL";
            this.UserAgentL.Size = new System.Drawing.Size(65, 12);
            this.UserAgentL.TabIndex = 2;
            this.UserAgentL.Text = "UserAgent:";
            this.UserAgentL.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserAgent
            // 
            this.UserAgent.Location = new System.Drawing.Point(127, 48);
            this.UserAgent.Name = "UserAgent";
            this.UserAgent.Size = new System.Drawing.Size(367, 21);
            this.UserAgent.TabIndex = 3;
            // 
            // InURLL
            // 
            this.InURLL.AutoSize = true;
            this.InURLL.Location = new System.Drawing.Point(27, 83);
            this.InURLL.Name = "InURLL";
            this.InURLL.Size = new System.Drawing.Size(71, 12);
            this.InURLL.TabIndex = 4;
            this.InURLL.Text = "RequestURL;";
            // 
            // InURL
            // 
            this.InURL.Location = new System.Drawing.Point(127, 80);
            this.InURL.Name = "InURL";
            this.InURL.Size = new System.Drawing.Size(367, 21);
            this.InURL.TabIndex = 5;
            // 
            // WhenL
            // 
            this.WhenL.AutoSize = true;
            this.WhenL.Location = new System.Drawing.Point(27, 145);
            this.WhenL.Name = "WhenL";
            this.WhenL.Size = new System.Drawing.Size(89, 12);
            this.WhenL.TabIndex = 6;
            this.WhenL.Text = "When Contents:";
            // 
            // WhenContents
            // 
            this.WhenContents.Location = new System.Drawing.Point(129, 162);
            this.WhenContents.Name = "WhenContents";
            this.WhenContents.Size = new System.Drawing.Size(367, 21);
            this.WhenContents.TabIndex = 7;
            // 
            // WhenEnabled
            // 
            this.WhenEnabled.AutoSize = true;
            this.WhenEnabled.Location = new System.Drawing.Point(129, 144);
            this.WhenEnabled.Name = "WhenEnabled";
            this.WhenEnabled.Size = new System.Drawing.Size(66, 16);
            this.WhenEnabled.TabIndex = 8;
            this.WhenEnabled.Text = "Enabled";
            this.WhenEnabled.UseVisualStyleBackColor = true;
            this.WhenEnabled.CheckedChanged += new System.EventHandler(this.WhenEnabled_CheckedChanged);
            // 
            // OutL
            // 
            this.OutL.AutoSize = true;
            this.OutL.Location = new System.Drawing.Point(27, 260);
            this.OutL.Name = "OutL";
            this.OutL.Size = new System.Drawing.Size(77, 12);
            this.OutL.TabIndex = 9;
            this.OutL.Text = "ResponseURL:";
            // 
            // OutList
            // 
            this.OutList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutList.DropDownHeight = 206;
            this.OutList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.OutList.FormattingEnabled = true;
            this.OutList.IntegralHeight = false;
            this.OutList.Location = new System.Drawing.Point(127, 257);
            this.OutList.Name = "OutList";
            this.OutList.Size = new System.Drawing.Size(365, 85);
            this.OutList.TabIndex = 10;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(485, 345);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 11;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(566, 345);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 12;
            this.Cancle.Text = "Cancle";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "\"xxx\" or \"regex:xxx\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "\"xxx\" or \"regex:xxx\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "\"name1;name2\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "\"xxx\" or \"regex:xxx\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cotra.Resource.add;
            this.pictureBox1.Location = new System.Drawing.Point(521, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 32);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cotra.Resource.delete;
            this.pictureBox2.Location = new System.Drawing.Point(585, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 32);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "AttachedCookie:";
            // 
            // AttachedCookie
            // 
            this.AttachedCookie.Location = new System.Drawing.Point(128, 191);
            this.AttachedCookie.Name = "AttachedCookie";
            this.AttachedCookie.Size = new System.Drawing.Size(368, 21);
            this.AttachedCookie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "CookieHost:";
            // 
            // CookieHost
            // 
            this.CookieHost.Location = new System.Drawing.Point(127, 221);
            this.CookieHost.Name = "CookieHost";
            this.CookieHost.Size = new System.Drawing.Size(367, 21);
            this.CookieHost.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "RequestCookies:";
            // 
            // RequestCookies
            // 
            this.RequestCookies.Location = new System.Drawing.Point(127, 112);
            this.RequestCookies.Name = "RequestCookies";
            this.RequestCookies.Size = new System.Drawing.Size(365, 21);
            this.RequestCookies.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "\"name1=val;name2=val\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "\"name=ID\"";
            // 
            // RuleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 380);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RequestCookies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CookieHost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AttachedCookie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.OutList);
            this.Controls.Add(this.OutL);
            this.Controls.Add(this.WhenEnabled);
            this.Controls.Add(this.WhenContents);
            this.Controls.Add(this.WhenL);
            this.Controls.Add(this.InURL);
            this.Controls.Add(this.InURLL);
            this.Controls.Add(this.UserAgent);
            this.Controls.Add(this.UserAgentL);
            this.Controls.Add(this.ProName);
            this.Controls.Add(this.ProNameL);
            this.Name = "RuleEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProNameL;
        private System.Windows.Forms.TextBox ProName;
        private System.Windows.Forms.Label UserAgentL;
        private System.Windows.Forms.TextBox UserAgent;
        private System.Windows.Forms.Label InURLL;
        private System.Windows.Forms.TextBox InURL;
        private System.Windows.Forms.Label WhenL;
        private System.Windows.Forms.TextBox WhenContents;
        private System.Windows.Forms.CheckBox WhenEnabled;
        private System.Windows.Forms.Label OutL;
        private System.Windows.Forms.ComboBox OutList;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AttachedCookie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CookieHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RequestCookies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}