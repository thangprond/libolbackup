//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_DIC_CLASS_BBK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_DIC_CLASS_BBK()
        {
            this.ITEM_BBK = new HashSet<ITEM_BBK>();
        }
    
        public string DisplayEntry { get; set; }
        public int ID { get; set; }
        public string AccessEntry { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Nullable<int> DicItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_BBK> ITEM_BBK { get; set; }
    }
}
