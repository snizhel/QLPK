namespace QuanLyPhongKham1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicine")]
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            PrescriptionDetails = new HashSet<PrescriptionDetails>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int IDMedicineType { get; set; }

        [Required]
        [StringLength(100)]
        public string Unit { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual MedicineType MedicineType { get; set; }

        public virtual MedicineType MedicineType1 { get; set; }

        public virtual MedicineType MedicineType2 { get; set; }

        public virtual MedicineType MedicineType3 { get; set; }

        public virtual MedicineType MedicineType4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionDetails> PrescriptionDetails { get; set; }
    }
}
