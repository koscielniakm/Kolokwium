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
    public class RentAccess
    {
        public Kol2Context Context { get; set; }

        public RentAccess()
        {
            Context = new Kol2Context();
        }

        public void AddRent(Rent r)
        {
            Context.Rents.Add(r);
            Context.SaveChanges();
        }

        public IBindingList GetRents()
        {
            var lotteryResults = new BindingList<Rent>(Context.Rents.ToList());
            return lotteryResults;
        }

    }
}
