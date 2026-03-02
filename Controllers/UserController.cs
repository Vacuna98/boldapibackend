using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boldapibackend.Models.DOT;
using boldapibackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace boldapibackend.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        //Global Variable - This will connect to Services
        private readonly UserService _data;

        public UserController(UserService dataFromService)
    {
        _data = dataFromService;
    }

    //Function to add our user type of CreateAccountDTO call UserToAdd this will return bool once our user is added
    //Add User
    // public bool AddUser(CreateAccountDTO UserToAdd)
    // {
    //    // return _data.AddUser(UserToAdd);
    // }




    }
