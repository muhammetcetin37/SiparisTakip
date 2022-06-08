using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        private DateTime _createDate=DateTime.UtcNow;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate= value; }
        }

    }
}
