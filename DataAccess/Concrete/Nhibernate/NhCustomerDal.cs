using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.Nhibernate
{
    public class NhCustomerDal:ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Nhibernate kullanılarak veri tabanına eklendi.");
        }

        public bool CheckCustomerExists(Customer customer)
        {
            return true;
        }

        public bool CustomerExists(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
