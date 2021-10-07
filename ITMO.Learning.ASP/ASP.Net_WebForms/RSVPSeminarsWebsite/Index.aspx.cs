using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSVPSeminarsWebsite
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid) return;
                byte bdValidate = 0;
                using (RSVPSeminars rsvp = new RSVPSeminars())
                {
                    bdValidate = (byte)(from member in rsvp.WorkshopParticipants
                                        where member.Phone == tbPhone.Text
                                        select new { member.GuestResponsesId }).Count();
                }
                if (bdValidate == 0)
                {
                    bool willAttend = true, secondReport = true;
                    if (CheckBoxYN.Checked == false) willAttend = false;
                    if (tbReportName2.Text == "") secondReport = false;

                    WorkshopParticipants newMember = new WorkshopParticipants
                    {
                        Name = tbName.Text,
                        LastName = tbLastName.Text,
                        Phone = tbPhone.Text,
                        Email = tbEmail.Text,
                        RegistrationDate = DateTime.Now,
                        WillAttend = willAttend
                    };
                    
                    using (RSVPSeminars rsvp = new RSVPSeminars())
                    {
                        rsvp.WorkshopParticipants.Add(newMember);
                        rsvp.SaveChanges();
                        if (willAttend)
                        {
                            var query = (from member in rsvp.WorkshopParticipants
                                         where member.Phone == tbPhone.Text
                                         select new { member.GuestResponsesId }).First();

                            Reports report = new Reports
                            {
                                GuestResponseId = query.GuestResponsesId,
                                NameReport = tbReportName1.Text,
                                Annotation = Annotation1.Text

                            };

                            if (secondReport)
                            {
                                Reports reportTwo = new Reports
                                {
                                    GuestResponseId = query.GuestResponsesId,
                                    NameReport = tbReportName2.Text,
                                    Annotation = Annotation2.Text
                                };
                                rsvp.Reports.Add(reportTwo);
                            }
                            rsvp.Reports.Add(report);
                            rsvp.SaveChanges();
                        }
                    }
                    if (willAttend)Response.Write("<script>alert('Благодарим за участие в нашем семинаре. Напоминаем Вам, что презентацию для доклада необходимо загрузить до 16:00 часов 10 января. Увидимся на семинаре!')</script>"); 
                    else Response.Write("<script>alert('Благодарим за участие в нашем семинаре. До встречи!')</script>");
                }
                else Response.Write("<script>alert('Вы уже зарегестрированы как участник семенара.')</script>");

            }

        }

    }
}