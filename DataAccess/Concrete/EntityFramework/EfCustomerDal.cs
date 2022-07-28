using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("EntityFramework kullanılarak veri tabanına eklendi.");
        }

        public bool CheckCustomerExists(Customer customer)
        {
            return true;
        }
    }
}
