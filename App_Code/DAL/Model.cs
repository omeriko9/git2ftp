﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class git2ftp_Log
    {
        public int pKey { get; set; }
        public int ProjectID { get; set; }
        public string GitHubJSON { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string State { get; set; }
    
        public virtual git2ftp_Projects git2ftp_Projects { get; set; }
    }
}
namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class git2ftp_Projects
    {
        public git2ftp_Projects()
        {
            this.git2ftp_Log = new HashSet<git2ftp_Log>();
        }
    
        public int pKey { get; set; }
        public int UserID { get; set; }
        public string FTPAddress { get; set; }
        public string FTPUsername { get; set; }
        public string FTPPassword { get; set; }
        public string GitApiKey { get; set; }
        public string GitRepositoryName { get; set; }
        public string GitOwner { get; set; }
    
        public virtual git2ftp_Users git2ftp_Users { get; set; }
        public virtual ICollection<git2ftp_Log> git2ftp_Log { get; set; }
    }
}
namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class git2ftp_Users
    {
        public git2ftp_Users()
        {
            this.git2ftp_Projects = new HashSet<git2ftp_Projects>();
        }
    
        public int pKey { get; set; }
        public string Username { get; set; }
    
        public virtual ICollection<git2ftp_Projects> git2ftp_Projects { get; set; }
    }
}
