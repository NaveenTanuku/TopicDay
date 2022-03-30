using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopicDay.Models
{
    public class Topics
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
       
        public Available IsAvailable { get; set; }
        public int NumberOfTopicsAvailable { get; set; }


    }
}
