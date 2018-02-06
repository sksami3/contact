using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Contact
{
    public partial class Index : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.id = TextBox1.Text;
            contact.name = TextBox2.Text;
            contact.phone_number = TextBox3.Text;
            contact.address = TextBox4.Text;

            db.Contacts.InsertOnSubmit(contact);
            db.SubmitChanges();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Contact contact = new Contact();
            string _id = TextBox1.Text;
            var temp = db.Contacts.First(x=> x.id==_id);

            if(temp.id== TextBox1.Text)
            {
                
                TextBox1.Text= temp.id;
                TextBox2.Text = temp.name;
                TextBox3.Text = temp.phone_number;
                TextBox4.Text = temp.address;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string _id = TextBox1.Text;
            var temp = db.Contacts.First(x => x.id == _id);

            if (temp.id == TextBox1.Text)
            {
                
                temp.name = TextBox2.Text;
                temp.phone_number = TextBox3.Text;
                temp.address = TextBox4.Text;
                db.SubmitChanges();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string _id = TextBox1.Text;
            var temp = db.Contacts.First(x => x.id == _id);

            if (temp.id == TextBox1.Text)
            {

                db.Contacts.DeleteOnSubmit(temp);
                db.SubmitChanges();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Show s = new Show();
            Server.Transfer("Show.aspx", true);
        }
    }
}