using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public abstract class Human
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required]
        [Range(0, 130, ErrorMessage = "Age must be between 0 and 130")]
        public int Age { get; set; }

        protected Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        protected Human()
        {

        }
    }
}
