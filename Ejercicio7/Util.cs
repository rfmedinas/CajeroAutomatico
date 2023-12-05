using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class Util
    {
    public static  Boolean validarNumeroPositivo(String numero)
    {
        if (Double.TryParse(numero, out double valor))
        {
            return valor > 0;
        
        }
      else {  return false; }  

    }
    }

