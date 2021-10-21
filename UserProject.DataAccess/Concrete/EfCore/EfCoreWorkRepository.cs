using System.Collections.Generic;
using UserProject.DataAccess.Abstract;
using UserProject.Entity;
using System.Linq;

namespace UserProject.DataAccess.Concrete.EfCore
{
    public class EfCoreWorkRepository : EfCoreGenericRepository<Work,WorkContext>,IWorkRepository
    {
        public List<Work> GetDailyWorks()
        {
            using(var context=new WorkContext()){
                var works= context.works.Where(w=>w.type=="G").ToList();
                return works;
            }
        }
    public List<Work> GetWeeklyWorks()
        {
            using(var context=new WorkContext()){
                var works= context.works.Where(w=>w.type=="H").ToList();
                return works;
            }
        }
        public List<Work> GetMonthlyWorks()
        {
            using(var context=new WorkContext()){
                var works= context.works.Where(w=>w.type=="A").ToList();
                return works;
            }
        }
    }
}