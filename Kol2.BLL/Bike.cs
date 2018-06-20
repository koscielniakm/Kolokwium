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
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }

        public string Number { get; set; }

        public string Type { get; set; }
    }
}
