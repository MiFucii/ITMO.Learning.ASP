using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSVPSeminarsWebsite
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long numVisitors = 0;
            if (Application["Visitors"] != null)
            {
                numVisitors = long.Parse(Application["Visitors"].ToString());
                VisitorLiteral.Text = "Число посещений: " + numVisitors.ToString();
            }
        }

        protected string GetTimeStartSeminars()
        {
            DateTime dataSeminar = new DateTime(2022, 1, 11, 10, 00, 0);
            DateTime dNow = DateTime.Now;
            int rd = (dataSeminar - dNow).Days;
            int rm = (dataSeminar - dNow).Minutes;
            int rh = (dataSeminar - dNow).Hours;
            StringBuilder html = new StringBuilder();
            html.Append(string.Format("{0} дней, {1} час(ов), {2} мин.", rd, rh, rm));
            return html.ToString();
        }
    }
}
