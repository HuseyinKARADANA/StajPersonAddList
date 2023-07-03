using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonManager:IPersonService
    {
        private readonly IpersonDal _ipersonDal;

        public PersonManager(IpersonDal ipersonDal)
        {
            _ipersonDal = ipersonDal;
        }

        public void Delete(Persons t)
        {
            _ipersonDal.Delete(t);
        }

        public Persons GetById(int id)
        {
            return _ipersonDal.GetById(id);
        }

        public List<Persons> GetListAll()
        {
            return _ipersonDal.GetListAll();
        }

        public void Insert(Persons t)
        {
           _ipersonDal.Insert(t);
        }

        public void Update(Persons t)
        {
             _ipersonDal.Update(t);
        }
    }
}
