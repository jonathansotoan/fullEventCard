using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZXing.QrCode;


namespace apps.fullEventCard
{
    public partial class QrMovil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Refrescarqr();
        }


        public void Refrescarqr()
        {
            if (Session["id"] != null)
            {
                string id = "http://landingforce-001-site1.smarterasp.net/Checkin.aspx?Evento=1&id=" + Session["id"].ToString();


            QRCodeWriter qr = new QRCodeWriter();

            var matrix = qr.encode(id, ZXing.BarcodeFormat.QR_CODE, 500, 500);

            ZXing.BarcodeWriter w = new ZXing.BarcodeWriter();

            w.Format = ZXing.BarcodeFormat.QR_CODE;

            Bitmap img = w.Write(matrix);

            string base64String = string.Empty;

            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, ImageFormat.Png);

            memoryStream.Position = 0;
            byte[] byteBuffer = memoryStream.ToArray();

            memoryStream.Close();

            base64String = Convert.ToBase64String(byteBuffer);
            byteBuffer = null;

            imgQr.ImageUrl = "data:image/png;base64," + base64String;

            }

        }
    }
}