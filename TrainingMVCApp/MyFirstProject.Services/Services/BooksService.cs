using MyMVCProject.DAL.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyMVCProject.DAL.Repository;

namespace MyFirstProject.Services.Services
{
    public interface IBooksService
    {
        public  Task<List<Books>> getAllBooks();
    }
    public class BooksService : IBooksService
    {
        //private readonly GenericRepository genericRepository;
        //public BooksService(GenericRepository context)
        //{
        //    _context = context;
        //}
        public async Task<List<Books>> getAllBooks()
        {
            using (var Context = new StudentDbContext())
            {
                return Context.Books.ToList();
            }
            //return new GenericRepository<Books>().GetAll().ToList();
        }
    }
}
