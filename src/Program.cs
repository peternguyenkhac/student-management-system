using src.Base;
using src.Controllers;
using src.Data;
using src.Models;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            StudentController studentController = new StudentController(context);
            Router.Instance.Register(0, "Menu", (p) => { studentController.Index(); });
            Router.Instance.Register(1, "Danh sach sinh vien", (p) => { studentController.GetAll(); });
            Router.Instance.Register(2, "Tim kiem sinh vien", (p) => { studentController.GetById(); });
            Router.Instance.Register(21, "Sinh vien", (p) => { studentController.GetById((int)p); });
            Router.Instance.Register(3, "Them sinh vien", (p) => { studentController.Add(); });
            Router.Instance.Register(31, "Thuc hien them sinh vien", (p) => { studentController.Add((Student)p); });
            Router.Instance.Register(4, "Cap nhat sinh vien", (p) => { studentController.Update((int)p); });
            Router.Instance.Register(41, "Thuc hien cap nhat sinh vien", (p) => { studentController.Update((Student)p); });
            Router.Instance.Register(5, "Xoa sinh vien", (p) => { studentController.Remove(); });
            Router.Instance.Register(51, "Thuc hien xoa sinh vien", (p) => { studentController.Remove((int)p); });
            Router.Instance.Register(6, "Phan tram hoc luc", (p) => { studentController.GetAcademicPerformancePercentage(); });
            Router.Instance.Register(7, "Phan tram GPA", (p) => { studentController.GetAverageScorePercentage(); });
            Router.Instance.Register(8, "Tim kiem sinh vien bang hoc luc", (p) => { studentController.GetStudentsByAcademicPerformance(); });
            Router.Instance.Register(81, "Thuc hien tim kiem sinh vien bang hoc luc", (p) => { studentController.GetStudentsByAcademicPerformance((string)p); });
            Router.Instance.Register(9, "Luu", (p) => { studentController.SaveChanges(); });



            while (true)
            {
                Router.Instance.Redirect(0);
            }
            
        }
    }
}