using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    

    public class WebApplication1Context : DbContext

    {

        public WebApplication1Context()

        {

        }

        //Entities

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

    }

}
