﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class surmanEntities : DbContext
    {
        public surmanEntities()
            : base("name=surmanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_answers> tb_answers { get; set; }
        public virtual DbSet<tb_groups> tb_groups { get; set; }
        public virtual DbSet<tb_questions> tb_questions { get; set; }
        public virtual DbSet<tb_surveys> tb_surveys { get; set; }
        public virtual DbSet<tb_userAnswers> tb_userAnswers { get; set; }
        public virtual DbSet<tb_users> tb_users { get; set; }
        public virtual DbSet<tb_translations> tb_translations { get; set; }
        public virtual DbSet<tb_words> tb_words { get; set; }
        public virtual DbSet<vw_useranswer> vw_useranswer { get; set; }
        public virtual DbSet<vw_userdetails> vw_userdetails { get; set; }
    }
}