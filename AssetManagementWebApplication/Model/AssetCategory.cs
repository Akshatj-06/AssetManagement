using System.ComponentModel.DataAnnotations;

namespace AssetManagementWebApplication.Model
{
	public class AssetCategory
	{
        [Key]
		public int Category_Id { get; set; }

        [Required]
        public string Category_Name { get; set; }
		public required string Category_Discription { get; set; }

        public ICollection<Asset>? Assets { get; set; }
		
	}
}
