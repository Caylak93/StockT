using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Service.Lib.Model
{
    
   public class CategoryModel
    {
       [Display(Name = "Kategori Id")]
        public Guid CategoryId { get; set; }
       [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
        [Display(Name = "Kategori Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Fotoğraf")]
        public byte[] Picture { get; set; }
    }
}
