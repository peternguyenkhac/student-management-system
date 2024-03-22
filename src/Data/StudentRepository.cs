using src.Models;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace src.Data
{
    public class StudentRepository
    {
        private readonly Context _context;

        public StudentRepository(Context context)
        {
            _context = context;
            _context.Load();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(s => s.Id == id);
        }

        public void Add(Student student)
        {
            student.AcademicPerformance = student.GPA < 3 ? AcademicPerformance.VeryPoor :
                                          student.GPA < 5 ? AcademicPerformance.Poor :
                                          student.GPA < 6.5 ? AcademicPerformance.Fair :
                                          student.GPA < 7.5 ? AcademicPerformance.Good :
                                          student.GPA < 9 ? AcademicPerformance.VeryGood :
                                          AcademicPerformance.Excellent;

            _context.Students.Add(student);
        }

        public void Update(Student updatedStudent)
        {
            Student student = GetById(updatedStudent.Id);

            student.StudentCode = updatedStudent.StudentCode;
            student.DateOfBirth = updatedStudent.DateOfBirth;
            student.SchoolName = updatedStudent.SchoolName;
            student.StartYear = updatedStudent.StartYear;
            student.GPA = updatedStudent.GPA;
            student.Address = updatedStudent.Address;
            student.Height = updatedStudent.Height;
            student.Weight = updatedStudent.Weight;
            student.AcademicPerformance = student.GPA < 3 ? AcademicPerformance.VeryPoor :
                              student.GPA < 5 ? AcademicPerformance.Poor :
                              student.GPA < 6.5 ? AcademicPerformance.Fair :
                              student.GPA < 7.5 ? AcademicPerformance.Good :
                              student.GPA < 9 ? AcademicPerformance.VeryGood :
                              AcademicPerformance.Excellent;
        }

        public void Remove(int id)
        {
            Student student = GetById(id);
            _context.Students.Remove(student);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
