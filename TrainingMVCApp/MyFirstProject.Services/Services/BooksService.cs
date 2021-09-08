using MyMVCProject.DAL.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyMVCProject.DAL.Repository;
using MyFirstProject.Services.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace MyFirstProject.Services.Services
{
    public interface IBooksService
    {
        public  Task<List<Books>> getAllBooks();
    }
    public class BooksService : IBooksService
    {
        //private readonly GenericRepository genericRepository;
        public BooksService(StudentDbContext context)
        {
            _context = context;
        }
        private readonly StudentDbContext _context;

        public async Task<List<Books>> getAllBooks()
        {
            //using (var Context = new StudentDbContext())
            //{
            //    return Context.Books.ToList();
            //}
            var data= _context.StudentInfo.Select(o => new vwStudentInfo
            {
                Id = o.Id,
                StudentName = o.Student.Name,
                Address = o.Address,
                ContactNumber = o.ContactNumber,
                CreatedOn = o.CreatedOn,
                UpdatedOn = o.UpdatedOn
            }).ToList();
            var data1 = _context.StudentInfo.Include("Student").Where(o => o.Student.Id == 1).FirstOrDefault();

            return _context.Books.ToList();
            //return new GenericRepository<Books>().GetAll().ToList();
        }

        public async Task<List<vwStudentInfo>> getAllStudentInfo()
        {
            
            var data = _context.StudentInfo.Select(o => new vwStudentInfo
            {
                Id = o.Id,
                StudentName = o.Student.Name,
                Address = o.Address,
                ContactNumber = o.ContactNumber,
                CreatedOn = o.CreatedOn,
                UpdatedOn = o.UpdatedOn
            }).ToList();

            return data;
            
        }
    }
}
