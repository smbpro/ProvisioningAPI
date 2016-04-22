using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models.Users
{
    public enum UserStatus : int
    {
        Active = 1,
        Disabled = 2
    }
}