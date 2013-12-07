using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Octokit;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Octokit.Internal;
using DAL;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        using (var a = new git2ftpEntities())
        {
            var user = a.git2ftp_Users.Where(x => x.Username == "omeriko9").First();
            var log = a.git2ftp_Log.OrderByDescending(y => y.DateTime).FirstOrDefault();
            foreach (var proj in user.git2ftp_Projects)
                lblEvents.Text += proj.GitRepositoryName + ": " + (log != null ? log.State : "none") + " (at " + log.DateTime.ToString() +") <br />";
        }

        return;
       
    }

    public string APIkey { get { return "97c095f6da375a01744f897717e2ec1a5491bac6"; } }
    public string Owner { get { return "omeriko9"; } }
    public string Repository { get { return "zohargallery"; } }

    public string FTPUrl { get { return "omeriko9.com/zohargallery"; } }
    public string FTPUsername { get { return "omeriko9"; } }
    public string FTPpassword { get { return "tempP@ssw0rd"; } }
}