﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Хакатон.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HakatonBuildInfoEntities3 : DbContext
    {
        public HakatonBuildInfoEntities3()
            : base("name=HakatonBuildInfoEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABuidingInfo> ABuidingInfo { get; set; }
        public virtual DbSet<ABuilding> ABuilding { get; set; }
        public virtual DbSet<AJournal> AJournal { get; set; }
        public virtual DbSet<AJournalViolations> AJournalViolations { get; set; }
        public virtual DbSet<AUser> AUser { get; set; }
        public virtual DbSet<AWorkJournal> AWorkJournal { get; set; }
    }
}
