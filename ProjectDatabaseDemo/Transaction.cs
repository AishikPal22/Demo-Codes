//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectDatabaseDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int CategoryId { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
