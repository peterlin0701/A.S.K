using ASK.AspNetCore.School.Web.Models;

namespace ASK.AspNetCore.School.Web.Datas
{
    public class CourseRepository
    {
        public static Course Get(int id)
        {
            Course entity = new()
            {
                ID = 1,
                Name = "計算機概論"
            };


            return entity;
        }


        public static IEnumerable<Course> GetList()
        {
            var entities = new List<Course>();
            entities.Add(new() { ID = 1, Name = "計算機概論" });
            entities.Add(new() { ID = 2, Name = "離散數學" });
            entities.Add(new() { ID = 3, Name = "線性代數" });
            entities.Add(new() { ID = 4, Name = "計算機系統實驗" });
            entities.Add(new() { ID = 5, Name = "視窗程式設計" });
            entities.Add(new() { ID = 6, Name = "組合數學" });
            entities.Add(new() { ID = 7, Name = "軟體工程" });
            return entities;
        }
    }
}
