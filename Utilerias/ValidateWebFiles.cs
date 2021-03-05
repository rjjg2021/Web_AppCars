using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_AppCars.Utilerias
{
    public class ValidateWebFiles
    {
        public static string ValidateWebImage(string url)
        {
            int flag = 0;
            System.Net.HttpWebRequest request = null;
            System.Net.HttpWebResponse response = null;
            request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            request.Timeout = 30000;
            try
            {
                response = (System.Net.HttpWebResponse)request.GetResponse();
                flag = 1;
            }
            catch
            {
                flag = -1;
            }

            if (flag == 1)
            {
                return url;
            }
            else
            {
                return "http://todovector.com/vector/medios-de-transporte/terrestres/autos-y-vehiculos/siluetas-autos/2.png";
            }
        }
    }
}
