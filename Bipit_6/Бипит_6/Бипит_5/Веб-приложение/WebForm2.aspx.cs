using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Веб_приложение
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
                GridView1.DataSource = s.GetData();
                GridView1.DataBind();

                DropDownList1.DataSource = s.FillOboryd();
                DropDownList1.DataTextField = "Model_oboryd";
                DropDownList1.DataValueField = "ID_OBORYD";
                DropDownList1.DataBind();

                DropDownList2.DataSource = s.FillVid_rabot();
                DropDownList2.DataTextField = "Name_vid_rabot";
                DropDownList2.DataValueField = "ID_VID_RABOT";
                DropDownList2.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            var ID_OBORYD = DropDownList1.Text;
            var ID_VID_RABOT = DropDownList2.Text;
            var Data_polychen = dateEx.Text;
            var Data_vipolnen = dateEx0.Text;
            if (!(Data_polychen == "" || Data_vipolnen == ""))
            {
                s.NewRec(ID_OBORYD, ID_VID_RABOT, Data_polychen, Data_vipolnen);
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}