//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class userdetail
    {
        public int UserId { get; set; }
        public string BirthDate { get; set; }
        public string IDCard { get; set; }
        public string WebChat { get; set; }
        public Nullable<int> QQ { get; set; }
        public string Email { get; set; }
    }
}