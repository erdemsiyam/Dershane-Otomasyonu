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
    
    public partial class projeEntities3 : DbContext
    {
        public projeEntities3()
            : base("name=projeEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_Ogrenci_Deneme_Ara_Result> SP_Ogrenci_Deneme_Ara(string deneme_seviye, Nullable<System.DateTime> deneme_tarih)
        {
            var deneme_seviyeParameter = deneme_seviye != null ?
                new ObjectParameter("deneme_seviye", deneme_seviye) :
                new ObjectParameter("deneme_seviye", typeof(string));
    
            var deneme_tarihParameter = deneme_tarih.HasValue ?
                new ObjectParameter("deneme_tarih", deneme_tarih) :
                new ObjectParameter("deneme_tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Ogrenci_Deneme_Ara_Result>("SP_Ogrenci_Deneme_Ara", deneme_seviyeParameter, deneme_tarihParameter);
        }
    }
}
