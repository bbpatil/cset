//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASSESSMENT_IRP_HEADER
    {
        public int HEADER_RISK_LEVEL_ID { get; set; }
        public int ASSESSMENT_ID { get; set; }
        public int IRP_HEADER_ID { get; set; }
        public Nullable<int> RISK_LEVEL { get; set; }
    
        public virtual ASSESSMENT ASSESSMENT { get; set; }
        public virtual IRP_HEADER IRP_HEADER { get; set; }
    }
}