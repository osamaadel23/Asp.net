//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Real_State_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class notification
    {
        public int id { get; set; }
        public string text { get; set; }
        public Nullable<int> userId { get; set; }
        public byte[] date { get; set; }
        public Nullable<int> seen { get; set; }
    
        public virtual users users { get; set; }
    }
}
