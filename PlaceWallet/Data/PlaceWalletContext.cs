using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlaceWallet.Models
{
    public class PlaceWalletContext : DbContext
    {
        public PlaceWalletContext (DbContextOptions<PlaceWalletContext> options)
            : base(options)
        {
        }

        public DbSet<PlaceWallet.Models.Place> Place { get; set; }
    }
}
