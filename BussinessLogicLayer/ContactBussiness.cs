using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class ContactBussiness :IBussiness<Contact>
    {
        UnitOfWork _uow;
        public ContactBussiness()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Contact item)
        {
            if (string.IsNullOrEmpty(item.FirstName))
                throw new Exception("İsim alanı boş geçilemez");
            if (string.IsNullOrEmpty(item.LastName))
                throw new Exception("Soyisim alanı boş geçilemez");
            if (string.IsNullOrEmpty(item.Title))
                throw new Exception("Ünvan boş geçilemez");
            if (item.CustomerID <= 0 || item.CustomerID == null)
                throw new Exception("Müşteri seçimi yapmak zorundasınız");
            _uow.ContactRepository.Add(item);
            return _uow.ApplyChanges();

        }

        public bool Update(Contact item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Contact Remove)
        {
            throw new NotImplementedException();
        }

        public Contact Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
