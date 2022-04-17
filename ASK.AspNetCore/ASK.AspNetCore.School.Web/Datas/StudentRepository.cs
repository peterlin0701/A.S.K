using ASK.AspNetCore.School.Web.Models;

namespace ASK.AspNetCore.School.Web.Datas
{
    public class StudentRepository
    {
        public static Student Get(string id)
        {
            Student entity = new()
            {
                 ID = "A123456789",
                 Name = "好學生"
            };


            return entity;
        }


        public static IEnumerable<Student> GetList()
        {
            var entities = new List<Student>();
            entities.Add(new() { ID = "A123456789", Name = "好學生" });
            entities.Add(new() { ID = "H123446565", Name = "楊慶鈺" });
            entities.Add(new() { ID = "T123456141", Name = "賴喜添" });
            entities.Add(new() { ID = "Y223114789", Name = "王雅昌" });
            entities.Add(new() { ID = "E123456789", Name = "廣玉婷" });
            entities.Add(new() { ID = "G123456789", Name = "陳婷婷" });
            entities.Add(new() { ID = "G123558767", Name = "簡佳玲" });
            return entities;
        }
    }
}
