using Database.Context;
using Repository.Interfaces;

namespace Repository.Repository;

public class ARepository<TEntity>(AircraftContext context) : IRepository<TEntity> where TEntity : class
{
    public async Task<TEntity> CreateAsync(TEntity t)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TEntity>> CreateRangeAsync(List<TEntity> list)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(int id, TEntity t)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateRangeAsync(List<TEntity> list)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity?> ReadAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TEntity>> ReadAsync(int start, int count)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TEntity>> ReadAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id, TEntity t)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteRangeAsync(List<TEntity> list)
    {
        throw new NotImplementedException();
    }
}