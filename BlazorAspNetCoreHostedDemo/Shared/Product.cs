using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAspNetCoreHostedDemo.Shared
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string Pictures { get; set; }

        public double Price1 { get; set; }

        public double Price2 { get; set; }
    }
}
