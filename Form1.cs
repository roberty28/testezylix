using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Classes;

namespace Teste
{
    public partial class Form1 : Form
    {
        private int count ;
        private List<List<FilhoArvore>> arquivos = new List<List<FilhoArvore>>();
        public Form1()
        {

            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            List<FilhoArvore> lista = Arquivo.CriaArquivo();
            int filaLista = arquivos.Count();
            arquivos.Add(lista);
            count++;

            DataGridView dataGridView = new System.Windows.Forms.DataGridView();
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(181, -1);
            dataGridView.Name = "dataGridViewN" + count;
            dataGridView.Size = new System.Drawing.Size(604, 352);
            dataGridView.TabIndex = 1;

            //Cria aba com o arquivo
            TabPage tabPage = new System.Windows.Forms.TabPage();
            tabPage.Name = "tabPageN"+count;
            tabPage.Text = "Arquivo_Teste" + count;
            tabPage.Controls.Add(dataGridView1);
            tabPage.Tag = filaLista;

            TreeView treeView = new System.Windows.Forms.TreeView();
            treeView.Size = new System.Drawing.Size(181, 351);
            treeView.TabIndex = 0;
            treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);

            List<TreeNode> nodes = new List<TreeNode>();
            for (int i=0; i < lista.Count;i++)
            {
                TreeNode tree = new System.Windows.Forms.TreeNode();
                tree.Name = "no" + i;
                tree.Text = lista[i].descricao;
                tree.Tag = lista[i].id;
                nodes.Add(tree);
            }

            for (int i = 0; i < nodes.Count;i++)
            {
                for (int i2 = 0; i2 < lista.Count;i2++)
                {
                    if (int.Parse(nodes[i].Tag.ToString()) == lista[i2].id)
                    {
                        if (lista[i2].idpai != 0)
                        {
                            for (int i3 = 0; i3 < nodes.Count;i3++)
                            {
                                if (int.Parse(nodes[i3].Tag.ToString()) == lista[i2].idpai)
                                    nodes[i3].Nodes.Add(nodes[i]);
                            }
                        }
                        i2 = lista.Count;
                    }
                }
                
            }

            for (int i = 0; i < nodes.Count;i++)
            {
                for (int i2 = 0; i2 < lista.Count; i2++)
                {
                    if (int.Parse(nodes[i].Tag.ToString()) == lista[i2].id)
                    {
                        if (lista[i2].idpai == 0)
                            treeView.Nodes.Add(nodes[i]);
                        else
                            nodes.Remove(nodes[i]);
                    }
                }
            }

            

            tabPage.Controls.Add(treeView);
            tabMain.TabPages.Add(tabPage);
            this.tabMain.SelectedIndex = tabMain.TabPages.Count - 1;

        }

        private void btnFechaAba_Click(object sender, EventArgs e)
        {
            
            tabMain.TabPages.Remove(tabMain.SelectedTab);
            tabMain.SelectedIndex = tabMain.TabPages.Count - 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            string nome = tabMain.SelectedTab.Name.ToString();
            int indice = int.Parse(nome.Substring(nome.Length - 1)) - 1;
            sv.FileName = nome;
            if(sv.ShowDialog() == DialogResult.OK)
            {
                Arquivo.Salvar(arquivos[indice], sv.FileName);
            }

            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string dados = e.Node.Tag.ToString();
            List<Item> itens = new List<Item>();
            int lista = int.Parse(tabMain.SelectedTab.Tag.ToString());

            for (int i =0;i< arquivos[lista].Count;i++)
            {
                if(arquivos[lista][i].id == int.Parse(dados))
                    itens = arquivos[lista][i].itens;
            }
            dataGridView1.DataSource = itens;
        }
    }
}
