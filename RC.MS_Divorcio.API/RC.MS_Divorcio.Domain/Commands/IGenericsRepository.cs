using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.Commands
{
    public interface IGenericsRepository
    {
        public void Add<T>(T entity) where T: class;
    }
}
