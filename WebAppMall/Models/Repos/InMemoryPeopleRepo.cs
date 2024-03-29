﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models.Repos
{
    public class InMemoryPeopleRepo:IPeopleRepo

    {
        // Private static List of Person. 
        // Private static int idCounter.


         private static List<Person> peopleList = new List<Person>();
        private static int idCounter = 0;

        public Person Create(Person person)
        {
            person.Id = ++idCounter;
            peopleList.Add(person);

            return person;
        }

        public List<Person> GetAll()
        {
            return peopleList;
        }

        public Person GetById(int id)
        {
            Person person = null;
            foreach (Person thisPerson in peopleList)
            {
                if (thisPerson.Id == id)
                {
                    person = thisPerson;
                    break;
                    
                }
            }
            return person;
        }

        public bool Update(Person person)
        {
            Person orgPerson = GetById(person.Id);
            if (orgPerson == null)
            {
                return false;
            }
            else
            {
                orgPerson.Name = person.Name;
                orgPerson.PhoneNumber = person.PhoneNumber;
               
                
                return true;
            }
        }
        public void Delete(Person person)
        {
            peopleList.Remove(person);
        }
    }
}
