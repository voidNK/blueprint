using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blueprint.Abstractions.Repository
{
  public abstract class Repository<T> : IRepository<T>, ICommandRepository<T>, IQueryRepository<T>
    where T : class
  {
    private readonly ICommandRepository<T> _commandRepository;
    private readonly IQueryRepository<T> _queryRepository;

    protected Repository(
      ICommandRepository<T> commandRepository,
      IQueryRepository<T> queryRepository)
    {
      this._commandRepository = commandRepository;
      this._queryRepository = queryRepository;
    }

    public IQueryable<T> Queryable => this._queryRepository.Queryable;

    public void Add(T item) => this._commandRepository.Add(item);

    public Task AddAsync(T item) => this._commandRepository.AddAsync(item);

    public void AddRange(IEnumerable<T> items) => this._commandRepository.AddRange(items);

    public Task AddRangeAsync(IEnumerable<T> items) => this._commandRepository.AddRangeAsync(items);

    public bool Any() => this._queryRepository.Any();

    public bool Any(Expression<Func<T, bool>> where) => this._queryRepository.Any(where);

    public Task<bool> AnyAsync() => this._queryRepository.AnyAsync();

    public Task<bool> AnyAsync(Expression<Func<T, bool>> where) => this._queryRepository.AnyAsync(where);

    public long Count() => this._queryRepository.Count();

    public long Count(Expression<Func<T, bool>> where) => this._queryRepository.Count(where);

    public Task<long> CountAsync() => this._queryRepository.CountAsync();

    public Task<long> CountAsync(Expression<Func<T, bool>> where) => this._queryRepository.CountAsync(where);

    public void Delete(object key) => this._commandRepository.Delete(key);

    public void Delete(Expression<Func<T, bool>> where) => this._commandRepository.Delete(where);

    public Task DeleteAsync(object key) => this._commandRepository.DeleteAsync(key);

    public Task DeleteAsync(Expression<Func<T, bool>> where) => this._commandRepository.DeleteAsync(where);

    public T Get(object key) => this._queryRepository.Get(key);

    public Task<T> GetAsync(object key) => this._queryRepository.GetAsync(key);

    public IEnumerable<T> List() => this._queryRepository.List();

    public Task<IEnumerable<T>> ListAsync() => this._queryRepository.ListAsync();

    public void Update(object key, T item) => this._commandRepository.Update(key, item);

    public Task UpdateAsync(object key, T item) => this._commandRepository.UpdateAsync(key, item);

    public void UpdatePartial(object key, object item) => this._commandRepository.UpdatePartial(key, item);

    public Task UpdatePartialAsync(object key, object item) => this._commandRepository.UpdatePartialAsync(key, item);

    public void UpdateRange(IEnumerable<T> items) => this._commandRepository.UpdateRange(items);

    public Task UpdateRangeAsync(IEnumerable<T> items) => this._commandRepository.UpdateRangeAsync(items);
  }
}
