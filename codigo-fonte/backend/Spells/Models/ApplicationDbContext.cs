﻿using Microsoft.EntityFrameworkCore;
using spellScrollBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spells.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Spell> Spell { get; set; }
        public DbSet<FavoriteSpell> FavoriteSpells { get; set; }
    }
}
