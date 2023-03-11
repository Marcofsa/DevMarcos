using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_GeradorChavePix
{
    public static class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }
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
