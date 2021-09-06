using MyMVCProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMVCProject.DAL.Repository
{
   public abstract class ContextRepository : IDisposable
    {
        private static StudentDbContext _joinContext;
        public ContextRepository()
        {



        }



        internal static StudentDbContext JoinContext
        {
            get
            {
                if (_joinContext == null)
                {
                    _joinContext = new StudentDbContext();
                }
                return _joinContext;
            }
        }



        public void Dispose()
        {
            if (_joinContext != null)
            {
                _joinContext.Dispose();
                _joinContext = null;
            }
        }
    }

}
