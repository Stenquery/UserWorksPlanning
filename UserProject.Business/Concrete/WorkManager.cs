
using System.Collections.Generic;
using UserProject.Business.Abstract;
using UserProject.DataAccess.Abstract;
using UserProject.DataAccess.Concrete.EfCore;
using UserProject.Entity;

namespace UserProject.Business.Concrete
{
    public class WorkManager : IWorkService
    {
        private IWorkRepository workRepository;
        public WorkManager(IWorkRepository workRepository)
        {
            this.workRepository=workRepository;
        }
        public void AddEntity(Work entity)
        {
            this.workRepository.AddEntity(entity);
        }

        public void DeleteEntity(Work entity)
        {
            this.workRepository.DeleteEntity(entity);
        }

        public List<Work> GetAllEntities()
        {
            return this.workRepository.GetAllEntities();
        }

        public Work GetEntityById(int id)
        {
            return this.workRepository.GetEntityById(id);
        }

        public void UpdateEntity(Work entity)
        {
            this.workRepository.UpdateEntity(entity);
        }
        public List<Work> GetDailyWorks(){
            return this.workRepository.GetDailyWorks();
        }
        public List<Work> GetWeeklyWorks(){
            return this.workRepository.GetWeeklyWorks();
        }
       public List<Work> GetMonthlyWorks(){
            return this.workRepository.GetMonthlyWorks();
        }
    }
}