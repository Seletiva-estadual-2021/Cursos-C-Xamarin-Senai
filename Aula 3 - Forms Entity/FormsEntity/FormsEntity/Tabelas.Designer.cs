namespace FormsEntity
{
    partial class Tabelas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblPessoas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tblPessoas2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPessoas
            // 
            this.tblPessoas.AllowUserToAddRows = false;
            this.tblPessoas.AllowUserToDeleteRows = false;
            this.tblPessoas.AutoGenerateColumns = false;
            this.tblPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn});
            this.tblPessoas.DataSource = this.pessoaBindingSource1;
            this.tblPessoas.Location = new System.Drawing.Point(39, 12);
            this.tblPessoas.Name = "tblPessoas";
            this.tblPessoas.ReadOnly = true;
            this.tblPessoas.RowTemplate.Height = 28;
            this.tblPessoas.Size = new System.Drawing.Size(704, 119);
            this.tblPessoas.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataSource = typeof(FormsEntity.pessoa);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getPessoaSel);
            // 
            // tblPessoas2
            // 
            this.tblPessoas2.AllowUserToAddRows = false;
            this.tblPessoas2.AllowUserToDeleteRows = false;
            this.tblPessoas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPessoas2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.idade,
            this.foto});
            this.tblPessoas2.Location = new System.Drawing.Point(39, 155);
            this.tblPessoas2.Name = "tblPessoas2";
            this.tblPessoas2.ReadOnly = true;
            this.tblPessoas2.RowTemplate.Height = 28;
            this.tblPessoas2.Size = new System.Drawing.Size(704, 150);
            this.tblPessoas2.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // idade
            // 
            this.idade.HeaderText = "idade";
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.HeaderText = "foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(FormsEntity.pessoa);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "estudo grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.abreComponentesGrid);
            // 
            // Tabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tblPessoas2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblPessoas);
            this.Name = "Tabelas";
            this.Text = "Tabelas";
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.DataGridView tblPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tblPessoas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.Button button2;
    }
}