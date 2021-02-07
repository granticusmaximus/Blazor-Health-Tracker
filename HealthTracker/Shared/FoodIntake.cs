using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthTracker.Shared
{
    public class FoodIntake
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FoodName { get; set; }
        public int Calories { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
        public int? Fiber { get; set; }
        public int Protein { get; set; }
        public int TotalNeeded { get; set; }
        public int TotalTaken { get; set; }
    }
}
