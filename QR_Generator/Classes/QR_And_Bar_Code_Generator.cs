using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Generator.Classes
{
    class QR_And_Bar_Code_Generator
    {
        /// <summary>
        /// Method create Barcode
        /// </summary>
        /// <param name="text"> Your text to code </param>
        /// <returns> Return image </returns>
        public System.Drawing.Image Generate_Bar_Code(string text)
        {
            Zen.Barcode.Code128BarcodeDraw Barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            return Barcode.Draw(text, 50);
        }

        /// <summary>
        /// Method create QRc ode
        /// </summary>
        /// <param name="text"> Your text to code </param>
        /// <returns> Return image </returns>
        public System.Drawing.Image Generate_QR_Code(string text)
        {
            Zen.Barcode.CodeQrBarcodeDraw QRcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;

            return QRcode.Draw(text, 50);
        }
    }
}
