//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Investment
    {
        public int Investment_ID { get; set; }
        public System.DateTime Date_Opened { get; set; }
        public System.DateTime Date_Ending { get; set; }
        public int Interest { get; set; }
        public decimal Monthly_Contribution { get; set; }
        public int Period { get; set; }
        public decimal Expected_Amount { get; set; }
    }
}
