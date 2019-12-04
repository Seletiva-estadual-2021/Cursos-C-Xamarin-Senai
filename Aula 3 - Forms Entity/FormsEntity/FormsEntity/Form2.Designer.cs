namespace FormsEntity
{
    partial class Form2
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
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label idadeLabel1;
            System.Windows.Forms.Label nomeLabel1;
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.idadeNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            fotoLabel = new System.Windows.Forms.Label();
            idadeLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idadeNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(FormsEntity.pessoa);
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(156, 62);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(41, 20);
            fotoLabel.TabIndex = 6;
            fotoLabel.Text = "foto:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pessoaBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(215, 62);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(120, 50);
            this.fotoPictureBox.TabIndex = 7;
            this.fotoPictureBox.TabStop = false;
            // 
            // idadeLabel1
            // 
            idadeLabel1.AutoSize = true;
            idadeLabel1.Location = new System.Drawing.Point(156, 118);
            idadeLabel1.Name = "idadeLabel1";
            idadeLabel1.Size = new System.Drawing.Size(52, 20);
            idadeLabel1.TabIndex = 8;
            idadeLabel1.Text = "idade:";
            // 
            // idadeNumericUpDown1
            // 
            this.idadeNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource, "idade", true));
            this.idadeNumericUpDown1.Location = new System.Drawing.Point(215, 118);
            this.idadeNumericUpDown1.Name = "idadeNumericUpDown1";
            this.idadeNumericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.idadeNumericUpDown1.TabIndex = 9;
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(156, 153);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(53, 20);
            nomeLabel1.TabIndex = 10;
            nomeLabel1.Text = "nome:";
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "nome", true));
            this.nomeTextBox1.Location = new System.Drawing.Point(215, 150);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(120, 26);
            this.nomeTextBox1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(idadeLabel1);
            this.Controls.Add(this.idadeNumericUpDown1);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(this.nomeTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idadeNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.NumericUpDown idadeNumericUpDown1;
        private System.Windows.Forms.TextBox nomeTextBox1;
    }
}