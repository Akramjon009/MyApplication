using MyApplication.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Domain.Entities.Models
{
    public class Car
    {
        public int Id { get; set; }

        [MinLength(3),MaxLength(30)]
        public required string Model { get; set; }
        public required string Brand { get; set; }
        public string? Description { get; set; }
        public Condition CarCondition { get; set; }
        public decimal Price { get; set; }
    }
}
