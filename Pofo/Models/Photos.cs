//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pofo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photos
    {
        public int Id { get; set; }
        public string PhotoName { get; set; }
        public Nullable<int> SectionId { get; set; }
    
        public virtual Sections Sections { get; set; }
    }
}