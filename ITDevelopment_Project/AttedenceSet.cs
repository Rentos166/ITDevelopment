//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITDevelopment_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttedenceSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttedenceSet()
        {
            this.CustomSet = new HashSet<CustomSet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Guarantee { get; set; }
        public int IdDepartment { get; set; }
    
        public virtual Departament Departament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomSet> CustomSet { get; set; }
    }
}
