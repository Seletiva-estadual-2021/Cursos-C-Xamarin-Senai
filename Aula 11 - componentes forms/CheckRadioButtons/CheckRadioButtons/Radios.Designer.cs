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
            this.grpCores = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpSexo.SuspendLayout();
            this.grpCores.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radioButton2);
            this.grpSexo.Controls.Add(this.radioButton1);
            this.grpSexo.Location = new System.Drawing.Point(100, 91);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(249, 136);
            this.grpSexo.TabIndex = 0;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "sexo";
            // 
            // grpCores
            // 
            this.grpCores.Controls.Add(this.radioButton3);
            this.grpCores.Location = new System.Drawing.Point(408, 91);
            this.grpCores.Name = "grpCores";
            this.grpCores.Size = new System.Drawing.Size(254, 136);
            this.grpCores.TabIndex = 1;
            this.grpCores.TabStop = false;
            this.grpCores.Text = "cores";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(39, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Radios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCores);
            this.Controls.Add(this.grpSexo);
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpCores;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}