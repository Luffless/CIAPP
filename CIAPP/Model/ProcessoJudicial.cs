using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIAPP.Model
{
    public class ProcessoJudicial
    {
        public int codigo { get; set; }
        public string origem { get; set; }
        public bool acordo { get; set; }
        public string penaOriginaria { get; set; }
        public string tempoCumprir { get; set; }
        //no pré projeto as datas estão como string, tem que conferir se é isso mesmo
        public string dataInicio { get; set; }
        public string dataTermino { get; set; }
    }
}
