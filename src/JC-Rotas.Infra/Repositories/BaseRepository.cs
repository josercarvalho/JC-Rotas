﻿using Microsoft.EntityFrameworkCore;
using JC_Rotas.Domain.Entities;
using JC_Rotas.Infra.Context;
using JC_Rotas.Infra.Interfaces;
using System.Linq.Expressions;

namespace JC_Rotas.Infra.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : Base
{
    private readonly RotaDbContext _context;

    public BaseRepository(RotaDbContext context)
    {
        _context = context;
    }

    public virtual async Task<T> CreateAsync(T obj)
    {
        _context.Add(obj);
        await _context.SaveChangesAsync();

        return obj;
    }

    public virtual async Task<T> UpdateAsync(T obj)
    {
        _context.Entry(obj).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return obj;
    }

    public virtual async Task RemoveAsync(int id)
    {
        var obj = await GetByIdAsync(id);

        if (obj != null)
        {
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        var obj = await _context.Set<T>()
                                .AsNoTracking()
                                .Where(x => x.Id == id)
                                .ToListAsync();

        return obj.FirstOrDefault();
    }

    public virtual async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>()
                             .AsNoTracking()
                             .ToListAsync();
    }

    public virtual async Task<T> GetAsync(
        Expression<Func<T, bool>> expression,
        bool asNoTracking = true)
            => asNoTracking
            ? await BuildQuery(expression)
                    .AsNoTracking()
                    .FirstOrDefaultAsync()

            : await BuildQuery(expression)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

    public virtual async Task<IList<T>> SearchAsync(
        Expression<Func<T, bool>> expression,
        bool asNoTracking = true)
            => asNoTracking
            ? await BuildQuery(expression)
                    .AsNoTracking()
                    .ToListAsync()

            : await BuildQuery(expression)
                    .AsNoTracking()
                    .ToListAsync();

    private IQueryable<T> BuildQuery(Expression<Func<T, bool>> expression)
        => _context.Set<T>().Where(expression);
}
