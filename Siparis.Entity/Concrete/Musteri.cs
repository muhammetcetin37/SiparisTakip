using Siparis.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity.Concrete
{
    public class Musteri:BaseEntity
    {
        
        public string MusteriKodu { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
    }
}
