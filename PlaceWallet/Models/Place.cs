using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceWallet.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
