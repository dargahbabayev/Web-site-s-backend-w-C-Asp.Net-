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
    
    public partial class Settings
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string SecondLogo { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Dribble { get; set; }
        public string Google { get; set; }
        public string Intstagram { get; set; }
        public string AboutAgaency { get; set; }
        public Nullable<int> LangId { get; set; }
    
        public virtual Languages Languages { get; set; }
    }
}