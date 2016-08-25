using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotra.Item
{
    public class ProjectItem
    {
        public string Order { get; set; }
        public string Enabled { get; set; }
        public string ProName { get; set; }
        public string UserAgent { get; set; }
        public string InURL { get; set; }
        public string AttachedCookie { get; set; }
        public string CookieHost { get; set; }
        public string WhenEnabled { get; set; }
        public string WhenContents { get; set; }
        public string RequestCookies { get; set; }
        public bool IsNew { get; set; }
        public List<OutSet> OutURLList;
        public List<CookieSet> CookieList;
        public ProjectItem()
        {
            this.Order = Guid.NewGuid().ToString();
            this.Enabled = "false";
            this.ProName = "";
            this.UserAgent = "";
            this.InURL = "";
            this.WhenContents = "";
            this.AttachedCookie = "";
            this.RequestCookies = "";
            this.CookieHost = "";
            this.WhenEnabled = "false";
            this.OutURLList = new List<OutSet>();
            this.IsNew = true;
            CookieList = new List<CookieSet>();
        }
    }
    public class CookieSet
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public CookieSet()
        {
            this.Name = "";
            this.Value = "";
        }

    }
    public class OutSet
    {
        public string Order { get; set; }
        public string Enabled { get; set; }
        public string OutURL { get; set; }
        public OutSet()
        {
            this.Order = Guid.NewGuid().ToString();
            this.Enabled = "True";
            this.OutURL = "";
        }

    }
    public class CotraConfig
    {
        public string Enabled { get; set; }
        public List<ProjectItem> ProjectItemList;
        public CotraConfig()
        {
            this.Enabled = "false";
            this.ProjectItemList = new List<ProjectItem>();
        }
    }
}
