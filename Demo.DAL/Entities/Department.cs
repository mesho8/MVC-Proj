using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required!!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is required!!")]
        [MaxLength(50 , ErrorMessage = "Max Length is 50 Chars")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
