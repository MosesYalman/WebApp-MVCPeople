using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models.Repos
{
    public interface IPeopleRepo
    {
        //Interface with following methods.
        // ▪ Person Create(Person person)
         Person Create(Person person);
        // ▪ List<Person> Read()
        List<Person> GetAll();
        // ▪ Person Read(int id)
        Person GetById(int id);
        // ▪ bool Update(Person person)
         bool Update(Person person);
        // ▪ bool Delete(Person person)
         void Delete(Person person);
    }
}
