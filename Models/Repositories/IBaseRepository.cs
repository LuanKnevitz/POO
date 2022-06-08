namespace Ap2_1.Models.Repositories;

public interface IBaseRepository<Entity> where Entity : class
{
    Entity GetById (int id);
    List<Entity> GetAll();
    void Insert(Entity entity);
    void Update(Entity client);
    void Delete(int id);    
}