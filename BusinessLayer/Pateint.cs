using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class Pateint : Human
    {
        public enum BloodTypes
        {
           A,
           B,
           O,
           AB
        }
        [Required]
        public BloodTypes BloodType { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
        [ForeignKey("Doctor")]
        public int DocId { get; set; }
        public Sickness Sickness { get; set; }
        [ForeignKey("Sickness")]
        public int SicknessId { get; set; }
        public Pateint(string name, string surname, int age, BloodTypes bloodType, Doctor doctor) : base(name, surname, age)
        {
            BloodType = bloodType;
            Doctor = doctor;
        }
        private Pateint()
        {

        }
    }
}
