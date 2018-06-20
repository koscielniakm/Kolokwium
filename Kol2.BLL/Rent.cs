using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kol2.BLL
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }

        [Browsable(false)]
        public Bike Bike { get; set; }

        [Browsable(false)]
        [ForeignKey("Bike")]
        public int BikeId { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }


    }
}
