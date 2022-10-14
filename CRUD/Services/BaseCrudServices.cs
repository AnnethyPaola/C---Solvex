using System;
using CRUD.Entities;

namespace CRUD.Services
{

    public interface IBaseCrudService<TEntity>
    {
        List<TEntity> Get();
        IQueryable<TEntity> Query();
        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(int id);

    }

    public class BaseCrudService<TEntity> : IBaseCrudService<TEntity> where TEntity: Base
    {
        private List<TEntity> _ListPerson;
        private int _Id_Auto_Increment;

        public BaseCrudService()
        {
            _ListPerson = new List<TEntity>();
            _Id_Auto_Increment = 1;
        }

        public IQueryable<TEntity> Query()
        {
            return _ListPerson.AsQueryable().Where(x => x.Delete == false);
        }

        public List<TEntity> Get(){
            return Query().ToList();
        }

        public TEntity GetById(int id){
            return Query().FirstOrDefault(item => item.Id == id);
        }

        public TEntity Create(TEntity Person){
            Person.Id = _Id_Auto_Increment;
            _ListPerson.Add(Person);
            _Id_Auto_Increment++;
            return Person;
        }

        public TEntity Update(TEntity Person){
            var personSearch = GetById(Person.Id);
            personSearch = Person; 
            return Person;
        }

        public bool Delete(int id){
            var entityDelete = GetById(id);
            entityDelete.Delete = true;
            return true;
        }
    }

}
