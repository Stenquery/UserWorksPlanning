using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UserProject.DataAccess.Abstract;

namespace UserProject.DataAccess.Concrete.EfCore
{
    public class EfCoreGenericRepository<Tentity, TContext> : IRepository<Tentity> // İleride farklı bir entity ya da context kullanabiliriz diye
    where Tentity:class  // Tentity  class türünde olsun.                      // Yine jenerik yani tip dönüşümlü tanımlıyoruz.
    where TContext:DbContext,new() //TContext ise DbContext türünde olsun  ve new lenebilsin yani nesnesi oluşturulabilsin.
    {                                                     
        public void AddEntity(Tentity entity)
        {
            using(var context=new TContext()){
                context.Set<Tentity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteEntity(Tentity entity)
        {
            using(var context=new TContext()){
                context.Set<Tentity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Tentity> GetAllEntities()
        {
            using(var context=new TContext()){
                return context.Set<Tentity>().ToList();           
            }
        }

        public Tentity GetEntityById(int id)
        {
            using(var context=new TContext()){
                return context.Set<Tentity>().Find(id);           
            }
        }

        public void UpdateEntity(Tentity entity)
        {
            using(var context=new TContext()){
                 context.Entry(entity).State=EntityState.Modified;
                 context.SaveChanges();          
            }
        }
    }
}