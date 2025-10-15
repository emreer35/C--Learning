using System;
using System.Security.Claims;

namespace Core.Extensions;

public static class ClaimsPrincipalExtensions
{
        // bir kisinin claimlerini ararken .net ugrastiriyor bizi
        // claimsprinciple bir kisinin claimlerine ulasmak icin .net de olan class
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }
        // claaim principle . claimRoles dedigim an da rollleri donder diyorum 
        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }