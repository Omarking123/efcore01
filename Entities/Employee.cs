using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore01.Entities
{
    //Entity
    //first way  ..By Convention [default Behaviour] 
    //    internal class Employee
    //    {
    //        //public int Id { get; set; } //it will be the Pk cuz it's call Id 
    //        //public string Name { get; set; } //reference type : Requried  
    //        //public  int Age { get; set; }
    //        //public  double Salary { get; set; }
    //        //public string  Email { get; set; }
    //        //public DateTime DateOfCreation { get; set; }
    //    }

    [Table("Hamda" , Schema ="dbo")]

    class Empoylee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [Column("EmpName",TypeName ="varchar")]
        [MaxLength (50)]

        [StringLength(50 , MinimumLength =10)]
        public string? Name { get; set; }

        [Range (20,60)]
        public  int? Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}
