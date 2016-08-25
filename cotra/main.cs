using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using cotra;
using cotra.Manager;
using cotra.Item;
using System.Text.RegularExpressions;
namespace cotra
{
    public class main : IAutoTamper
    {
        /**
        * UI
        * */
        ConfigControl oConfigControl = null;
        public main()
        {
            cotra.Config.FiddlerPath.InitPath();
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.oConfigControl = new ConfigControl();
        }
        void IAutoTamper.AutoTamperRequestAfter(Session oSession)
        {
            //throw new NotImplementedException();
        }

        void IAutoTamper.AutoTamperRequestBefore(Session oSession)
        {
            CotraConfig contraConfig = ProjectItemManager.Instance().contraConfig;
            var sCookie =oSession.oRequest["Cookie"]; 
            for (int i = 0, k = contraConfig.ProjectItemList.Count; i < k; i++)
            {
                if (Boolean.Parse(contraConfig.Enabled) && Boolean.Parse(contraConfig.ProjectItemList[i].Enabled))
                {
                    if (contraConfig.ProjectItemList[i].RequestCookies.Length>0&&DoMatch(contraConfig.ProjectItemList[i].UserAgent, oSession.oRequest["User-Agent"]) && DoMatch(contraConfig.ProjectItemList[i].InURL, oSession.fullUrl))
                    {
                        bool whenflag = true;
                        if (Boolean.Parse(contraConfig.ProjectItemList[i].WhenEnabled) && contraConfig.ProjectItemList[i].WhenContents.Length>0)
                        {
                            whenflag = false;
                            try
                            {
                                Match whenmatch = new Regex("(^| )" + contraConfig.ProjectItemList[i].WhenContents + "(;|$)").Match(sCookie);
                                if (whenmatch.Success)
                                {
                                    whenflag = true;
                                }
                            }
                            catch { }
                        }
                        if (whenflag)
                        {
                            List<CookieSet> setList = new List<CookieSet>();
                            var cookieStr=contraConfig.ProjectItemList[i].RequestCookies.Split(';');
                            for (int j = 0, v = cookieStr.Length; j < v; j++)
                            {
                                try
                                {
                                    Match match = new Regex("(^| )" + cookieStr[j] + "(?:=([^;]*))?(;|$)").Match(sCookie);
                                    if (cookieStr[j].Length>0&&match.Success)
                                    {
                                        CookieSet editItem = contraConfig.ProjectItemList[i].CookieList.Find(o => o.Name == cookieStr[j]);
                                        if (editItem != null)
                                        {
                                            editItem.Value = match.Groups[2].Value;
                                        }
                                        else
                                        {
                                            CookieSet tempset = new CookieSet();
                                            tempset.Name = cookieStr[j];
                                            tempset.Value = match.Groups[2].Value;
                                            contraConfig.ProjectItemList[i].CookieList.Add(tempset);
                                        }
                                        //CookieSet tempset = new CookieSet();
                                        //tempset.Name = cookieStr[j];
                                        //tempset.Value = match.Groups[2].Value;
                                        //setList.Add();
                                        //contraConfig.ProjectItemList[i].CookieList.Add(tempset);
                                    
                                    }
                                }
                                catch { }
                                
                            }
                            this.oConfigControl.RefleshCookieLabel();
                            
                        }
                        //if (setList.Count > 0)
                        //{
                         //   contraConfig.ProjectItemList[i].CookieList = setList;
                        //}
                       
                    }
                }
                
            }
            //throw new NotImplementedException();
        }

        void IAutoTamper.AutoTamperResponseAfter(Session oSession)
        {
            //throw new NotImplementedException();
        }

        void IAutoTamper.AutoTamperResponseBefore(Session oSession)
        {
            //throw new NotImplementedException();
            CotraConfig contraConfig = ProjectItemManager.Instance().contraConfig;
            bool flag = true;
            for (int i = 0, k = contraConfig.ProjectItemList.Count; i < k && flag; i++)
            {
                if (Boolean.Parse(contraConfig.Enabled) && Boolean.Parse(contraConfig.ProjectItemList[i].Enabled))
                {
                    if (!DoMatch(contraConfig.ProjectItemList[i].UserAgent, oSession.oRequest["User-Agent"]) )
                    {
                        for (int j = 0, v = contraConfig.ProjectItemList[i].OutURLList.Count; j < v && flag; j++)
                        {
                            if (Boolean.Parse(contraConfig.ProjectItemList[i].OutURLList[j].Enabled) && DoMatch(contraConfig.ProjectItemList[i].OutURLList[j].OutURL, oSession.fullUrl))
                            {
                                for (int m = 0, n = contraConfig.ProjectItemList[i].CookieList.Count; m < n&&flag; m++)
                                {
                                    oSession.oResponse.headers.Add("Set-Cookie", contraConfig.ProjectItemList[i].CookieList[m].Name + "=" + contraConfig.ProjectItemList[i].CookieList[m].Value + "; PATH=/; DOMAIN=" + contraConfig.ProjectItemList[i].CookieHost+ ";");
                                }
                                if (contraConfig.ProjectItemList[i].AttachedCookie.Length > 0)
                                {
                                     var AttachedCookie = contraConfig.ProjectItemList[i].AttachedCookie.Split(';');
                                     for (int x = 0, y = AttachedCookie.Length; x < y; x++)
                                     {
                                         if (AttachedCookie[x].Length > 0)
                                         {
                                             oSession.oResponse.headers.Add("Set-Cookie", AttachedCookie[x] + "; PATH=/; DOMAIN=" + contraConfig.ProjectItemList[i].CookieHost + ";");
                                         }
                                     }

                                 }
                                 flag = false;
                            }
                        }
                    }
                }

            }
        }

        void IAutoTamper.OnBeforeReturningError(Session oSession)
        {
            //throw new NotImplementedException();
        }

        void IFiddlerExtension.OnBeforeUnload()
        {
            //throw new NotImplementedException();
            ProjectItemManager.Instance().SaveRule();
        }

        void IFiddlerExtension.OnLoad()
        {
            //throw new NotImplementedException();
            //插件标签页
            TabPage oPage = new TabPage("Cotra");

            oPage.Controls.Add(this.oConfigControl);
            this.oConfigControl.Dock = DockStyle.Fill;

            int size = FiddlerApplication.UI.tabsViews.TabPages.Count;
            FiddlerApplication.UI.tabsViews.TabPages.Insert(size, oPage);

            // add tab 后再添加图标，具体原因参考： 
            // https://github.com/telerik/fiddler-docs/issues/4

            FiddlerApplication.UI.imglSessionIcons.Images.Add("Cotra", cotra.Resource.icon);
            oPage.ImageKey = "Cotra";
        }
        private bool DoMatch(string match,string str)
        {
            if (match.Length > 6 && match.StartsWith("REGEX:", StringComparison.OrdinalIgnoreCase))
            {
                string pattern = match.Substring(6);
                try
                {
                    return new Regex(pattern).Match(str).Success;
                }
                catch
                {
                    return false;
                }
            }
            else if (str.IndexOf(match, StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Log(string text)
        {
            FiddlerApplication.Log.LogString("cotra:"+text);
        }
    }
}
