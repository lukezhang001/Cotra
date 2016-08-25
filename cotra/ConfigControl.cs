using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cotra.Config;
using cotra.Manager;
using cotra.Item;
namespace cotra
{
    public partial class ConfigControl : UserControl
    {
        private List<ProjectItem> proList;
        private CotraConfig contraConfig;
        public ConfigControl()
        {
            InitializeComponent();

            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            this.contraConfig = ProjectItemManager.Instance().contraConfig;
            this.proList = this.contraConfig.ProjectItemList;
            this.allCheck.Checked = this.contraConfig.Enabled != null && Boolean.Parse(this.contraConfig.Enabled);
            for (int i = 0; i < this.proList.Count; i++)
            {
                ItemControl control = new ItemControl(this.proList[i], this);
                this.flowLayoutPanel1.Controls.Add(control);
            }
            ChangeLabelColor();
        }
        public void RefleshCookieLabel()
        {
            for (int i = 0; i < this.flowLayoutPanel1.Controls.Count; i++)
            {
                ItemControl control = (ItemControl)this.flowLayoutPanel1.Controls[i];
                control.refleshCookieLabel();
            }
        }
        public void Edit(ProjectItem item,ItemControl itemCon) 
        {
            if (itemCon==null)
            {
                ItemControl control = new ItemControl(item,this);
                this.flowLayoutPanel1.Controls.Add(control);
                this.proList.Add(item);
            }
            else
            {
                itemCon.loadData(item);
            }
        }
        public void Remove(ProjectItem item, ItemControl itemCon)
        {
            this.flowLayoutPanel1.Controls.Remove(itemCon);
            this.proList.Remove(item);
        }
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count>0)
            {
                for (int i = 0; i < this.flowLayoutPanel1.Controls.Count; i++)
                {
                   //this.flowLayoutPanel1.Controls[i].Width = this.Width-30;
                   this.flowLayoutPanel1.Controls[i].Width = this.flowLayoutPanel1.Width - 30;
                   //this.flowLayoutPanel1.Width = this.Width;
                    //this.flowLayoutPanel1.Controls[i]
                }
            }
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RuleEditorForm(new ProjectItem(),this,null).Show();
            /*
             * ItemControl control = new ItemControl();
            this.flowLayoutPanel1.Controls.Add(control);
            this.flowLayoutPanel1.Controls[this.flowLayoutPanel1.Controls.Count-1].Width = this.flowLayoutPanel1.Width - 20;
             */
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //if (e.Column==1)
            //{
            //    Graphics g = e.Graphics;
            //    Rectangle r = e.CellBounds;
            //    g.FillRectangle(Brushes.Gray, r);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void allCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.contraConfig.Enabled = this.allCheck.Checked.ToString();
            ChangeLabelColor();
        }
        private void ChangeLabelColor()
        {
            //if (this.allCheck.Checked)
            //{
                this.memoL.BackColor = Color.FromArgb(250, 250, 210);
                this.label1.ForeColor = Color.Black;
            //}
            //else
            //{
            //    this.memoL.BackColor = Color.FromArgb(128, 129, 128);
            //    this.label1.ForeColor = Color.White;
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr=MessageBox.Show("Cotra 1.0.0\nIf you like it, please click a star at: https://github.com/lukezhang001/Cotra \n", "About", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dr== DialogResult.OK){
                try
                {
                    System.Diagnostics.Process.Start("https://github.com/lukezhang001/Cotra");
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                } 
            }
        }
    }
}
