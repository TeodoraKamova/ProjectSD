using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public enum BloodTypes
    {
        A,
        B,
        O,
        AB
    }
    public class Patient : Human
    {
        
        [Required]
        public BloodTypes BloodType { get; set; }

        public Doctor Doctor { get; set; }

        public Sickness Sickness { get; set; }

        public Patient(string name, string surname, int age, BloodTypes bloodType) : base(name, surname, age)
        {
            BloodType = bloodType;
        }
        private Patient()
        {

        }
    }
}
