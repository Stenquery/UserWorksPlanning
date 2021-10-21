using System.Collections.Generic;

namespace UserProject.DataAccess.Abstract
{
    public interface IRepository<Tentity>
    {
        Tentity GetEntityById(int id);        
        List<Tentity> GetAllEntities();
        void AddEntity(Tentity entity);
        void UpdateEntity(Tentity entity);
        void DeleteEntity(Tentity entity);
    }
}