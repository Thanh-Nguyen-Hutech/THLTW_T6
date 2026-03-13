using System.ComponentModel.DataAnnotations;

namespace WebBanHang_NGUYEN_VAN_THANH_2380602048.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
