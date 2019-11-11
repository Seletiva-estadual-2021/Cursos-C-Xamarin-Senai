namespace CheckRadioButtons
{
    partial class Radios
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
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.grpCores = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSexo.SuspendLayout();
            this.grpCores.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdFeminino);
            this.grpSexo.Controls.Add(this.rdMasculino);
            this.grpSexo.Location = new System.Drawing.Point(67, 59);
            this.grpSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSexo.Size = new System.Drawing.Size(166, 88);
            this.grpSexo.TabIndex = 0;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdFeminino
            // 
            this.rdFeminino.AutoSize = true;
            this.rdFeminino.Location = new System.Drawing.Point(25, 59);
            this.rdFeminino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdFeminino.TabIndex = 1;
            this.rdFeminino.TabStop = true;
            this.rdFeminino.Text = "Feminino";
            this.rdFeminino.UseVisualStyleBackColor = true;
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(25, 27);
            this.rdMasculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCores
            // 
            this.grpCores.Controls.Add(this.radioButton3);
            this.grpCores.Location = new System.Drawing.Point(272, 59);
            this.grpCores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCores.Name = "grpCores";
            this.grpCores.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCores.Size = new System.Drawing.Size(169, 88);
            this.grpCores.TabIndex = 1;
            this.grpCores.TabStop = false;
            this.grpCores.Text = "cores";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 31);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Testar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Radios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpCores);
            this.Controls.Add(this.grpSexo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Radios";
            this.Text = "Radios";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpCores.ResumeLayout(false);
            this.grpCores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdFeminino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.GroupBox grpCores;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
    }
}