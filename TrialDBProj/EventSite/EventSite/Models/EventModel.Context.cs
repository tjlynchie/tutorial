﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventDatabaseEntities1 : DbContext
    {
        public EventDatabaseEntities1()
            : base("name=EventDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventService> EventServices { get; set; }
        public virtual DbSet<EventUser> EventUsers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    }
}
