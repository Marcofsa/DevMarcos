using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            if(url == "")
            {
                throw new ArgumentException("A url não pode ser uma string vazia.", nameof(url));
            }

            URL = url;
        }
    }
}
