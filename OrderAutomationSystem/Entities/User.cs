using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
    }
}
