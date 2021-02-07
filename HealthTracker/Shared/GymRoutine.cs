using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthTracker.Shared
{
    public class GymRoutine
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public RoutineTypes Routines { get; set; }
        [Display(Name = "Calories Burned")]
        public int CaloriesBurned { get; set; }
    }

    public enum RoutineTypes
    {
        None,
        Cardio = 1,
        [Display(Name = "Weight Training")]
        WeightTraining = 2,
        Core = 3
    }
}
