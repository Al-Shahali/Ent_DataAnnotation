using Ent_DataAnnotation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ent_DataAnnotation
{
    class AppDBContext :DbContext
    {

        //DataBase Connection 
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source =.\sqlexpress; AttachDbFilename="+ Path.GetFullPath(@"App_Data\BKStore.mdf;")+ @";Integrated Security=True;User Instance=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region product to stores relation
            modelBuilder.Entity<Store>()
                .HasMany(p => p.products)
                .WithMany(s => s.stores)
                .UsingEntity<Stock>(
                    j => j
                    .HasOne(s => s.product)//stock to product
                    .WithMany(p => p.stocks)
                    .HasForeignKey(s => s.product_id),
                    j => j
                    .HasOne(k => k.store) //stock to store
                    .WithMany(s => s.stocks)//store to stock
                    .HasForeignKey(k => k.store_id),
                    j =>
                    {
                        j.HasKey(p => new { p.product_id, p.store_id });
                    }
                );
            #endregion

            //modelBuilder.Entity<Product>()
            //    .HasMany(o => o.Orders)
            //    .WithMany(p => p.products)
            //    .UsingEntity<order_items>(
            //        c => c
            //        .HasOne(r => r.product)
            //        .WithMany(oi=>oi.order_Items)
            //        .HasForeignKey(o=>o.product_id),
            //        c=>c
            //        .HasOne(p=>p.order)
            //        .WithMany(oi=>oi.order_Items)
            //        .HasForeignKey(p=>p.order_id),
            //        c =>
            //        {
            //            c.HasKey(k => new { k.order_id, k.item_id });
            //        }
            //    );

            modelBuilder.Entity<Order>()
                .HasMany(P => P.products)
                .WithMany(or => or.Orders)
                .UsingEntity<order_items>(
                item=>item
                .HasOne(i=>i.product)
                .WithMany(p=>p.order_Items)
                .HasForeignKey(i=>i.product_id),
                item=>item
                .HasOne(i=>i.order)
                .WithMany(o=>o.order_Items)
                .HasForeignKey(i=>i.order_id),
                item =>
                {
                    item.HasKey(k => new { k.order_id, k.item_id });
                }
                
                );

            //modelBuilder.Entity<order_items>()
            //    .HasKey(k => new { k.order_id, k.item_id });

            //modelBuilder.Entity<order_items>()
            //    .HasOne(o => o.order)
            //    .WithMany(oi => oi.order_Items)
            //    .HasForeignKey(o => o.order_id);

            //modelBuilder.Entity<order_items>()
            //    .HasOne(p => p.product)
            //    .WithMany(oi => oi.order_Items)
            //    .HasForeignKey(p => p.product_id);


        }
        public DbSet<Category> categories { set; get; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<order_items> order_Items { get; set; }


    }

    //public class Post
    //{

    //modelBuilder.Entity<Post>()
    //    .HasMany(p => p.Tags)
    //    .WithMany(t => t.Posts)
    //    .UsingEntity<PostTage>(
    //        j=>j
    //        .HasOne(pt=>pt.Tag) //post tag =>tag
    //        .WithMany(t=>t.PostTage)//tag =>post tag
    //        .HasForeignKey(pt=>pt.Tagid),

    //        j=>j
    //        .HasOne(pt=>pt.Post)
    //        .WithMany(p=>p.PostTages)
    //        .HasForeignKey(pt=>pt.Postid)
    //    );
    //    public int postid { get; set; }

    //    public string title { get; set; }
    //    public ICollection<Tag> Tags { get; set; }
    //    public List<PostTage> PostTages { get; set; }

    //}

    //public class Tag
    //{
    //    public int tagid { get; set; }
    //    public string content { get; set; }

    //    public ICollection<Post> Posts  { get; set; }
    //    public List<PostTage> PostTage { get; set; }

    //}

    //public class PostTage
    //{
    //    public int Postid { get; set; }

    //    public int Tagid { get; set; }

    //    public Post Post { get; set; }
    //    public Tag Tag { get; set; }
    //}
}
