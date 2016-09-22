using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Windows.Input;
using System.IO;
using System.Net;
using System.Net.Sockets;

public partial class Pages_CPSGateway : System.Web.UI.Page
{

     static string creditcardAuthorization;
    static string message;
    protected void Page_Load(object sender, EventArgs e)
    {
        Amount.Text = Session["TotalAmount"].ToString();
    }
    protected void creditCardSubmitButton_Click(object sender, EventArgs e)
    {
        creditCardSubmitEventMethod();
        if (creditcardAuthorization.Length > 89)
        {
            string auth = creditcardAuthorization.Substring(89, 7);
            responseLb.Text = auth;
            Session["AuthCode"] = auth.Trim();
            Response.Redirect("~/Pages/LoginRegister/Success.aspx");
        }
        else
        {
            responseLb.Text = creditcardAuthorization;
        }
    }
    protected void creditCardSubmitEventMethod(object sender, EventArgs e)
    {
       
    }
    private void creditCardSubmitEventMethod()
    {
        Boolean exception_thrown = false;

        UdpClient udpSend = new UdpClient();

        IPAddress ipAddress = Dns.GetHostEntry("blitz.cs.niu.edu").AddressList[0];

        byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(creditcardnumTexbox.Text + ":" + expirationdateTexbox.Text + ":"
                           + Session["TotalAmount"].ToString() + ":" + firstnameTextbox.Text + " " + lastnameTextbox.Text);

        int port = 4445;
        IPEndPoint ep = new IPEndPoint(ipAddress, port);
        udpSend.Connect(ep);
        try
        {
            udpSend.Send(packetData, packetData.Length);
        }
        catch (Exception ex)
        {
            exception_thrown = true;
            //responseError.Text =ex.ToString]();
        }
        if (exception_thrown == false)
        {
            responseError.Text = "Credit card information sent!";
        }
        else
        {
            responseError.Text ="Credit card information submission fail!";
        }
        try
        {
            var receivedata = udpSend.Receive(ref ep);
            creditcardAuthorization = Encoding.ASCII.GetString(receivedata);
            //responseLb.Text = "creditcardAuthorization.ToString();";
        }
        catch (Exception ex)
        {
            responseError.Text = "Failed";
//            MessageBox.Show(e.ToString());
        }
    }

   
}