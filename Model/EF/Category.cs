namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitile { get; set; }

        public long ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(255)]
        public string SeoTittle { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(255)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        [StringLength(255)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }

        public bool? ShowOnHome { get; set; }
    }
}
