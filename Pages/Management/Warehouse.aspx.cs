using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Pages_Management_Warehouse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string authId = GridView1.SelectedRow.Cells[2].Text;

        string order = GridView1.SelectedRow.Cells[1].Text;
        generateReport(authId, order);
    }

    public void generateReport(string auth, string order)
    {
        string companyName = "Illinois Autoshop";
        /*****************************************************************************************/
        Order o = new Order();
        List<warehouse> wh = o.orderList(auth);

        CartModel cm = new CartModel();
        List<cart> clist = cm.cartList(auth);
      
        PdfPTable myTable = new PdfPTable(5);
        myTable.DefaultCell.Padding = 1;
      
        myTable.DefaultCell.Padding = 1;
        myTable.SetWidths(new int[] { 30, 30, 30 ,30,30 });
        myTable.TotalWidth = 100;

        PdfPCell header1 = new PdfPCell(new Phrase("OrderID"));
        PdfPCell header2 = new PdfPCell(new Phrase("PaymentID"));
        PdfPCell header3 = new PdfPCell(new Phrase("Name"));
        PdfPCell header4 = new PdfPCell(new Phrase("ShippingAddress"));
        PdfPCell header5 = new PdfPCell(new Phrase("DeliveryStatus"));
        myTable.AddCell(header1);
        myTable.AddCell(header2);
        myTable.AddCell(header3);
        myTable.AddCell(header4);
        myTable.AddCell(header5);


        for (int i=0; i<wh.Count; i++)
        {
            PdfPCell cell1 = new PdfPCell(new Phrase(order));
            PdfPCell cell2 = new PdfPCell(new Phrase(wh[i].paymentID));
            PdfPCell cell3 = new PdfPCell(new Phrase(wh[i].Name));
            PdfPCell cell4 = new PdfPCell(new Phrase(wh[i].shippingAddress));
            PdfPCell cell5 = new PdfPCell(new Phrase(wh[i].DeliveryStatus));
            myTable.AddCell(cell1);
            myTable.AddCell(cell2);
            myTable.AddCell(cell3);
            myTable.AddCell(cell4);
            myTable.AddCell(cell5);
        }

        /********************************************************************************************/
        PdfPTable cartTable = new PdfPTable(4);
        cartTable.DefaultCell.Padding = 1;

        cartTable.DefaultCell.Padding = 1;
        cartTable.SetWidths(new int[] { 30, 30, 30, 30 });
        cartTable.TotalWidth = 100;

        PdfPCell heade1 = new PdfPCell(new Phrase("Product ID"));
        PdfPCell heade2 = new PdfPCell(new Phrase("Quantity"));
        PdfPCell heade3 = new PdfPCell(new Phrase("DatePurchased"));
        PdfPCell heade4 = new PdfPCell(new Phrase("Product Name"));
        
        cartTable.AddCell(heade1);
        cartTable.AddCell(heade2);
        cartTable.AddCell(heade3);
        cartTable.AddCell(heade4);
        


        for (int i = 0; i < clist.Count; i++)
        {
            PdfPCell cell1 = new PdfPCell(new Phrase(clist[i].ProductId.ToString()));
            PdfPCell cell2 = new PdfPCell(new Phrase(clist[i].Amount.ToString()));
            PdfPCell cell3 = new PdfPCell(new Phrase(clist[i].DatePurchased.ToString()));
            PdfPCell cell4 = new PdfPCell(new Phrase(clist[i].partName));

            cartTable.AddCell(cell1);
            cartTable.AddCell(cell2);
            cartTable.AddCell(cell3);
            cartTable.AddCell(cell4);
          
        }

        
        /*****************************************************************************************/
        Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
        PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

        pdfDocument.Open();
    
        pdfDocument.Add(myTable);
        pdfDocument.Add(cartTable);
        pdfDocument.Close();

        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=Invoice_" + companyName + ".pdf");
        Response.Write(pdfDocument);
        Response.Flush();
        Response.End();
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string authId = GridView2.SelectedRow.Cells[2].Text;

        string order = GridView2.SelectedRow.Cells[1].Text;
        generateReport(authId, order);
    }
}


