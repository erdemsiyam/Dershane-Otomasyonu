﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DershaneOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class projeEntities5 : DbContext
    {
        public projeEntities5()
            : base("name=projeEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_Ogrenci_Ara_Result> SP_Ogrenci_Ara(string kelime)
        {
            var kelimeParameter = kelime != null ?
                new ObjectParameter("kelime", kelime) :
                new ObjectParameter("kelime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Ogrenci_Ara_Result>("SP_Ogrenci_Ara", kelimeParameter);
        }
    }
}
