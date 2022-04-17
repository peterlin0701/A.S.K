using System.ComponentModel;

namespace ASK.AspNetCore.School.Web.Models
{
    public class Course
    {
        /// <summary>
        /// 課程編號
        /// </summary>
        [DisplayName("課程編號")]
        public int ID { get; set; }
        /// <summary>
        /// 課程名稱
        /// </summary>
        [DisplayName("課程名稱")]
        public string Name { get; set; }
        /// <summary>
        /// 學分數
        /// </summary>
        [DisplayName("學分數")]
        public int Credit { get; set; }
    }
}
