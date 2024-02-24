﻿using eFurnitureProject.Application.Commons;
using eFurnitureProject.Application.Interfaces;
using eFurnitureProject.Application.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eFurnitureProject.API.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<ApiResponse<UserRegisterDTO>> RegisterAsync(UserRegisterDTO registerObject)
        {
            return await _authenticationService.RegisterAsync(registerObject);

        }

        [HttpPost]
        public async Task<ApiResponse<string>> LoginAsync(UserLoginDTO loginObject)
        {
            return await _authenticationService.LoginAsync(loginObject); 
        }
    }
}
