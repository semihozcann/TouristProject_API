using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace touristProject.Entities.DTOs.Nutrients
{
    public class NutrientUpdateDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string Ingredients { get; set; }
        public string ImageUrl { get; set; }
    }
}
