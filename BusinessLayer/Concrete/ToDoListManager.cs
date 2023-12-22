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
    public class ToDoListManager : ITodoListService
    {
        ITodoListDal _toDoListDal;

        public ToDoListManager(ITodoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void Tadd(ToDoList t)
        {
            
        }

        public void TDelete(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetlist()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
