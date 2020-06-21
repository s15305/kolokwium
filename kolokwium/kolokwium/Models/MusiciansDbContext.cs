using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class MusiciansDbContext : DbContext
    {
        public DbSet<Musician> Musician { get; set; }
        public DbSet<Musician_Track> Musician_Track { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }

        public MusiciansDbContext()
        {

        }
        public MusiciansDbContext(DbContextOptions options)
            : base(options)

        {

        }
    }
}
