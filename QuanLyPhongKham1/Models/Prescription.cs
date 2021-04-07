namespace QuanLyPhongKham1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prescription")]
    public partial class Prescription
    {
        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string StaffSetUp { get; set; }

        public int IDCustomer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfCreate { get; set; }

        public int TotalPrice { get; set; }

        public int IDStatusPrescription { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PrescriptionDetails PrescriptionDetails { get; set; }

        public virtual StatusPrescription StatusPrescription { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
