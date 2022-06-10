using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Sickness
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [Range(1,10, ErrorMessage ="Level of sickness must be between 1 and 10")]
        public int Level { get; set; }
        [Required]
        [MaxLength(50)]
        public string Symptoms { get; set; }
        public IEnumerable<Pateint> Pateints { get; set; }

        public Sickness(string name, int level, string symptoms)
        {
            Name = name;
            Level = level;
            Symptoms = symptoms;
        }
        private Sickness()
        {

        }
    }
}
