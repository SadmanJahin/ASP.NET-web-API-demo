using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_Assessment.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(): base("DefaultConnection")
        {

        }
        public DbSet<Text> Texts { get; set; }
    }
   
}