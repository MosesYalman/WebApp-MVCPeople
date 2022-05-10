using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMall.Models.Services
{
    public interface IPeopleService
    {
          Person Create(CreatePersonViewModel createPerson);
       
        List<Person> GetAll();
        List<Person> Search(string Search);
    
         Person FindById(int id);

         bool Edit(int id, CreatePersonViewModel editPerson);

          void Remove(int id);


     
    }
}
