using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace StudentPerformanceWebsite
{
    public partial class Worse5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string GetHtmlStudentsTable()
        {
            StringBuilder html = new StringBuilder();
            using (Students std = new Students())
            {
                var query = (from student in std.View_WorseStudents
                             select student).ToList();
                int i = 1;
                foreach (var student in query)
                {

                    html.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td><td>{10}</td></tr>", i++, student.Name, student.LastName, student.BasicsProgramingСourse, student.C_Сourse, student.AspNetСourse, student.AdoNetСourse, student.JavaСourse, student.PythonСourse, student.WebСourse, student.FinalGrade));
                }
            }
            return html.ToString();
        }
    }
}