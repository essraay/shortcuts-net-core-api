﻿
using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    { 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> Take(int count, Expression<Func<T, dynamic>> orderKeySelector, Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
