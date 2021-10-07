using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSVPSeminarsWebsite
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string GetNoShowHtmlMemberReport()
        {
            StringBuilder html = new StringBuilder();
            using (RSVPSeminars rsvp = new RSVPSeminars())
            {
                var queryMember = (from member in rsvp.View_MemberIsReport
                                   select member).ToList();
                int i = 1;
                foreach (var member in queryMember)
                {

                    html.Append(String.Format("<tr><td class=\"DisplayNumFromTable\">{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>", i++, member.Name, member.LastName, member.NameReport, member.Annotation));
                }
            }
            return html.ToString();
        }
        protected string GetNoShowHtmlMember()
        {
            StringBuilder html = new StringBuilder();
            using (RSVPSeminars rsvp = new RSVPSeminars())
            {
                var queryMember = (from member in rsvp.WorkshopParticipants
                                   where member.WillAttend == false
                                   select new { member.Name, member.LastName }).ToList();
                int i = 1;
                foreach (var member in queryMember)
                {

                    html.Append(String.Format("<tr><td class=\"DisplayNumFromTable\">{0}</td><td>{1}</td><td>{2}</td></tr>", i++, member.Name, member.LastName));
                }
            }
            return html.ToString();
        }
    }
}