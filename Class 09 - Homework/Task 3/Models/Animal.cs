using System;
using System.Collections.Generic;
using System.Text;
using Task_3.Enums;

namespace Task_3.Models
{
    public class Animal
    {
        // * Create a class Animal. Each Animal has name, color, age and Gender.
        // * Use enum for Gender.
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
