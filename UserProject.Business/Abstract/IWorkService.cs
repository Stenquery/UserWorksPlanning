using System.Collections.Generic;
using UserProject.Entity;

namespace UserProject.Business.Abstract
{
    public interface IWorkService
    {
        Work GetEntityById(int id);        
        List<Work> GetAllEntities();
        void AddEntity(Work entity);
        void UpdateEntity(Work entity);
        void DeleteEntity(Work entity);
        List<Work> GetDailyWorks();              //İleride work(iş) sınıfına ek olarak başka özellikler de gelebilir.
        List<Work> GetWeeklyWorks();      //Ve onlar içinde GetById,Add,Delete gibi özellikleri tekrar tanımlamak
        List<Work> GetMonthlyWorks();

    }
}