using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using Kol2.BLL;

namespace Kol2.DAL
{
    public class Kol2Context : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Rent> Rents { get; set; }

        public Kol2Context() : base("RentBike") /* nazwa bazy danych */
        {

        }

    }
}
