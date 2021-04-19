using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio.Data
{
    public class Project
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}