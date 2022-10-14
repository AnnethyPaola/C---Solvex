using FrisCrud.Entities;

namespace FrisCrud.Services;

public interface IbaseCrudService<TEntity> where TEntity: base
{
    List<TEntity> Get();
    Iqueryable<Entity> Query();
    TEntity Get (int id);
    TEntity Create(TEntity entity);
     TEntity Update(TEntity entity);
      TEntity Delete(TEntity id);
}

public class BaseCrudService<T> : IbaseCrudService<T> where T: base{
    
    protected List<T> entities;
    private int _id;

    public BaseCrudService(){
        entities = new List<T>();
        id = 1;
    }
    
    public List<T> Get(){
        return Query().ToList();
    }

    public Iqueryable<T> Query(){
        return entities.AsQueryable().where(x:T => !x.Delete);
    }

    public T get(int id){
        Query().FirstOrDefault(x => x.Id == id);
    }

    public T create(TEntity entity){
        entity.id = id;
    }
}