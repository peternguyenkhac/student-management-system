using src.Base;
using src.Data;
using src.Models;
using src.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(Context context)
        {
            _studentRepository = new StudentRepository(context);
        }

        public void Index()
        {
            MenuView view = new MenuView();
            view.Render();
        }

        public void GetAll()
        {
            List<Student> students = _studentRepository.GetAll();
            StudentListView view = new StudentListView(students);
            view.Render();
        }

        public void GetById()
        {
            SearchStudentView view = new SearchStudentView();
            view.Render();
        }

        public void GetById(int id)
        {
            Student student = _studentRepository.GetById(id);
            StudentView view = new StudentView(student);
            view.Render();
        }

        public void Add() 
        {
            CreateStudentView view = new CreateStudentView();
            view.Render();
        }

        public void Add(Student newStudent)
        {
            _studentRepository.Add(newStudent);
            RouterInstance.Redirect("Danh sach sinh vien");
        }

        public void Update(int id)
        {
            Student student = _studentRepository.GetById(id);
            UpdateStudentView view = new UpdateStudentView();
            view.Render(student);
        }

        public void Update(Student updatedStudent)
        {
            _studentRepository.Update(updatedStudent);
            RouterInstance.Redirect("Danh sach sinh vien");
        }

        public void Remove()
        {
            RemoveStudentView view = new RemoveStudentView();
            view.Render();
        }

        public void Remove(int id)
        {
            _studentRepository.Remove(id);
            RouterInstance.Redirect("Danh sach sinh vien");
        }
    }
}
