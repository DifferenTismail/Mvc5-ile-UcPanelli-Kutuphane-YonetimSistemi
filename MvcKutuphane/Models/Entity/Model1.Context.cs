﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphane.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbKutuphaneEntities : DbContext
    {
        public DbKutuphaneEntities()
            : base("name=DbKutuphaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Cezalar> Tbl_Cezalar { get; set; }
        public virtual DbSet<Tbl_Hareket> Tbl_Hareket { get; set; }
        public virtual DbSet<Tbl_Kasa> Tbl_Kasa { get; set; }
        public virtual DbSet<Tbl_Kategori> Tbl_Kategori { get; set; }
        public virtual DbSet<Tbl_Kitap> Tbl_Kitap { get; set; }
        public virtual DbSet<Tbl_Personel> Tbl_Personel { get; set; }
        public virtual DbSet<Tbl_Uyeler> Tbl_Uyeler { get; set; }
        public virtual DbSet<Tbl_Yazar> Tbl_Yazar { get; set; }
    }
}
