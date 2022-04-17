using System.ComponentModel;

namespace ASK.AspNetCore.School.Web.Models
{
    public class StudentToCourses
    {
        /// <summary>
        /// 學號
        /// </summary>
        [DisplayName("學號")]
        public int StudentID { get; set; }
        /// <summary>
        /// 課程編號
        /// </summary>
        [DisplayName("課程編號")]
        public int CourseID { get; set; }
        /// <summary>
        /// 學年期
        /// </summary>
        [DisplayName("學年期")]
        public string Semester { get; set; }
    }
}
