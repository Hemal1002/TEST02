//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFirst_Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    
    public partial class Student
    {
        public string StudentNumber { get; set; }
        public string name { get; set; }
        public decimal dp { get; set; }
        public decimal examMark { get; set; }
        public decimal finalMark { get; set; }
    }
}