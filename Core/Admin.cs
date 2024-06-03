using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("AdminTbl")]
    public class Admin
    {
        [Key]
        public Int64 AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }

    }
}
