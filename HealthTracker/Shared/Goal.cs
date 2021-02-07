using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthTracker.Shared
{
    public class Goal
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StartingWeight { get; set; }
        public int GoalWeight { get; set; }
        public int AmountLost { get; set; }
        public int AmountGained { get; set; }
    }
}
