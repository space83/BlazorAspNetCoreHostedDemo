using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorAspNetCoreHostedDemo.Shared
{
    //[Serializable]
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Description is mandatory")]
        public string Description { get; set; }

        public string ? Pictures { get; set; }

        [Required(ErrorMessage = "Minimum price is mandatory")]
        public double Price1 { get; set; }

        [Required(ErrorMessage = "Maximum price is mandatory")]
        public double Price2 { get; set; }
    }
}
