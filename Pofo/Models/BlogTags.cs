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
    
    public partial class BlogTags
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int SingleBlogId { get; set; }
    
        public virtual SingleBlog SingleBlog { get; set; }
        public virtual Tags Tags { get; set; }
    }
}