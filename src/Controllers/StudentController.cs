using src.Base;
using src.Data;
using src.Models;
using src.Utils;
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
            RouterInstance.Redirect("Sinh vien", newStudent.Id);
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

        public void GetAcademicPerformancePercentage()
        {
            List<Student> students = _studentRepository.GetAll();
            int studentCount = students.Count == 0 ? 1 : students.Count;

            Dictionary<AcademicPerformance, int> academicPerformanceCount = new Dictionary<AcademicPerformance, int>();
            academicPerformanceCount.Add(AcademicPerformance.Excellent, 0);
            academicPerformanceCount.Add(AcademicPerformance.VeryGood, 0);
            academicPerformanceCount.Add(AcademicPerformance.Good, 0);
            academicPerformanceCount.Add(AcademicPerformance.Fair, 0);
            academicPerformanceCount.Add(AcademicPerformance.Poor, 0);
            academicPerformanceCount.Add(AcademicPerformance.VeryPoor, 0);

            foreach(var student in students)
            {
                if(student.AcademicPerformance == AcademicPerformance.Excellent)
                {
                    academicPerformanceCount[AcademicPerformance.Excellent]++;
                    continue;
                }
                if (student.AcademicPerformance == AcademicPerformance.VeryGood)
                {
                    academicPerformanceCount[AcademicPerformance.VeryGood]++;
                    continue;
                }
                if (student.AcademicPerformance == AcademicPerformance.Good)
                {
                    academicPerformanceCount[AcademicPerformance.Good]++;
                    continue;
                }
                if (student.AcademicPerformance == AcademicPerformance.Fair)
                {
                    academicPerformanceCount[AcademicPerformance.Fair]++;
                    continue;
                }
                if (student.AcademicPerformance == AcademicPerformance.Poor)
                {
                    academicPerformanceCount[AcademicPerformance.Poor]++;
                    continue;
                }
                if (student.AcademicPerformance == AcademicPerformance.VeryPoor)
                {
                    academicPerformanceCount[AcademicPerformance.VeryPoor]++;
                    continue;
                }
            }

            AcademicPerformancePercentageView view = new AcademicPerformancePercentageView(academicPerformanceCount, studentCount);
            view.Render();
        }

        public void GetAverageScorePercentage()
        {
            List<Student> students = _studentRepository.GetAll();
            int studentCount = students.Count == 0 ? 1 : students.Count;
            Dictionary<double, int> scoreCount = new Dictionary<double, int>();
            foreach(Student student in students)
            {
                if (scoreCount.ContainsKey(student.GPA))
                {
                    scoreCount[student.GPA]++;
                }
                else
                {
                    scoreCount[student.GPA] = 1;
                }
            }

            ScorePercentageView view = new ScorePercentageView(scoreCount, studentCount);
            view.Render();
        }

        public void GetStudentsByAcademicPerformance()
        {
            SearchStudentByAcademicPerformance view = new SearchStudentByAcademicPerformance();
            view.Render();
        }

        public void GetStudentsByAcademicPerformance(string studentAcademicPerformance)
        {
            AcademicPerformance academicPerformance = studentAcademicPerformance == "VeryPoor" ? AcademicPerformance.VeryPoor :
                                                      studentAcademicPerformance == "Poor" ? AcademicPerformance.Poor :
                                                      studentAcademicPerformance == "Fair" ? AcademicPerformance.Fair :
                                                      studentAcademicPerformance == "Good" ? AcademicPerformance.Good :
                                                      studentAcademicPerformance == "VeryGood" ? AcademicPerformance.VeryGood :
                                                      AcademicPerformance.Excellent;
            List<Student> students = _studentRepository
                                    .GetAll()
                                    .Where(s => s.AcademicPerformance == academicPerformance)
                                    .ToList();

            StudentListByAcademicPerformanceView view = new StudentListByAcademicPerformanceView(studentAcademicPerformance, students);
            view.Render();
        }

        public void SaveChanges()
        {
            _studentRepository.SaveChanges();
        }
    }
}
