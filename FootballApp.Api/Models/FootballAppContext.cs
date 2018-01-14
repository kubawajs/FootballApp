﻿using Microsoft.EntityFrameworkCore;

namespace FootballApp.Api.Models
{
    public class FootballAppContext : DbContext
    {
        public FootballAppContext(DbContextOptions<FootballAppContext> options)
            : base(options)
        {
        }

        public DbSet<PostedLink> PostedLinks { get; set; }
    }
}
