﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentPerformanceWebsite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Students : DbContext
    {
        public Students()
            : base("name=Students")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_Group421> t_Group421 { get; set; }
        public virtual DbSet<View_BestStudents> View_BestStudents { get; set; }
        public virtual DbSet<View_WorseStudents> View_WorseStudents { get; set; }
    }
}
