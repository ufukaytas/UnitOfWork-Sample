//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aytass.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int ContentID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string MetaK { get; set; }
        public string MetaD { get; set; }
        public string Picture { get; set; }
        public string LongDescription { get; set; }
        public string Tag { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
