using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Helpers
{
    internal static partial class CaixaVazia
    {
        internal static bool NaoExisteTexto(string texto)
        {
            foreach (var letra in texto)
            {
                if (char.IsLetter(letra))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
