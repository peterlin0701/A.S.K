using System.ComponentModel;

namespace ASK.AspNetCore.School.Web.Models
{
    public class Student
    {
        /// <summary>
        /// 學號
        /// </summary>
        [DisplayName("學號")]
        public string ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName("姓名")]
        public string Name { get; set; }
    }
}
