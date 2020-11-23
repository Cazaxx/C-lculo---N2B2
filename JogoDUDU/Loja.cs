using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JogoDUDU
{
    public class Loja
    {
        
        public string[] RetornaSkinsPossuidas(string arquivo, string padrao)
        {
            if (!File.Exists(arquivo))
            {
                File.WriteAllText(arquivo, padrao);
            }

            return File.ReadAllLines(arquivo);
        }
    }
}
