﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RivicSystems_AspNetMvcDemo
{
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;

    public partial class RivicTrainingDemoEntities : DbContext
    {
        public RivicTrainingDemoEntities()
            : base("name=RivicTrainingDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BestProfessors> BestProfessors { get; set; }
        public DbSet<Student> Student { get; set; }
    
        public virtual ObjectResult<spGetStudents_Result> spGetStudents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetStudents_Result>("spGetStudents");
        }
    }
}
