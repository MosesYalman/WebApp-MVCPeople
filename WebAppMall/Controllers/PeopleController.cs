using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMall.Models.Repos;
using WebAppMall.Models.Services;
using WebAppMall.Models.ViewModels;

namespace WebAppMall.Controllers
{
    public class PeopleController : Controller
    {

        IPeopleService _peopleService;//<--------Your PeopleController shall use the PeopleService class
        public PeopleController()
        {
            //_peopleService = new PeopleService(new InMemoryPeopleRepo());
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult People()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePersonViewModel());
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
           
     
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {

            return View();
        }

        public IActionResult Delete(int id)
        {

            return View();
        }
        [HttpPost]
        public IActionResult People(string search)
        {
           return View();
        }




        //**********************************// AJAX //*******************************************//

        // 3 assainment

        //  • After you have loaded the html page, there shall be no more reloads of the page, 
        //changing the page content using JavaScript is okay.
        //• Three buttons that are hocked up to JavaScript
        //1. People – use Ajax Get to fetch the PartialView with list of people and display it on
        //the page using JavaScript. 
        //2. Details – use an input element so the user can type in an Id of a person and when
        //thy press the button, make an Ajax Post with Id to fetch a PartialView on the
        //person that has the Id and display it on the page using JavaScript. 
        //3. Delete – use the same input element as Details but when thy press the Delete
        //button, make an Ajax Post with Id to a Delete action that removes the person
        //that has the Id and display a message on the page if person was removed or not
        //on the page using JavaScript. 
        //• The result from pressing any of the three buttons shall be displayed in one element
        //overwriting what was there before.
        //Code Requirements:  Create Actions that return PartialView for People button & Details button and return 
        //status codes for the Delete action.
        //• Use Ajax to get/post and sync the frontend/backend by using the results from the
           //controller actions.
      
        
        
        
    }
}
