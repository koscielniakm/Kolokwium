using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Linq;

using Kol2.BLL;
using Kol2.DAL;

namespace Kol2.DAL
{
    public class BikeAccess
    {
        public Kol2Context Context { get; set; }

        public BikeAccess()
        {
            Context = new Kol2Context();
        }

        public void AddBike(Bike b)
        {
            Context.Bikes.Add(b);
            Context.SaveChanges();
        }

        public IBindingList GetBikes()
        {
            var lotteryResults = new BindingList<Bike>(Context.Bikes.ToList());
            return lotteryResults;
        }

    }
}
