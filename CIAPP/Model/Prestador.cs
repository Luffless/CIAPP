using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CIAPP.Model
{
    public class Prestador
    {
        int codigo { get; set; }
        public string nomeMae { get; set; }
        public string dataNascimento { get; set; }
        public string naturalidade { get; set; }
        public string estadoCivil { get; set; }
        public string foto { get; set; }
        public string profissao { get; set; }
        public string parentesco { get; set; }
        public string telefone { get; set; }
        public string etinia { get; set; }
        public string grauInstucao { get; set; }
        public string religiao { get; set; }
        public string recebeBeneficio { get; set; }
        public string deficiencia { get; set; }
        public string usaAlcool { get; set; }
        public string usaDrogras { get; set; }
        public string observacao { get; set; }
    }
}
