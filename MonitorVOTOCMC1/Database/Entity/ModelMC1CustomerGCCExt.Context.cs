﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitorVOTOCMC1.Database.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BOWTMVOTORANTIMEntities : DbContext
    {
        public BOWTMVOTORANTIMEntities()
            : base("name=BOWTMVOTORANTIMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mc1_CustomerGCCExt> mc1_CustomerGCCExt { get; set; }
    }
}
