﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Logistics.Domain.Entities.Identity
{
    public class UserClaim : IdentityUserClaim<long>
    {
        public UserClaim()
        {
        }
    }
}

