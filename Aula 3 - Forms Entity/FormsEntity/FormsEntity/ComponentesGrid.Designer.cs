namespace FormsEntity
{
    partial class ComponentesGrid
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.AutoScroll = true;
            this.tblLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.Size = new System.Drawing.Size(779, 295);
            this.tblLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblLayout);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 295);
            this.panel1.TabIndex = 1;
            // 
            // ComponentesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.panel1);
            this.Name = "ComponentesGrid";
            this.Text = "ComponentesGrid";
            this.Load += new System.EventHandler(this.ComponentesGrid_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Panel panel1;
    }
}