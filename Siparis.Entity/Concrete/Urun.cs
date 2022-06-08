using Siparis.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity.Concrete
{
    public class Urun:BaseEntity
    {
        public string Urunkodu { get; set; }
        public int KategoryId { get; set; }
        public Kategory Kategori { get; set; }
    }
}
