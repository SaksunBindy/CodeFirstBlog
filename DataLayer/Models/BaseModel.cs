using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public  class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}