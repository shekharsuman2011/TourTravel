using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrialTours.Models
{
    public class User : DbContext
    {
        public virtual DbSet<Registration> Users { get; set; }
        
    }
}