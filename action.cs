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
    
    public partial class action
    {
        public int ActionId { get; set; }
        public string Description { get; set; }
        public Nullable<int> MethodRef { get; set; }
        public Nullable<int> StageRef { get; set; }
        public int Sequence { get; set; }
        public Nullable<int> SuitActionRef { get; set; }
        public Nullable<int> ShapeActionRef { get; set; }
        public Nullable<int> ProtectiveActionRef { get; set; }
        public Nullable<int> ConventionRef { get; set; }
        public Nullable<int> OpponentBidActionRef { get; set; }
        public Nullable<int> PartnerBidActionRef { get; set; }
        public Nullable<int> SuitQualityActionRef { get; set; }
        public Nullable<int> FourCardMajorActionRef { get; set; }
        public Nullable<int> BalancedActionRef { get; set; }
        public Nullable<int> ltcActionRef { get; set; }
    
        public virtual balancedaction balancedaction { get; set; }
        public virtual convention convention { get; set; }
        public virtual fourcardmajoraction fourcardmajoraction { get; set; }
        public virtual ltcaction ltcaction { get; set; }
        public virtual opponentbidaction opponentbidaction { get; set; }
        public virtual partnerbidaction partnerbidaction { get; set; }
        public virtual protectiveaction protectiveaction { get; set; }
        public virtual shapeaction shapeaction { get; set; }
        public virtual stage stage { get; set; }
        public virtual suitaction suitaction { get; set; }
        public virtual suitqualityaction suitqualityaction { get; set; }
        public virtual method method { get; set; }
    }
}
