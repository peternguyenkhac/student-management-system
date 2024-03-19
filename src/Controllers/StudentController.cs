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
    public class StudentController
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

        }

        public void GetById(int id)
        {
            Student student = _studentRepository.GetById(id);
        }

        public void Add() 
        {
            CreateStudentView view = new CreateStudentView();
            view.Render();
        }
        public void Update()
        {

        }
        public void Remove()
        {

        }
    }
}
