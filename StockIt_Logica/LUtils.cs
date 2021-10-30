using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LUtils
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public string fechaAAAAMMDD()
        {
            try
            {
                return WS.fechaAAAAMMDD();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string fechaDDMMAAAA()
        {
            try
            {
                return WS.fechaDDMMAAAA();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
