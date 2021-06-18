﻿using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public interface IUserRepository
    {
        void Update(User user);
        User GetUser(string id);
    }
}
