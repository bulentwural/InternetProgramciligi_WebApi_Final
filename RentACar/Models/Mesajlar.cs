
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RentACar.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Mesajlar
{

    public int MesajId { get; set; }

    public int MesajGonderenId { get; set; }

    public int MesajAlanId { get; set; }

    public string MesajIcerik { get; set; }

    public string MesajTarihi { get; set; }

    public string MesajKonu { get; set; }



    public virtual Kullanici Kullanici { get; set; }

    public virtual Kullanici Kullanici1 { get; set; }

}

}
