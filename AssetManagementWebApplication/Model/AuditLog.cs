using System.ComponentModel.DataAnnotations;

namespace AssetManagementWebApplication.Model
{
	public class AuditLog
	{
        [Key]
		public int Audit_Id { get; set; }

        [Required]
        public int Employee_Id { get; set; }
        public DateTime Audit_Date { get; set; }
		public required string Audit_Discription { get; set; }
        public required string Audit_Status { get; set; }

        public ICollection<User>? User { get; set; }
	}
}
