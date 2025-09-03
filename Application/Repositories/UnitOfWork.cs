using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            BookRepo = new BookRepo();
        }

        public IBookRepo BookRepo { get; set; }
    }
}
