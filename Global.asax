<%@ Application Language="C#" %>

<script RunAt="server">

    private Dictionary<Exception, DateTime> GetExcp() { return Application["Exceptions"] as Dictionary<Exception, DateTime>; }

    void Application_Start(object sender, EventArgs e)
    {
        var excp = Application["Exceptions"] = new Dictionary<Exception, DateTime>();



    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
        var exp = GetExcp();
        exp.Add(Server.GetLastError(), DateTime.Now);
        if (exp.Keys.Count > 100)
        {
            exp.OrderByDescending(y => y.Value).Take(exp.Keys.Count - 100).ToList()
                .ForEach(y => exp.Remove(y.Key));
        }
    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
