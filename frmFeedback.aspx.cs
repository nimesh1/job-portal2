using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
public partial class frmFeedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string MailAdd, MailPwd;
            MailAdd = "siddiquimauzzam@gmail.com";
            MailPwd = "mauzzam786";
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add("siddiquimauzzam@gmail.com");
            mail.From = new System.Net.Mail.MailAddress(MailAdd);
            mail.Subject = "Feedback from website";
            mail.Body = "Name:  '" + txtActNo.Text + "', Email: '" + txtMail.Text + "' ,  Feedback: '" + txtMsg.Text + "'";
            mail.CC.Add(MailAdd);
            mail.IsBodyHtml = false;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(MailAdd, MailPwd);
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mail);
            Response.Write("<script>alert('Feedback Submitted Successfully!')</script>");
        }
        catch
        {
            Response.Write("Fail");
        }
    }
}
