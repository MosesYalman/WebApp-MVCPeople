﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Person()
        { }
        public Person(string name)
        {
            Name = name;
        }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; }
        public List<PersonLanguage> PersonLanguages { get; set; }
        // Id, Name, Phone number, City name
    }
}
