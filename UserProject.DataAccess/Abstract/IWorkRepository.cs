using System.Collections.Generic;
using UserProject.Entity;
namespace UserProject.DataAccess.Abstract
{
    public interface IWorkRepository:IRepository<Work> // Bir interface'i temel almamızın sebebi
    {                                                // Ortak olan işlemler için tek bir temel sınıf tanımlamaktır.
        List<Work> GetDailyWorks();              //İleride work(iş) sınıfına ek olarak başka özellikler de gelebilir.
        List<Work> GetWeeklyWorks();      //Ve onlar içinde GetById,Add,Delete gibi özellikleri tekrar tanımlamak
        List<Work> GetMonthlyWorks();  //zorunda kalabiliriz.Bunun yerine Temel bir interface tanımlarız ve
    }                                  //Yeni bir özellik geldiğinde o da bu interface'i temel alır ve temel
}                                       //özellikleri kullanır.