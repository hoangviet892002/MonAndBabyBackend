﻿using eFurnitureProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFurnitureProject.Application.Repositories
{
    public interface IUserRepository
    {
        Task<bool> CheckPhoneNumberExisted(string phoneNumber);
        Task<bool> CheckEmailNameExisted(string emailName);
        Task<bool> CheckUserNameExisted(string userName);
        Task<User> GetUserByUserNameAndPasswordHash(string username, string passwordHash);
        Task<User> AddAsync(User user);

    }
}
