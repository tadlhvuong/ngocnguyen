using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PreSchoolShared.Data;
using System;
using System.Linq;

namespace PreSchoolShared
{
    public class AppDBContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<AccountLog> AccountLogs { get; set; }

        public virtual DbSet<UserThread> UserThreads { get; set; }
        public virtual DbSet<UserPost> UserPosts { get; set; }

        public virtual DbSet<MediaFile> MediaFiles { get; set; }
        public virtual DbSet<MediaAlbum> MediaAlbums { get; set; }
        public virtual DbSet<Taxonomy> Taxonomies { get; set; }
        public virtual DbSet<BlogPostTaxo> BlogPostTaxos { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }

        public virtual IQueryable<Taxonomy> PostCats
        {
            get { return Taxonomies.Where(x => x.Type == TaxoType.PostCat); }
        }

        public virtual IQueryable<Taxonomy> PostTags
        {
            get { return Taxonomies.Where(x => x.Type == TaxoType.PostTag); }
        }

        public AppDBContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>(b =>
            {
                b.HasIndex(e => e.CreateTime);
                b.HasIndex(e => e.LastLogin);
            });

            builder.Entity<AccountLog>(b =>
            {
                b.HasIndex(e => e.Action);
                b.HasIndex(e => e.LogTime);
            });

            builder.Entity<UserThread>(b =>
            {
                b.HasIndex(e => e.LastPostId);
            });

            builder.Entity<Taxonomy>(b =>
            {
                b.HasIndex(e => e.Type);
                b.HasIndex(e => e.Name);
            });

            builder.Entity<BlogPost>(b =>
            {
                b.HasIndex(e => e.Title);
            });

            builder.Entity<UserInfo>().HasIndex(e => e.FullName);
        }
    }
}
