﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dbms_project.search
{
    public partial class search : System.Web.UI.Page

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Users\Archit\source\repos\dbms project\dbms project\App_Data\mydata.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["login"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
            Session["value"] = str;
            Session["search"]= Session["login"].ToString(); 
            Response.Redirect("result.aspx");
        }
    }
}