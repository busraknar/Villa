﻿using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal

    {
        public EfMessageDal(VillaContext context) : base(context)
        {
        }
    }
}
