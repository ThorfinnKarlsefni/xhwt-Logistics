﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Logistics.Domain.Entities.Identity
{
    public class UserRole : IdentityUserRole<int>
    {
        public UserRole()
        {
        }
    }
}

