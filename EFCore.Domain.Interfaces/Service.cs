using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCore.Domain.Interfaces.Mappers;
using EFCore.Domain.Core.Interfaces;
using EFCore.Infrastructure.Interfaces.Interfaces;
using EFCore.Domain.Core;
namespace EFCore.Domain.Interfaces
{
    public class Service:IService
    {
        //public readonly IRepository _studentRepository;

        public readonly IUnitOfWork _studentRepository;

        public Service(IUnitOfWork studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IList<DomainGeneral> GetStudents()
        {
            return _studentRepository.Students.Get().Select(x=>x.ToDomainGeneral()).ToList();
        }

        public void Create(DomainGeneral Item)
        {
            _studentRepository.Students.Create(Item.ToGeneral_Info());
        }

        public void Delete_Student(int Id)
        {
            _studentRepository.Students.Delete(Id);
        }

        public void Create_Lesson(DomainLesson item)
        {
            _studentRepository.Lessons.Create(item.FromDomLesson_ToLesson());
        }

        public void Delete_Lesson(int Id)
        {
            _studentRepository.Lessons.Delete(Id);
        }

        public IList<DomainLesson> Get_Lesson(int Id)
        {
            return _studentRepository.Lessons.Get(Id).Select(x=>x.ToDomainLesson()).ToList();
        }       
        
    }
}
