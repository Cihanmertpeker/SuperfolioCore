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
    public class AppUserMessageManager : IAppUserMessageService
    {
        IAppUserMessageDal _appUserMessageDal;

        public AppUserMessageManager(IAppUserMessageDal appUserMessageDal)
        {
            _appUserMessageDal = appUserMessageDal;
        }

        public List<AppUserMessage> GetAppUserMessagewithAppUserService()
        {
           return _appUserMessageDal.GetAppUserMessageWithAppUser();
        }

        public void Tadd(AppUserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUserMessage t)
        {
            throw new NotImplementedException();
        }

        public AppUserMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUserMessage> TGetlist()
        {
            return _appUserMessageDal.GetList();
        }

        public void TUpdate(AppUserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
