using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Business.ViewModels;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Interfaces;

namespace WebAPI.Policy

{
    public class Policies
    {
        public const string SuperOnly = "SuperOnly";

        public const string AdminOwner = "AdminOwner";

        public const string User = "User";

        public const string All = SuperOnly + "," + AdminOwner + "," + User;

        public const string AllAdmins = SuperOnly + "," + AdminOwner;

        public static AuthorizationPolicy SuperOnlyPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser() // the user must be authenticated to comply with the policy
                .RequireRole(SuperOnly) // the user must belong to one of the roles in the roles array
                .Build(); // builds a new AuthorizationPolicy from the requirements in this instance
        }

        public static AuthorizationPolicy AdminOwnerPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                .RequireRole(AdminOwner)
                .Build();
        }

        public static AuthorizationPolicy UserPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                .RequireRole(User)
                .Build();
        }

        //[Authorize(Roles = Policies.X)] - in controllers
    }
}
