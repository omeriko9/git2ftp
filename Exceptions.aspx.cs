using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exceptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (var exp in Application["Exceptions"] as Dictionary<Exception, DateTime>)
            {
                var stackTrick = " <a href=\"#\" onclick=\"var sp = this.getElementsByTagName('span')[1]; console.debug(sp.style.display); sp.style.display = sp.style.display=='none' ? 'inline' : 'none'; \"><span> Stack </span><span class=\"nohover\" style=\"display:none\"><br/>{0}</span><br /></a>";
                lblExceptions.Text += "[" + exp.Value.ToString() + "]: " + exp.Key.Message +
                    String.Format(stackTrick, exp.Key.StackTrace.Replace(Environment.NewLine, "<br/>"))
                    + (exp.Key.InnerException != null ? ("Inner: " + (exp.Key.InnerException.Message + String.Format(stackTrick, exp.Key.InnerException.StackTrace.Replace(Environment.NewLine, "<br/>")))
                    + (exp.Key.InnerException.InnerException != null ?
                    ("Inner: " + exp.Key.InnerException.InnerException + String.Format(stackTrick, exp.Key.InnerException.InnerException.StackTrace.Replace(Environment.NewLine, "<br/>"))) : ""))
                    : "") + "<br />";
            }

        }
    }
}