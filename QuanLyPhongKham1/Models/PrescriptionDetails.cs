namespace QuanLyPhongKham1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrescriptionDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPrescription { get; set; }

        public int IDMedicine { get; set; }

        public int Count { get; set; }

        public int Price { get; set; }

        public int TotalPrice { get; set; }

        public virtual Medicine Medicine { get; set; }

        public virtual Prescription Prescription { get; set; }
    }
}
