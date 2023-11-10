using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petrus_Vlad_Darius_LAB2.Models;

namespace Petrus_Vlad_Darius_LAB2.Data
{
    public class Petrus_Vlad_Darius_LAB2Context : DbContext
    {
        public Petrus_Vlad_Darius_LAB2Context (DbContextOptions<Petrus_Vlad_Darius_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Book> Book { get; set; } = default!;

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Author>? Author { get; set; }

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Category>? Category { get; set; }

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Member>? Member { get; set; }

        public DbSet<Petrus_Vlad_Darius_LAB2.Models.Borrowing>? Borrowing { get; set; }
    }
}
