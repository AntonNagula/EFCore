using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Infrastructure.Interfaces.Context;
using EFCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Infrastructure.Data
{
    public class MyContextInitializationService : IMyContextInitialization
    {
        private readonly StudentContext _context;
        private readonly IStudentProvider _usersProvider;

        public MyContextInitializationService(StudentContext context, IStudentProvider usersProvider)
        {
            _context = context;
            _usersProvider = usersProvider;
            
        }

        public void Initialize()
        {
            _context.Database.EnsureCreated();

            using (var transaction = _context.Database.BeginTransaction())
            {

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] ON");

                _context.Students.RemoveRange(_context.Students);
                _context.Students.AddRange(_usersProvider.GetStudent());
                _context.SaveChanges();

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] OFF");

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Lessons] ON");

                _context.Lessons.RemoveRange(_context.Lessons);
                _context.Lessons.AddRange(_usersProvider.GetLesson());
                _context.SaveChanges();

                _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Lessons] OFF");

                transaction.Commit();
            }
        }
    }
}
