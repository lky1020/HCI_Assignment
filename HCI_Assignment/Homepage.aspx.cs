using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCI_Assignment
{
    public partial class Homepage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Response.Write("<script>if(confirm('Hi, would you like to Login first to access our artworks?')){window.location = 'Homepage.aspx?nav=yes';} else {}</script>");
            }
            else
            {
                if (Session["userRole"] != null)
                {
                    //Direct to gallery
                    if (Session["userRole"].ToString().Equals("Artist"))
                    {
                        Response.Write("<script>window.location = 'ArtistGallery.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>window.location = 'ArtWorks.aspx';</script>");
                    }
                }
                else
                {
                    Response.Write("<script>window.location = 'ArtWorks.aspx';</script>");
                }
            }
        }
    }
}