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
    public class ExperienceManager:IExperinceService
    {
        IExperinceDal _experinceDal;

        public ExperienceManager(IExperinceDal experinceDal)
        {
            _experinceDal = experinceDal;
        }

        public void Tadd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetlist()
        {
            return _experinceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
