namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nó2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nó6", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFechaAba = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.AllowDrop = true;
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabMain.ItemSize = new System.Drawing.Size(58, 30);
            this.tabMain.Location = new System.Drawing.Point(3, 112);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(796, 377);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nó1";
            treeNode1.Tag = "1";
            treeNode1.Text = "Nó1";
            treeNode2.Name = "Nó0";
            treeNode2.Text = "Nó0";
            treeNode3.Name = "Nó3";
            treeNode3.Text = "Nó3";
            treeNode4.Name = "Nó4";
            treeNode4.Text = "Nó4";
            treeNode5.Name = "Nó5";
            treeNode5.Text = "Nó5";
            treeNode6.Name = "Nó2";
            treeNode6.Text = "Nó2";
            treeNode7.Name = "Nó7";
            treeNode7.Text = "Nó7";
            treeNode8.Name = "Nó8";
            treeNode8.Text = "Nó8";
            treeNode9.Name = "Nó6";
            treeNode9.Text = "Nó6";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(181, 351);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(796, 106);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.btnFechaAba);
            this.tabPage3.Controls.Add(this.btnSalvar);
            this.tabPage3.Controls.Add(this.btnAbrirArquivo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 80);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnFechaAba
            // 
            this.btnFechaAba.Location = new System.Drawing.Point(93, 3);
            this.btnFechaAba.Name = "btnFechaAba";
            this.btnFechaAba.Size = new System.Drawing.Size(84, 23);
            this.btnFechaAba.TabIndex = 2;
            this.btnFechaAba.Text = "Fecha aba";
            this.btnFechaAba.UseVisualStyleBackColor = true;
            this.btnFechaAba.Click += new System.EventHandler(this.btnFechaAba_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirArquivo.Location = new System.Drawing.Point(6, 3);
            this.btnAbrirArquivo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(84, 26);
            this.btnAbrirArquivo.TabIndex = 0;
            this.btnAbrirArquivo.TabStop = false;
            this.btnAbrirArquivo.Text = "Abrir arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnFechaAba;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

