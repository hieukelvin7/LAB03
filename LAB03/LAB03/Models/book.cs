namespace LAB03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("book")]
    public partial class book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="ID không được để trống")]
        public int id { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [StringLength(50)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Title không được để trống")]
        [StringLength(100,ErrorMessage ="Kí tự không quá 100")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống")]
        [StringLength(100)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [StringLength(50)]
        public string Image { get; set; }


        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1000,1000000,ErrorMessage ="Giá từ 1000 - 1000000")]
        public int? Price { get; set; }
    }
}
