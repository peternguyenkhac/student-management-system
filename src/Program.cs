using src.Base;
using src.Controllers;
using src.Data;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            StudentController studentController = new StudentController(context);
            Router.Instance.Register(0, "Menu View", studentController.Index);
            Router.Instance.Register(1, "Danh sach sinh vien", studentController.GetAll);
            Router.Instance.Register(2, "Them sinh vien", studentController.Add);

            while (true)
            {
                Router.Instance.Redirect(0);
            }
            
        }
    }
}