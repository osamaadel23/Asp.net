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
    
    public partial class projectteams
    {
        public int Id { get; set; }
        public Nullable<int> projectid { get; set; }
        public Nullable<int> userid { get; set; }
    
        public virtual projects projects { get; set; }
        public virtual users users { get; set; }
    }
}
