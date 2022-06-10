using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Doctor : Human
    {
       [Required]
       [Range(0, 90, ErrorMessage = "Experience must be between 0 and 90")]
        public int Experiennce { get; set; }
        public IEnumerable<Pateint> Pateints { get; set; }
        public Doctor(string name, string surname, int age, int exp) : base(name, surname, age)
        {
            exp = Experiennce;
        }
        private Doctor()
        {

        }
    }
}
