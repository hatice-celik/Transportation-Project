//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProduct()
        {
            this.TblTransportation = new HashSet<TblTransportation>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSizeType { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> ProductCategory { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTransportation> TblTransportation { get; set; }
        public virtual TblCategory TblCategory { get; set; }
    }
}
