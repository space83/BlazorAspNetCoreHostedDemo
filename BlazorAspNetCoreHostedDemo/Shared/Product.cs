using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAspNetCoreHostedDemo.Shared
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Pictures { get; set; }

        public double Price1 { get; set; }

        public double Price2 { get; set; }
    }
}
