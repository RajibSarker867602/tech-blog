using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.BarCode
{
    /// <summary>
    /// Bar code request params
    /// </summary>
    public class BarCodeRequestParams
    {
        /// <summary>
        /// Text to generate barcode
        /// </summary>
        public string BarCodeText { get; set; }

        /// <summary>
        /// Height in pixel
        /// </summary>
        public int Height { get; set; } = 30;

        /// <summary>
        /// Width in pixel
        /// </summary>
        public int Width { get; set; } = 180;

        /// <summary>
        /// Font family name
        /// </summary>
        public string FontFamilyName { get; set; } = "Cambria";

        /// <summary>
        /// Font size in pixel
        /// </summary>
        public int FontSize { get; set; } = 15;

        /// <summary>
        /// Save the barcode
        /// </summary>
        public bool IsSaved { get; set; }
    }
}
