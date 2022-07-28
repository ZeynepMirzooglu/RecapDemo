using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal customerDal;
        private IPersonService _personService;

        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            this.customerDal = customerDal;
            _personService = personService;
        }

        public void Add(Customer customer)
        {
            customerDal.Add(customer);
        }

        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateIdentityNumberIfEmpty(customer);
            CheckCustomerExists(customer);
            customerDal.Add(customer);
        }
        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }

        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Validasyon hatası oldu!");
            }
        }

        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("Validasyon hatası oldu!");

            }
        }

        private void ValidateFirstNameLenght(Customer customer)
        {
            if (customer.FirstName.Length<2)
            {
                throw new Exception("Adı 2 karakterden fazla olamaz.");
            }
        }

        private void CheckCustomerExists(Customer customer)
        {
            if (customerDal.CustomerExists(customer))
            {
                throw new Exception("Müşteri zaten mevcut");
            }
        }

        public class KpsService
        {
            public bool CheckPerson(long TcNo, string adi, string soyadi, int yil)
            {
                return true;
            }
        }

    }
}
