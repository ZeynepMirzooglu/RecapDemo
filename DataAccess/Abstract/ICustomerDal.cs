using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        /// <summary>
        /// Müşteri ekleme operasyonu
        /// </summary>
        /// <param name="customer"></param>
        void Add(Customer customer);
        bool CustomerExists(Customer customer);
    }
}
