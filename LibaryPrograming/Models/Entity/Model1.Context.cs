//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibaryPrograming.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KutuphaneDbEntities : DbContext
    {
        public KutuphaneDbEntities()
            : base("name=KutuphaneDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORIs { get; set; }
        public virtual DbSet<TBLKITAPLAR> TBLKITAPLARs { get; set; }
        public virtual DbSet<TBLODUNC> TBLODUNCs { get; set; }
        public virtual DbSet<TBLUYE> TBLUYEs { get; set; }
        public virtual DbSet<TBLYAZAR> TBLYAZARs { get; set; }
    }
}
