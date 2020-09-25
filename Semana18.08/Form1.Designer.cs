namespace Semana18._08
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
            this._semana18_08bddDataSet = new Semana18._08._semana18_08bddDataSet();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new Semana18._08._semana18_08bddDataSetTableAdapters.CarrosTableAdapter();
            this.tableAdapterManager = new Semana18._08._semana18_08bddDataSetTableAdapters.TableAdapterManager();
            this.carrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogosTableAdapter = new Semana18._08._semana18_08bddDataSetTableAdapters.JogosTableAdapter();
            this.jogosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomesTableAdapter = new Semana18._08._semana18_08bddDataSetTableAdapters.NomesTableAdapter();
            this.nomesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._semana18_08bddDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _semana18_08bddDataSet
            // 
            this._semana18_08bddDataSet.DataSetName = "_semana18_08bddDataSet";
            this._semana18_08bddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this._semana18_08bddDataSet;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrosTableAdapter = this.carrosTableAdapter;
            this.tableAdapterManager.JogosTableAdapter = this.jogosTableAdapter;
            this.tableAdapterManager.NomesTableAdapter = this.nomesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Semana18._08._semana18_08bddDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carrosDataGridView
            // 
            this.carrosDataGridView.AutoGenerateColumns = false;
            this.carrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.carrosDataGridView.DataSource = this.carrosBindingSource;
            this.carrosDataGridView.Location = new System.Drawing.Point(12, 46);
            this.carrosDataGridView.Name = "carrosDataGridView";
            this.carrosDataGridView.Size = new System.Drawing.Size(143, 220);
            this.carrosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // jogosBindingSource
            // 
            this.jogosBindingSource.DataMember = "Jogos";
            this.jogosBindingSource.DataSource = this._semana18_08bddDataSet;
            // 
            // jogosTableAdapter
            // 
            this.jogosTableAdapter.ClearBeforeFill = true;
            // 
            // jogosDataGridView
            // 
            this.jogosDataGridView.AutoGenerateColumns = false;
            this.jogosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jogosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.jogosDataGridView.DataSource = this.jogosBindingSource;
            this.jogosDataGridView.Location = new System.Drawing.Point(161, 46);
            this.jogosDataGridView.Name = "jogosDataGridView";
            this.jogosDataGridView.Size = new System.Drawing.Size(240, 220);
            this.jogosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_jogo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_jogo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lançamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lançamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nomesBindingSource
            // 
            this.nomesBindingSource.DataMember = "Nomes";
            this.nomesBindingSource.DataSource = this._semana18_08bddDataSet;
            // 
            // nomesTableAdapter
            // 
            this.nomesTableAdapter.ClearBeforeFill = true;
            // 
            // nomesDataGridView
            // 
            this.nomesDataGridView.AutoGenerateColumns = false;
            this.nomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nomesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.nomesDataGridView.DataSource = this.nomesBindingSource;
            this.nomesDataGridView.Location = new System.Drawing.Point(407, 46);
            this.nomesDataGridView.Name = "nomesDataGridView";
            this.nomesDataGridView.Size = new System.Drawing.Size(144, 220);
            this.nomesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.nomesDataGridView);
            this.Controls.Add(this.jogosDataGridView);
            this.Controls.Add(this.carrosDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._semana18_08bddDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _semana18_08bddDataSet _semana18_08bddDataSet;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private _semana18_08bddDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter;
        private _semana18_08bddDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private _semana18_08bddDataSetTableAdapters.JogosTableAdapter jogosTableAdapter;
        private System.Windows.Forms.BindingSource jogosBindingSource;
        private _semana18_08bddDataSetTableAdapters.NomesTableAdapter nomesTableAdapter;
        private System.Windows.Forms.DataGridView jogosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource nomesBindingSource;
        private System.Windows.Forms.DataGridView nomesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

