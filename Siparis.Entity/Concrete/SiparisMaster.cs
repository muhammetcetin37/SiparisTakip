using Siparis.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity.Concrete
{
    public class SiparisMaster:BaseEntity
    {
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public IList<SiparisDetay> SiparisDetay { get; set; }
    }
}
