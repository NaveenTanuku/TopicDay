using TopicDay.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopicDay.ViewModels
{
    public class TopicCreateViewModel
    {

        [Required]
        public string Name { get; set; }
        public Available IsAvailable { get; set; }

        public int NumberOfTopicsAvailable { get; set; }

        
    }
}