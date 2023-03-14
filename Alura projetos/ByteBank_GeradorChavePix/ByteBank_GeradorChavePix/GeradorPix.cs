using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_GeradorChavePix
{
    ///<summary>
    ///Classe que gera chaves pix usando o formato Guid.
    ///</summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método que retorna uma chave aleatória de pix.
        /// </summary>
        /// <returns>Retorna uma chave Pix no formato string</returns>

       
        public static string GetChavePix()
            
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Método que retorna uma lista aleatória de chaves PIX.
        /// </summary>
        /// <param name="numChaves">Quantidade de chaves a serem geradas.</param>
        /// <returns>Uma lista de string de chaves pix.</returns>
        public  static List <string> GetChavePix(int numChaves)
        {
            if (numChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();

                for (int i = 0; i < numChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves; 
            }
        }
    }
}
