using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cotra.Item;
namespace cotra
{
    public partial class ItemControl : UserControl
    {
        private ProjectItem proItem;
        private ConfigControl configCon;
        public ItemControl(ProjectItem projectItem,ConfigControl oControl)
        {
            InitializeComponent();
            this.configCon = oControl;
            this.interceptedCookie.Text = "";
            loadData(projectItem);

        }
        public void loadData(ProjectItem projectItem)
        {
            this.proItem = projectItem;
            this.proname.Text = projectItem.ProName;
            this.UA.Text = projectItem.UserAgent;
            this.InURL.Text = projectItem.InURL;
            this.proEnable.Checked = projectItem.Enabled != null && Boolean.Parse(projectItem.Enabled);
            this.When.Text = (projectItem.WhenEnabled != null && Boolean.Parse(projectItem.WhenEnabled)) ? projectItem.WhenContents : "ALL";
            this.AttachedCookie.Text = projectItem.AttachedCookie;
            this.CookieHost.Text = projectItem.CookieHost;
            this.RequestCookies.Text = projectItem.RequestCookies;
            this.exportURL.Items.Clear();
            this.exportURL.DisplayMember = "OutURL";

            this.exportURL.ValueMember = "Order";
            //this.exportURL.DataSource = projectItem.OutURLList;
            for (int i = 0, k = projectItem.OutURLList.Count; i < k; i++)
            {
                this.exportURL.Items.Add(projectItem.OutURLList[i]);
                this.exportURL.SetItemChecked(i, projectItem.OutURLList[i].Enabled!=null&&Boolean.Parse(projectItem.OutURLList[i].Enabled));
            }
        }
        public void refleshCookieLabel()
        {
            if (this.proItem.CookieList.Count > 0)
            {
                string temp = "";
                for (int i = 0, k = this.proItem.CookieList.Count; i < k; i++)
                {
                    temp = temp + this.proItem.CookieList[i].Name + "=" + this.proItem.CookieList[i].Value+";";
                }
                this.interceptedCookie.Text = "(" + temp.Trim(';') + ")";
            }
            else
            {
                this.interceptedCookie.Text = "";
            }
           
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.proItem.Enabled = this.proEnable.Checked.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void proname_Click(object sender, EventArgs e)
        {

        }

        private void exportURL_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //MessageBox.Show(e.CurrentValue.ToString() + ';'+e.NewValue.ToString()+';'+e.Index);
            OutSet select = (OutSet)this.exportURL.Items[e.Index];
            //OutSet select = (OutSet)this.OutList.SelectedItem;
            OutSet temp = this.proItem.OutURLList.Find(o => o.Order == select.Order);
            if (temp != null)
            {
                temp.Enabled = (e.NewValue.ToString() == "Checked").ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FlowLayoutPanel parent = (FlowLayoutPanel)(this.Parent);

            //parent.Controls.Remove(this);
            //this.configCon.Remove(proItem, this);
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to delete?", "Confirm", messButton);
            if(dr== DialogResult.OK){
                this.configCon.Remove(proItem, this);
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new RuleEditorForm(this.proItem, this.configCon,this).Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
