//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOV_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrowing
    {
        public int id { get; set; }
        public int member_id { get; set; }
        public int bookdetails_id { get; set; }
        public System.DateTime borrow_date { get; set; }
        public Nullable<System.DateTime> return_date { get; set; }
        public Nullable<decimal> fine { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> last_updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    
        public virtual BookDetail BookDetail { get; set; }
        public virtual Member Member { get; set; }
    }
}
