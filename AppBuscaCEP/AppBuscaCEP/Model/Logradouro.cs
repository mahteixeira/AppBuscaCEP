using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuscaCEP.Model
{
    public class Logradouro
    {
        public int id { get; set; }
        public string desc_bairro { get; set; }
        public int id_cidade { get; set; }
        public string desc { get; set;}
        public int CEP { get; set; }
    }
}
