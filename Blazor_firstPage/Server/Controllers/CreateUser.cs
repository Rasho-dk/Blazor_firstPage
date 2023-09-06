﻿using Blazor_firstPage.Server.Service.UserService;
using Blazor_firstPage.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_firstPage.Server.Controllers
{
    public class CreateUser : ControllerBase
    {
        [BindProperty]
        public User User { get; set; }

        private UserService userService;

        private readonly ILogger<CreateUser> _logger;

        public CreateUser(UserService userService, ILogger<CreateUser> _logger)
        {
            this.userService = userService;
            this._logger = _logger;
        }

 
        [HttpPost("CreateUser")]
        public IActionResult OnPost()
        {
            
                //Users.Add(user);
                userService.AddUser(new Shared.User(User.Id,User.Name,User.Email));
                return RedirectToPage("/ShowUser");
            
        }

    }
}
