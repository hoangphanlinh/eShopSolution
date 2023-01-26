using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace eShopSolution.Data.Entities
{
    public class AppTole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
