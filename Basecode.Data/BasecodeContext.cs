using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Basecode.Data
{
    public class BasecodeContext : IdentityDbContext<IdentityUser>
    {
        public BasecodeContext(DbContextOptions<BasecodeContext> options) : base(options)
        { 
            
        }

       
    }
}
