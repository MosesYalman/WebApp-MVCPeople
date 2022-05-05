using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models.Services
{
    interface IPeopleService
    {
        // ▪ Person Add(CreatePersonViewModel person)
          Person Create(CreatePersonViewModel createPerson);
        //▪ List<Person> All()
        List<Person> GetAll();
        //▪ List<Person> Search(string search)
        List<Person> Search(string Search);
        //▪ Person FindById(int id)
         Person FindById(int id);
        //▪ bool Edit(int id, CreatePersonViewModel person)
         bool Edit(int id, CreatePersonViewModel editPerson);
        //▪ bool Remove(int id)
          void Remove(int id);

        //PeopleService – Implements IPeopleService interface.
    }
}
