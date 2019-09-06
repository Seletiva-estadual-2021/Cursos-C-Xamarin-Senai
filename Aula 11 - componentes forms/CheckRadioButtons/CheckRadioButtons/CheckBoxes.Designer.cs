namespace CheckRadioButtons
{
    partial class CheckBoxes
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
            this.chkListCores = new System.Windows.Forms.CheckedListBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkListCores
            // 
            this.chkListCores.FormattingEnabled = true;
            this.chkListCores.Items.AddRange(new object[] {
            "amarelo",
            "verde",
            "vermelho",
            "azul"});
            this.chkListCores.Location = new System.Drawing.Point(323, 124);
            this.chkListCores.Name = "chkListCores";
            this.chkListCores.Size = new System.Drawing.Size(167, 130);
            this.chkListCores.TabIndex = 0;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(548, 159);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 47);
            this.btnConfirma.TabIndex = 1;
            this.btnConfirma.Text = "confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.chkListCores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListCores;
        private System.Windows.Forms.Button btnConfirma;
    }
}

