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
    public class Context
    {
        public List<Student> Students { get; set; }

        public void Load()
        {
            if (File.Exists(Constant.FILE_PATH))
            {
                using (FileStream fileStream = new FileStream(Constant.FILE_PATH, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    List<Student> students = (List<Student>)binaryFormatter.Deserialize(fileStream);
                    Students = students;
                    Human.NextId = students.Max(x => x.Id) + 1;
                }
            }
        }

        public void SaveChanges()
        {
            using (FileStream fileStream = new FileStream(Constant.FILE_PATH, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, Students);
            }
        }
    }
}
