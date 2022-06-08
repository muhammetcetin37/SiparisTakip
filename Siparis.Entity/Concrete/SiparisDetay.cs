using Siparis.Entity.Abstract;

namespace Siparis.Entity.Concrete
{
    public class SiparisDetay:BaseEntity
    {
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Adet { get; set; }
        public decimal Indirim { get; set; } = 0;

        //Database'de oluşacak alan
        public int SiparisMasterId { get; set; }
        public SiparisMaster SiparisMaster { get; set; }
    }
}