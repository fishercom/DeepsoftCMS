using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LayqaMVC.Repository.Entity;

namespace LayqaMVC.Repository
{
    public class LayqaMVCContext : DbContext
    {
        public LayqaMVCContext()
            : base("name=LayqaMVC")
        {

        }

        public DbSet<AdmProfile> AdmProfiles { get; set; }
        public DbSet<AdmUser> AdmUser { get; set; }
        public DbSet<WebUser> WebUser { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Schema> Schemas { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> PostComments { get; set; }
        //public DbSet<Section> Sections { get; set; }

    }
}
