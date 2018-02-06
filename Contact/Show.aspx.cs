using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contact
{
    public partial class Show : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            //GridView1.DataSource = db.Contacts;
        }
    }
}