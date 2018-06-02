using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.NET_Subject.Models
{
    public class SubjectContext
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public DateTime ExamDate { get; set; }
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
    public class SubjectDBContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<MVC.NET_Subject.Models.SubjectContext> SubjectContexts { get; set; }
    }
}