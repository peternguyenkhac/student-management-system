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

        public void Update(int id, Student newStudent)
        {
            Student student = GetById(id);

            student.StudentCode = newStudent.StudentCode;
            student.DateOfBirth = newStudent.DateOfBirth;
            student.SchoolName = newStudent.SchoolName;
            student.StartYear = newStudent.StartYear;
            student.GPA = newStudent.GPA;
            student.Address = newStudent.Address;
            student.Height = newStudent.Height;
            student.Weight = newStudent.Weight;
        }

        public void Remove(int id)
        {
            Student student = GetById(id);
            _context.Students.Remove(student);
        }
    }
}
