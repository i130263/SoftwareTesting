//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP1_Module1_Version1._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class conversation
    {
        public int idconversation { get; set; }
        [Required]
        public string message { get; set; }
        public string name { get; set; }
        public System.DateTime time { get; set; }
        public int idea { get; set; }
        public int group { get; set; }
    
        public virtual fyp_group fyp_group { get; set; }
        public virtual idea idea1 { get; set; }
    }
}
