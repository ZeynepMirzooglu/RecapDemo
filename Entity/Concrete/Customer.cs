using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Customer:Person,IEntity
    {
        public int CityId { get; set; }
    }
}
