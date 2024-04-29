using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeChallange9_ques2.Models
{

    public class MovieContext:DbContext

    {
        public MovieContext() : base("connectstr"){ }
        public DbSet<Movie> Movies { get; set; }

    }
}