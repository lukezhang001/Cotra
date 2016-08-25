using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cotra.Item;
namespace cotra
{
    public partial class RuleEditorForm : Form
    {
        private ProjectItem proItem;
        private List<OutSet> pageOutSet;
        private ConfigControl configCon;
        private ItemControl itemCon;
        public RuleEditorForm(ProjectItem item,ConfigControl oCon,ItemControl oItem)
        {
            InitializeComponent();
            configCon = oCon ;
            itemCon = oItem;
            this.pageOutSet = new List<OutSet>();

            this.proItem = item;
            this.ProName.Text = item.ProName;
            this.UserAgent.Text = item.UserAgent;
            this.InURL.Text = item.InURL;
            this.WhenEnabled.Checked =item.WhenEnabled!=null&& Boolean.Parse(item.WhenEnabled);
            this.WhenContents.Enabled = this.WhenEnabled.Checked;
            this.WhenContents.Text = item.WhenContents;
            this.AttachedCookie.Text = item.AttachedCookie;
            this.CookieHost.Text = item.CookieHost;
            this.RequestCookies.Text = item.RequestCookies;
            for (int i = 0, k = item.OutURLList.Count; i < k; i++)
            {
                 OutSet set=new  OutSet();
                 set.Enabled = item.OutURLList[i].Enabled;
                 set.Order = item.OutURLList[i].Order;
                 set.OutURL = item.OutURLList[i].OutURL;
                this.pageOutSet.Add(set);
            }
            //this.OutList.DroppedDown = true;
            bindOutList();
        }
        private void bindOutList()
        {
            //OutSet temp = new OutSet();
            //temp.Enabled = "false";
            //temp.OutURL = "wew";
            //pageOutSet.Add(temp);
            this.OutList.Items.Clear();
            
            this.OutList.ValueMember = "Order";
            this.OutList.DisplayMember = "OutURL";
            for (int i = 0, k = pageOutSet.Count; i < k; i++)
            {
                this.OutList.Items.Add(pageOutSet[i]);
            }
            this.OutList.Text = "";
            //this.OutList.DataSource = pageOutSet;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WhenEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.WhenContents.Enabled = this.WhenEnabled.Checked;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string ProNameText = this.ProName.Text.Trim();
            string UserAgent = this.UserAgent.Text.Trim();
            string InURL = this.InURL.Text.Trim();
            string CookieHost = this.CookieHost.Text.Trim();
            string RequestCookies = this.RequestCookies.Text.Trim();
            if (ProNameText == null || "".Equals(ProNameText))
            {
                MessageBox.Show("Please input the 'Name'");
                return;
            }
            if (UserAgent == null || "".Equals(UserAgent))
            {
                MessageBox.Show("Please input the 'UserAgent'");
                return;
            }
            if (InURL == null || "".Equals(InURL))
            {
                MessageBox.Show("Please input 'RequestURL'");
                return;
            }
            if (CookieHost == null || "".Equals(CookieHost))
            {
                MessageBox.Show("Please input 'CookieHost'");
                return;
            }
            this.proItem.ProName = ProNameText;
            this.proItem.UserAgent = UserAgent;
            this.proItem.InURL = InURL;
            this.proItem.WhenEnabled = this.WhenEnabled.Checked.ToString();
            this.proItem.WhenContents=this.WhenContents.Text.Trim();
            this.proItem.RequestCookies = RequestCookies;
            this.proItem.AttachedCookie = this.AttachedCookie.Text.Trim();
            this.proItem.CookieHost = CookieHost;
            this.proItem.OutURLList=this.pageOutSet;
            this.configCon.Edit(this.proItem, this.itemCon);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string OutURL = this.OutList.Text.Trim();
            if (OutURL == null || "".Equals(OutURL))
            {
                MessageBox.Show("Please input 'ExportURL'");
                return;
            }
            OutSet tempSet = pageOutSet.Find(o => o.OutURL == OutURL);
            if (tempSet != null)
            {
                MessageBox.Show("Already exist");
                return;
            }
            OutSet temp=new OutSet ();
            //temp.Enabled="false";
            temp.OutURL=this.OutList.Text.Trim();
            //temp.Order=Guid.NewGuid().ToString();
            pageOutSet.Add(temp);
            //this.OutList.Items.Add(temp);
            bindOutList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OutSet select=(OutSet)this.OutList.SelectedItem;
            OutSet temp = pageOutSet.Find(o => o.Order == select.Order);
            if (temp!=null)
            {
                pageOutSet.Remove(temp);
            }
            bindOutList();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
