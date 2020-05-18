using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly MS_DivorcioDbContext _context;
        public GenericsRepository(MS_DivorcioDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); //guarda el tipo de entidad en la base de datos.
            _context.SaveChanges();
        }
    }
}
