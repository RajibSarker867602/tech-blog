using BarcodeLib;
using LeadingEdgeServer.Models.Request.BarCode;

namespace LeadingEdgeServer.Models.Utilities
{
    public class BarCodeGenerator
    {
        public static byte[] GenerateBarCode(BarCodeRequestParams barCodeReq)
        {
            if (string.IsNullOrEmpty(barCodeReq.BarCodeText) || barCodeReq.BarCodeText.Length != 12) throw new Exception("Invalid text to generate barcode!");

            var barCode = new Barcode();
            barCode.IncludeLabel = true;
            System.Drawing.Image img = barCode.Encode(BarcodeLib.TYPE.CODE128, barCodeReq.BarCodeText, System.Drawing.Color.Black, System.Drawing.Color.White, barCodeReq.Width, barCodeReq.Height);

            return ImageToByteArray(img);
        }

        private static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
