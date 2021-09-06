using Microsoft.EntityFrameworkCore;

using MyMVCProject.DAL.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMVCProject.DAL.Repository
{
    public class GenericRepository<T> : ContextRepository where T : class
    {
        private static GenericRepository<T> _instance;
        public GenericRepository()
        {
        }
        public static GenericRepository<T> Inst
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GenericRepository<T>();
                }



                return _instance;
            }
        }
        public DbSet<T> Set
        {
            get
            {
                return JoinContext.Set<T>();
            }
        }
      //  StudentDbContext _context = new StudentDbContext();
        private DbSet<T> table;



        //public GenericRepository(StudentDbContext context)
        //{
        //    _context = context;
        //    table = _context.Set<T>();



        //}
        //public void Delete(object id)
        //{
        //    T exists = table.Find(id);
        //    table.Remove(exists);
        //}



        public List<T> GetAll()
        {
            //using (StudentDbContext context = new StudentDbContext())
            //{
            //    _context = context;
            //    //table = _context.Set<T>();
            //    return _context.Set<T>().ToList();
            //}

            return JoinContext.Set<T>().ToList();

        }



        public T GetById(object id)
        {
            return table.Find(id);
        }



        public void Insert(T obj)
        {
            table.Add(obj);
        }



        //public void Save()
        //{
        //    _context.SaveChanges();
        //}



        //public void Update(T obj)
        //{
        //    table.Attach(obj);
        //    _context.Entry(obj).State = EntityState.Modified;
        //}
    }
}
