//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthyANDTastyModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diet()
        {
            this.Meals = new HashSet<Meal>();
            this.Users = new HashSet<User>();
        }
    
        public int DietID { get; set; }
        public string DietName { get; set; }
        public int carbsPercent { get; set; }
        public int ProtienPercent { get; set; }
        public int vitaminPercent { get; set; }
        public Nullable<int> fatsPercent { get; set; }
        public int mineralsPercent { get; set; }
        public string DietDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meal> Meals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
