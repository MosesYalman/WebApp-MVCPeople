﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models.ViewModels
{
    public class PeopleViewModel
    {
        
        public List<Person> PeopleListView { get; set; }

        public string FilterString { get; set; }

        public PeopleViewModel()
        { PeopleListView = new List<Person>(); }
        
    }
}
