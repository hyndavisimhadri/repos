using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudOperations.Models;
using CrudOperations.Services;

namespace CrudOperations.Controllers
{
    public class UserController : ApiController
    {
        private UserServices _addServices;

        public UserController()
        {
            _addServices = new UserServices();
        }
        public UserController(UserServices addServices)
        {
            _addServices = addServices;
        }


        public string Post(UserTable user)
        {
            _addServices.Post(user);
            return "Customer Inserted successfully";
        }

        public IEnumerable<UserTable> GetAll()
        {
            return _addServices.GetAll();
        }

        public string Put(UserTable user)
        {
            _addServices.Put(user);
            return "Customers updated";
        }
        public string Delete(int ID)
        {
            _addServices.Delete(ID);

            return "customres deleted";
        }
        public UserTable GetbyId(int ID)
        {
            return (_addServices.GetbyId(ID));


        }
    }
}
