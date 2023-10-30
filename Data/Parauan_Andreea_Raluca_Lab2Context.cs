using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Lab2.Models;

namespace Parauan_Andreea_Raluca_Lab2.Data
{
    public class Parauan_Andreea_Raluca_Lab2Context : DbContext
    {
        public Parauan_Andreea_Raluca_Lab2Context (DbContextOptions<Parauan_Andreea_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Parauan_Andreea_Raluca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Parauan_Andreea_Raluca_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
