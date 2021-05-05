using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Models
{
    public class DetailLeaveTypeViewModel
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class CreateLeaveTypeViewModel 
    {
        
        [Required]
        public string Name { get; set; }
     
    }
}
