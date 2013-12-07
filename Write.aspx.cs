using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using jobj = System.Collections.Generic.Dictionary<string, object>;

public partial class Write : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var json = @"payload={""ref"":""refs/heads/master"",""after"":""4c7cd396f97c90becfe9bacf640c17c09bacda2e"",""before"":""9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""created"":false,""deleted"":false,""forced"":false,""compare"":""https://github.com/omeriko9/zohargallery/compare/9ae07ae8ce97...4c7cd396f97c"",""commits"":[{""id"":""85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""distinct"":true,""message"":""test r"",""timestamp"":""2013-12-07T04:42:10-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test/omer.txt""],""modified"":[]},{""id"":""c6b7c85ff865d4d388b253b16b3980b3195874cb"",""distinct"":true,""message"":""test r2"",""timestamp"":""2013-12-07T04:51:11-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/c6b7c85ff865d4d388b253b16b3980b3195874cb"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test/test.txt""],""modified"":[]},{""id"":""4c7cd396f97c90becfe9bacf640c17c09bacda2e"",""distinct"":true,""message"":""test test test"",""timestamp"":""2013-12-07T06:52:10-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/4c7cd396f97c90becfe9bacf640c17c09bacda2e"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test3.txt""],""modified"":[""test.txt""]}],""head_commit"":{""id"":""4c7cd396f97c90becfe9bacf640c17c09bacda2e"",""distinct"":true,""message"":""test test test"",""timestamp"":""2013-12-07T06:52:10-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/4c7cd396f97c90becfe9bacf640c17c09bacda2e"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test3.txt""],""modified"":[""test.txt""]},""repository"":{""id"":14746532,""name"":""zohargallery"",""url"":""https://github.com/omeriko9/zohargallery"",""description"":"""",""watchers"":0,""stargazers"":0,""forks"":1,""fork"":false,""size"":44928,""owner"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""},""private"":false,""open_issues"":0,""has_issues"":true,""has_downloads"":true,""has_wiki"":true,""language"":""JavaScript"",""created_at"":1385555639,""pushed_at"":1386427934,""master_branch"":""master""},""pusher"":{""name"":""none""}}";
        //@"payload={""ref"":""refs/heads/master"",""after"":""85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""before"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""created"":false,""deleted"":false,""forced"":false,""compare"":""https://github.com/omeriko9/zohargallery/compare/05f942cef695...85168859a893"",""commits"":[{""id"":""f8d87198289b4fc85ad8864fc3f3945b4565c529"",""distinct"":true,""message"":""another test"",""timestamp"":""2013-12-06T18:13:23-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/f8d87198289b4fc85ad8864fc3f3945b4565c529"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/test.txt""],""removed"":[],""modified"":[]},{""id"":""9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""distinct"":true,""message"":""test"",""timestamp"":""2013-12-07T03:22:16-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/omer.txt""],""removed"":[],""modified"":[]},{""id"":""85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""distinct"":true,""message"":""test r"",""timestamp"":""2013-12-07T04:42:10-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test/omer.txt""],""modified"":[]}],""head_commit"":{""id"":""85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""distinct"":true,""message"":""test r"",""timestamp"":""2013-12-07T04:42:10-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/85168859a893b1411bdd20d9e9c3de6f8a8f4cb0"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[],""removed"":[""test/omer.txt""],""modified"":[]},""repository"":{""id"":14746532,""name"":""zohargallery"",""url"":""https://github.com/omeriko9/zohargallery"",""description"":"""",""watchers"":0,""stargazers"":0,""forks"":1,""fork"":false,""size"":44919,""owner"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""},""private"":false,""open_issues"":0,""has_issues"":true,""has_downloads"":true,""has_wiki"":true,""language"":""JavaScript"",""created_at"":1385555639,""pushed_at"":1386420134,""master_branch"":""master""},""pusher"":{""name"":""none""}}";
        //@"payload={""ref"":""refs/heads/master"",""after"":""9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""before"":""14e8c206f72f35afbb2a93e3ee624c72cff6e681"",""created"":false,""deleted"":false,""forced"":false,""compare"":""https://github.com/omeriko9/zohargallery/compare/14e8c206f72f...9ae07ae8ce97"",""commits"":[{""id"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""distinct"":true,""message"":""test add/change/delete"",""timestamp"":""2013-12-06T15:12:00-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/05f942cef695ad37a99f0978b84b25b7f1366f1b"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test3.txt""],""removed"":[""test2.txt""],""modified"":[""test.txt""]},{""id"":""f8d87198289b4fc85ad8864fc3f3945b4565c529"",""distinct"":true,""message"":""another test"",""timestamp"":""2013-12-06T18:13:23-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/f8d87198289b4fc85ad8864fc3f3945b4565c529"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/test.txt""],""removed"":[],""modified"":[]},{""id"":""9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""distinct"":true,""message"":""test"",""timestamp"":""2013-12-07T03:22:16-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/omer.txt""],""removed"":[],""modified"":[]}],""head_commit"":{""id"":""9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""distinct"":true,""message"":""test"",""timestamp"":""2013-12-07T03:22:16-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/9ae07ae8ce979857ae6160dcb7267bf1574fd137"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/omer.txt""],""removed"":[],""modified"":[]},""repository"":{""id"":14746532,""name"":""zohargallery"",""url"":""https://github.com/omeriko9/zohargallery"",""description"":"""",""watchers"":0,""stargazers"":0,""forks"":1,""fork"":false,""size"":44915,""owner"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""},""private"":false,""open_issues"":0,""has_issues"":true,""has_downloads"":true,""has_wiki"":true,""language"":""JavaScript"",""created_at"":1385555639,""pushed_at"":1386415341,""master_branch"":""master""},""pusher"":{""name"":""none""}}";
        //@"payload={""ref"":""refs/heads/master"",""after"":""f8d87198289b4fc85ad8864fc3f3945b4565c529"",""before"":""97a043c54c956981228819db3b99bd8320586e9c"",""created"":false,""deleted"":false,""forced"":false,""compare"":""https://github.com/omeriko9/zohargallery/compare/97a043c54c95...f8d87198289b"",""commits"":[{""id"":""14e8c206f72f35afbb2a93e3ee624c72cff6e681"",""distinct"":true,""message"":""test"",""timestamp"":""2013-12-06T15:10:58-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/14e8c206f72f35afbb2a93e3ee624c72cff6e681"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test.txt"",""test2.txt""],""removed"":[],""modified"":[]},{""id"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""distinct"":true,""message"":""test add/change/delete"",""timestamp"":""2013-12-06T15:12:00-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/05f942cef695ad37a99f0978b84b25b7f1366f1b"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test3.txt""],""removed"":[""test2.txt""],""modified"":[""test.txt""]},{""id"":""f8d87198289b4fc85ad8864fc3f3945b4565c529"",""distinct"":true,""message"":""another test"",""timestamp"":""2013-12-06T18:13:23-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/f8d87198289b4fc85ad8864fc3f3945b4565c529"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/test.txt""],""removed"":[],""modified"":[]}],""head_commit"":{""id"":""f8d87198289b4fc85ad8864fc3f3945b4565c529"",""distinct"":true,""message"":""another test"",""timestamp"":""2013-12-06T18:13:23-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/f8d87198289b4fc85ad8864fc3f3945b4565c529"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test/test.txt""],""removed"":[],""modified"":[]},""repository"":{""id"":14746532,""name"":""zohargallery"",""url"":""https://github.com/omeriko9/zohargallery"",""description"":"""",""watchers"":0,""stargazers"":0,""forks"":1,""fork"":false,""size"":44915,""owner"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""},""private"":false,""open_issues"":0,""has_issues"":true,""has_downloads"":true,""has_wiki"":true,""language"":""JavaScript"",""created_at"":1385555639,""pushed_at"":1386382408,""master_branch"":""master""},""pusher"":{""name"":""none""}}"; 
        //@"payload={""ref"":""refs/heads/master"",""after"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""before"":""14e8c206f72f35afbb2a93e3ee624c72cff6e681"",""created"":false,""deleted"":false,""forced"":false,""compare"":""https://github.com/omeriko9/zohargallery/compare/14e8c206f72f...05f942cef695"",""commits"":[{""id"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""distinct"":true,""message"":""test add/change/delete"",""timestamp"":""2013-12-06T15:12:00-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/05f942cef695ad37a99f0978b84b25b7f1366f1b"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test3.txt""],""removed"":[""test2.txt""],""modified"":[""test.txt""]}],""head_commit"":{""id"":""05f942cef695ad37a99f0978b84b25b7f1366f1b"",""distinct"":true,""message"":""test add/change/delete"",""timestamp"":""2013-12-06T15:12:00-08:00"",""url"":""https://github.com/omeriko9/zohargallery/commit/05f942cef695ad37a99f0978b84b25b7f1366f1b"",""author"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""committer"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com"",""username"":""omeriko9""},""added"":[""test3.txt""],""removed"":[""test2.txt""],""modified"":[""test.txt""]},""repository"":{""id"":14746532,""name"":""zohargallery"",""url"":""https://github.com/omeriko9/zohargallery"",""description"":"""",""watchers"":0,""stargazers"":0,""forks"":1,""fork"":false,""size"":44892,""owner"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""},""private"":false,""open_issues"":0,""has_issues"":true,""has_downloads"":true,""has_wiki"":true,""language"":""JavaScript"",""created_at"":1385555639,""pushed_at"":1386371524,""master_branch"":""master""},""pusher"":{""name"":""omeriko9"",""email"":""omeriko9@gmail.com""}}";

        if (!IsPostBack)
        {
            string gitResponse = json;//"";

            if (!String.IsNullOrEmpty(gitResponse = Request.Headers["texttodisplay"])) // we have a winner
            {
                var decoded = Server.UrlDecode(gitResponse);
                Application["gitResponse"] = decoded;
                Deploy(decoded);
            }
        }

        if (Application["gitResponse"] != null)
            lblText.Text = Application["gitResponse"].ToString();
    }

    private void Deploy(string gitResponse)
    {
        var res = new JavaScriptSerializer();
        jobj objResp = null;
        try
        {
            objResp = (jobj)res.DeserializeObject(gitResponse.Replace("payload=", ""));
        }
        catch (Exception ex)
        {
            throw new Exception(String.Format
            ("Cannot parse git response: \"{0}\"", gitResponse), ex) ;

        }
        var repoName = (objResp["repository"] as jobj)["name"].ToString();
        git2ftp_Projects proj;
        git2ftp_Users user;
        using (var a = new git2ftpEntities())
        {
            proj = a.git2ftp_Projects.Where(x => x.GitRepositoryName == repoName).First();
            user = a.git2ftp_Users.Where(x => x.Username == proj.git2ftp_Users.Username).First();
        }
        Action<string> log = (x) =>
        {
            try
            {
                using (var a = new git2ftpEntities())
                {
                    a.git2ftp_Log.Add(new git2ftp_Log()
                    {
                        ProjectID = proj.pKey,
                        GitHubJSON = gitResponse.Length > 4000 ? string.Concat(gitResponse.Take(4000)) : gitResponse,
                        State = x,
                        DateTime = DateTime.Now
                    });
                    a.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    throw new Exception("DB Validation error: " + eve.ValidationErrors.First().ErrorMessage);
                }
            }
        };

        log("Fetching");

        var ftppass = proj.FTPPassword;
        var gitHub = new GitHubFacade(proj.GitOwner, proj.GitRepositoryName, proj.GitApiKey);

        log("Connecting to FTP");

        var ftp = new FTPFacade(proj.FTPAddress, proj.FTPUsername, proj.FTPPassword);
        var head = objResp["head_commit"];
        var arrAdded = ((object[])((jobj)head)["added"]);
        var arrRemoved = ((object[])((jobj)head)["removed"]);
        var arrChanged = ((object[])((jobj)head)["modified"]);

        Array.ForEach(arrAdded, y =>
          {
              var fileFullPath = y.ToString();
              log("Adding file: " + fileFullPath);

              var fileContent = gitHub.GetFile(fileFullPath);
              if (fileContent == null)
                  ftp.CreateFolder(fileFullPath);
              else
                  ftp.UploadFile(fileContent, fileFullPath);

              log("Added file " + fileFullPath + " successfully.");
          });
        Array.ForEach(arrRemoved, y =>
        {
            var fileFullPath = y.ToString();
            log("deleting file: " + fileFullPath);
            ftp.DeleteFile(fileFullPath, false);
            log("Deleted file " + fileFullPath + " successfully.");
        });
        Array.ForEach(arrChanged, y =>
        {
            var fileFullPath = y.ToString();
            log("Uploading file: " + fileFullPath);

            var fileContent = gitHub.GetFile(fileFullPath);
            if (fileContent == null)
                ftp.CreateFolder(fileFullPath);
            else
                ftp.UploadFile(fileContent, fileFullPath);

            log("Uploaded file " + fileFullPath + " successfully.");
        });

        var ll = "3";

        log("Completed Successfully");

    }

}
