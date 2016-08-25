using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using cotra.Item;
using cotra.Config;
namespace cotra.Manager
{
    class ProjectItemManager
    {
        static private ProjectItemManager iInjectionRuleInstance = null;

        static public ProjectItemManager Instance()
        {
            if (iInjectionRuleInstance == null)
            {
                iInjectionRuleInstance = new ProjectItemManager();
            }

            return iInjectionRuleInstance;
        }

        //public List<ProjectItem> ProjectItemList = null;
        public CotraConfig contraConfig = null;
        public ProjectItemManager()
        {
            //if (iInjectionRuleInstance != null)
            //{
            //    throw new ArgumentException();
            //}

            this.LoadRuleList();
        }

        private void LoadRuleList()
        {
            this.contraConfig = new CotraConfig();
            //this.ProjectItemList = new List<ProjectItem>();

            XmlDocument document = new XmlDocument();
            document.Load(FiddlerPath.RuleFilePath);

            XmlNodeList allNode = document.DocumentElement.SelectNodes("//InjectionRules");
            if (allNode.Count == 0)
            {
                return;
            }

            //XmlNodeList ruleNodes = document.DocumentElement.SelectNodes("//InjectionRules/Rule");
            XmlNodeList ruleNodes = allNode[0].SelectNodes("Rule");

            ProjectItem rule = null;
            this.contraConfig.Enabled = allNode[0].Attributes["Enabled"].Value;
            for (int i = 0, l = ruleNodes.Count; i < l; i++ )
            {
                rule = new ProjectItem();
                rule.ProName = ruleNodes[i].Attributes["ProName"].Value;
                rule.UserAgent = ruleNodes[i].Attributes["UserAgent"].Value;
                rule.Enabled = ruleNodes[i].Attributes["Enabled"].Value;
                rule.Order = ruleNodes[i].Attributes["Order"].Value;
                rule.InURL = ruleNodes[i].Attributes["InURL"].Value;
                rule.AttachedCookie = ruleNodes[i].Attributes["AttachedCookie"].Value;
                rule.CookieHost = ruleNodes[i].Attributes["CookieHost"].Value;
                rule.WhenEnabled = ruleNodes[i].Attributes["WhenEnabled"].Value;
                rule.WhenContents = ruleNodes[i].Attributes["WhenContents"].Value;
                rule.RequestCookies = ruleNodes[i].Attributes["RequestCookies"].Value;
                rule.IsNew = false;
                XmlNodeList outsNodes = ruleNodes[i].SelectNodes("Out");
                rule.OutURLList = new List<OutSet>();
                for (int j = 0, k = outsNodes.Count; j < k; j++)
                {
                    OutSet set = new OutSet();
                    set.Enabled = outsNodes[j].Attributes["Enabled"].Value;
                    set.Order = outsNodes[j].Attributes["Order"].Value;
                    set.OutURL = outsNodes[j].Attributes["OutURL"].Value;
                    rule.OutURLList.Add(set);
                }
                this.contraConfig.ProjectItemList.Add(rule);
            }
        }
        //private ProjectItem FindRuleByOrder(string order)
        //{
        //    ProjectItem result = null;

        //    foreach (ProjectItem item in this.ProjectItemList)
        //    {
        //        if (item.Order == order)
        //        {
        //            result = item;
        //            break;
        //        }
        //    }

        //    return result;
        //}
        //private OutSet FindOutSetByOrder(string proOrder, string order)
        //{
        //    OutSet result = null;

        //    foreach (OutSet item in this.FindRuleByOrder(proOrder).OutURLList)
        //    {
        //        if (item.Order == order)
        //        {
        //            result = item;
        //            break;
        //        }
        //    }

        //    return result;
        //}
        //public void EnableRule(string order,string enabled)
        //{
        //    ProjectItem rule = this.FindRuleByOrder(order);

        //    if (rule != null)
        //    {
        //        rule.Enabled = enabled;
        //    }
        //}
        //public void EnableOutSet(string proOrder, string order, string enabled)
        //{
        //    OutSet rule = this.FindOutSetByOrder(proOrder, order);

        //    if (rule != null)
        //    {
        //        rule.Enabled = enabled;
        //    }
        //}
        public void SaveRule()
        {
            XmlDocument document = new XmlDocument();
            document.Load(FiddlerPath.RuleFilePath);

            XmlElement root = document.DocumentElement;
            

            root.RemoveAll();
            //root.FirstChild.RemoveAll();
            var newConfigNode = document.CreateElement("InjectionRules");
            newConfigNode.SetAttribute("Enabled", this.contraConfig.Enabled);

            for (int i = 0, l = this.contraConfig.ProjectItemList.Count; i < l; i++)
            {
                XmlElement newRuleNode = null;
                newRuleNode = document.CreateElement("Rule");
                newRuleNode.SetAttribute("Enabled", this.contraConfig.ProjectItemList[i].Enabled);
                newRuleNode.SetAttribute("ProName", this.contraConfig.ProjectItemList[i].ProName);
                newRuleNode.SetAttribute("Order", this.contraConfig.ProjectItemList[i].Order);
                newRuleNode.SetAttribute("UserAgent", this.contraConfig.ProjectItemList[i].UserAgent);
                newRuleNode.SetAttribute("InURL", this.contraConfig.ProjectItemList[i].InURL);
                newRuleNode.SetAttribute("AttachedCookie", this.contraConfig.ProjectItemList[i].AttachedCookie);
                newRuleNode.SetAttribute("CookieHost", this.contraConfig.ProjectItemList[i].CookieHost);
                newRuleNode.SetAttribute("WhenEnabled", this.contraConfig.ProjectItemList[i].WhenEnabled);
                newRuleNode.SetAttribute("WhenContents", this.contraConfig.ProjectItemList[i].WhenContents);
                newRuleNode.SetAttribute("RequestCookies", this.contraConfig.ProjectItemList[i].RequestCookies);
                for (int j = 0, k = this.contraConfig.ProjectItemList[i].OutURLList.Count; j < k; j++)
                {
                    var newOutNode = document.CreateElement("Out");
                    newOutNode.SetAttribute("Enabled", this.contraConfig.ProjectItemList[i].OutURLList[j].Enabled);
                    newOutNode.SetAttribute("OutURL", this.contraConfig.ProjectItemList[i].OutURLList[j].OutURL);
                    newOutNode.SetAttribute("Order", this.contraConfig.ProjectItemList[i].OutURLList[j].Order);
                    newRuleNode.AppendChild(newOutNode);
                }
                newConfigNode.AppendChild(newRuleNode);
                //root.FirstChild.AppendChild(newRuleNode);
            }
            root.AppendChild(newConfigNode);
            document.Save(FiddlerPath.RuleFilePath);
        }
    }
}
