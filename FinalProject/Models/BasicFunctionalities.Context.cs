﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class FinalProjectdbEntities5 : DbContext
    {
        public FinalProjectdbEntities5()
            : base("name=FinalProjectdbEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<T_ErrorLogs> T_ErrorLogs { get; set; }
        public DbSet<T_OTP_Details> T_OTP_Details { get; set; }
        public DbSet<T_PasswordHistoryLog> T_PasswordHistoryLog { get; set; }
        public DbSet<T_Roles> T_Roles { get; set; }
        public DbSet<T_Users> T_Users { get; set; }
    
        public virtual int Proc_AddRole(string param1)
        {
            var param1Parameter = param1 != null ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_AddRole", param1Parameter);
        }
    
        public virtual int Proc_ModifyRole(Nullable<int> param1, string param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            var param2Parameter = param2 != null ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_ModifyRole", param1Parameter, param2Parameter);
        }
    
        public virtual int Proc_RemoveRole(Nullable<int> param1)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_RemoveRole", param1Parameter);
        }
    }
}
