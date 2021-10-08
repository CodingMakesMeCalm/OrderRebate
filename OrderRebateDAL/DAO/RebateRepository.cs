using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace OrderRebateDAL.DAO
{
    public class OrderRebateRepository<T> : IRepository<T> where T : OrderRebateEntity
    {
        readonly private OrderRebateContext _db = null;
        public OrderRebateRepository(OrderRebateContext context = null)
        {
            _db = context ?? new OrderRebateContext();
        }
        public async Task<List<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }
        public async Task<List<T>> GetSome(Expression<Func<T, bool>> match)
        {
            return await _db.Set<T>().Where(match).ToListAsync();
        }
        public async Task<T> GetOne(Expression<Func<T, bool>> match)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(match);
        }
        public async Task<T> Add(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        //public async Task<UpdateStatus> Update(T updatedEntity)
        //{
        //    UpdateStatus operationStatus = UpdateStatus.Failed;

        //    try
        //    {
        //        T currentEntity = await GetOne(ent => ent.Id == updatedEntity.Id);
        //        _db.Entry(currentEntity).OriginalValues["Timer"] = updatedEntity.Timer;
        //        _db.Entry(currentEntity).CurrentValues.SetValues(updatedEntity);

        //        if (await _db.SaveChangesAsync() == 1)
        //            operationStatus = UpdateStatus.Ok;
        //    }
        //    catch (DbUpdateConcurrencyException dbx)
        //    {
        //        operationStatus = UpdateStatus.stale;
        //        Console.WriteLine("Problem in " + MethodBase.GetCurrentMethod().Name + dbx.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Problem in " + MethodBase.GetCurrentMethod().Name + ex.Message);
        //    }
        //    return operationStatus;
        //}
        //public async Task<int> Delete(int id)
        //{
        //    T currentEntity = await GetOne(ent => ent.Id == id);
        //    _db.Set<T>().Remove(currentEntity);
        //    return await _db.SaveChangesAsync();
        //}
    }
}
