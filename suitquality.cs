//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xBiddingMaintenance_1
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class suitquality
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public suitquality()
        {
            this.bids = new ObservableCollection<bid>();
        }
    
        public int SuitQualityId { get; set; }
        public int MethodRef { get; set; }
        public string Description { get; set; }
        public int SuitHCP { get; set; }
        public int NumberHons { get; set; }
        public int ReferencedSuitRef { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<bid> bids { get; set; }
        public virtual method method { get; set; }
    }
}
