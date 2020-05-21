using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Teste.Classes
{
    class Arquivo
    {
        public static void Salvar(List<FilhoArvore> dado, string endereço )
        {
            
            var serializer = new XmlSerializer(typeof(List<FilhoArvore>));
            var localArquivo = "C:/teste/arquivo.xml";
            var xmlNamespaces = new XmlSerializerNamespaces();

            using (var textWriter = new StreamWriter(endereço))
            {
                serializer.Serialize(textWriter, dado, xmlNamespaces);
            }
        }
        //Instancia objeto de configuração 
        public static List<FilhoArvore> CriaArquivo()
        {
            List<FilhoArvore> config = new List<FilhoArvore>();
            Item item = new Item();
            List<Item> listaItem = new List<Item>();
            FilhoArvore filho ;
            SystemDirectory systemDirectory = new SystemDirectory();


            filho = new FilhoArvore();
            filho.id = 1;
            filho.descricao = "Config Directory";
            filho.itens = listaItem;
            config.Add(filho);
            

            filho = new FilhoArvore();
            filho.id = 2;
            filho.idpai = 1;
            filho.descricao = "General Purpose";
            listaItem = new List<Item>();
            filho.itens = listaItem;
            

            //Inicio itens configuração
            item.id = 105;
            item.descrição = "Maximum Available Arms";
            item.valor = "0";
            filho.itens.Add(item);

            item = new Item();
            item.id = 1110;
            item.descrição = "Pemes Option";
            item.valor = "Enabled";
            filho.itens.Add(item);

            item = new Item();
            item.id = 103;
            item.descrição = "MAC Address";
            item.valor = "00:0c:29:55:00:d1";
            filho.itens.Add(item);

            item = new Item();
            item.id = 104;
            item.descrição = "Firmware Revision";
            item.valor = "0.9";
            filho.itens.Add(item);

            item = new Item();
            item.id = 1102;
            item.descrição = "Firmware Identifier";
            item.valor = "ge22ed23f[overlay]";
            filho.itens.Add(item);

            item = new Item();
            item.id = 1103;
            item.descrição = "Unit ID";
            item.valor = "AccuLoad IV";
            filho.itens.Add(item);

            item = new Item();
            item.id = 111;
            item.descrição = "Flow Rate Time";
            item.valor = "per minute";
            filho.itens.Add(item);

            item = new Item();
            item.id = 1110;
            item.descrição = "Flow Rate Descriptor";
            item.valor = "";
            filho.itens.Add(item);
            config.Add(filho);
            //Fim itens configuração



            //Inicio itens configuração
            filho = new FilhoArvore();
            filho.id = 3;
            filho.idpai = 1;
            filho.descricao = "Flow Control";
            listaItem = new List<Item>();
            filho.itens = listaItem;

            item = new Item();
            item.id = 201;
            item.descrição = "Solenoid Alarm Count";
            item.valor = "0";
            filho.itens.Add(item);

            item = new Item();
            item.id = 204;
            item.descrição = "Solenoid Count Clear";
            item.valor = "Manual";
            filho.itens.Add(item);

            item = new Item();
            item.id = 202;
            item.descrição = "Leakage Alarm Limit";
            item.valor = "0.0";
            filho.itens.Add(item);

            item = new Item();
            item.id = 203;
            item.descrição = "Reverse Flow Limit";
            item.valor = "0.0";
            filho.itens.Add(item);

            item = new Item();
            item.id = 1200;
            item.descrição = "Flow Simulator Selection";
            item.valor = "Disable";
            filho.itens.Add(item);
            config.Add(filho);
            //Fim itens configuração


            //Inicio itens configuração
            filho = new FilhoArvore();
            filho.id = 4;
            filho.idpai = 1;
            filho.descricao = "Volume Accuracy";
            listaItem = new List<Item>();
            filho.itens = listaItem;

            item.id = 101;
            item.descrição = "Pulse Transmitter Select";
            item.valor = "Single";
            filho.itens.Add(item);

            item = new Item();
            item.id = 102;
            item.descrição = "Transmitter Integrity";
            item.valor = "No";
            filho.itens.Add(item);

            item = new Item();
            item.id = 146;
            item.descrição = "Reverse Volume - Batch";
            item.valor = "Ignore";
            filho.itens.Add(item);

            item = new Item();
            item.id = 147;
            item.descrição = "Reverse Volume = Non-Resets";
            item.valor = "Ignore";
            filho.itens.Add(item);

            item = new Item();
            item.id = 301;
            item.descrição = "Volume Units";
            item.valor = "gal";
            filho.itens.Add(item);

            item = new Item();
            item.id = 302;
            item.descrição = "Mass Unit";
            item.valor = "lb";
            filho.itens.Add(item);

            item = new Item();
            item.id = 303;
            item.descrição = "Volume Descriptor";
            item.valor = "gal";
            filho.itens.Add(item);

            item = new Item();
            item.id = 304;
            item.descrição = "Mass Descriptor";
            item.valor = "lb";
            filho.itens.Add(item);
            config.Add(filho);

            return config;
        }
    }
}
