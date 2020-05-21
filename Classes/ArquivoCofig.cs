using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Classes
{
    //Objeto para guardar as configurações
    public class ArquivoCofig
    {
        string tree = "pai";
        public FilhoArvore configDirectory { get; set; }
        public SystemDirectory systemDirectory { get; set; }
        public FilhoArvore arm1 { get; set; }
    }


    public class FilhoArvore
    {
        public int idpai { get; set; }
        public int id { get; set; }
        public string descricao { get; set; }
        public List<Item> itens { get; set; }
        public List<FilhoArvore> filhos {get;set;}
    }

    public class Item
    {
        public int id { get; set; }
        public string descrição { get; set; }
        public string valor { get; set; }
        public string comentarios { get; set; }
    }

    public class SystemDirectory
    {
        public string descricao { get; } = "System Directory";
        public string tree { get; } = "raiz";
        public FilhoArvore generalPurpose{ get; set; }
        public FilhoArvore flowControl { get; set; }
        public FilhoArvore volumeAccuracy { get; set; }
    }
}
