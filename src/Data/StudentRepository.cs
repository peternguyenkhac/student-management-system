using src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public void Remove(int id)
        {
            Student student = GetById(id);
            _context.Students.Remove(student);
        }
    }
}
