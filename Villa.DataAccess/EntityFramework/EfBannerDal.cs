using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
    public class EfBannerDal : GenericRepository<Banner>, IBannerDal
    {   ///implementasyonlar GenericRepository de
        public EfBannerDal(VillaContext context) : base(context)
        {   //Generic de constructor da otomatik context oluşuyordu bu yüzden burda da oluşturmalı
        }
    }
}
