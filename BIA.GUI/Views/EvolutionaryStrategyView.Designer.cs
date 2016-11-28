namespace BIA.GUI.Views
{
    partial class EvolutionaryStrategyView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maxGenerationsBox = new System.Windows.Forms.TextBox();
            this.mutantsBox = new System.Windows.Forms.TextBox();
            this.stdDeviationBox = new System.Windows.Forms.TextBox();
            this.esVersionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.maxGenerationsBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mutantsBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.stdDeviationBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.esVersionBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.VersionLbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.updateBtn, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // maxGenerationsBox
            // 
            this.maxGenerationsBox.Location = new System.Drawing.Point(145, 3);
            this.maxGenerationsBox.Name = "maxGenerationsBox";
            this.maxGenerationsBox.Size = new System.Drawing.Size(136, 20);
            this.maxGenerationsBox.TabIndex = 0;
            // 
            // mutantsBox
            // 
            this.mutantsBox.Location = new System.Drawing.Point(145, 55);
            this.mutantsBox.Name = "mutantsBox";
            this.mutantsBox.Size = new System.Drawing.Size(136, 20);
            this.mutantsBox.TabIndex = 1;
            // 
            // stdDeviationBox
            // 
            this.stdDeviationBox.Location = new System.Drawing.Point(145, 107);
            this.stdDeviationBox.Name = "stdDeviationBox";
            this.stdDeviationBox.Size = new System.Drawing.Size(136, 20);
            this.stdDeviationBox.TabIndex = 2;
            // 
            // esVersionBox
            // 
            this.esVersionBox.Location = new System.Drawing.Point(145, 159);
            this.esVersionBox.Name = "esVersionBox";
            this.esVersionBox.Size = new System.Drawing.Size(136, 20);
            this.esVersionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max generations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count Mutants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "StdDeviation";
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Location = new System.Drawing.Point(3, 156);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(128, 13);
            this.VersionLbl.TabIndex = 7;
            this.VersionLbl.Text = "ES(X+Y) = 0 | ES(X,Y) = 1";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(145, 211);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 28);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // EvolutionaryStrategyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EvolutionaryStrategyView";
            this.Text = "EvolutionaryStrategyView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox maxGenerationsBox;
        private System.Windows.Forms.TextBox mutantsBox;
        private System.Windows.Forms.TextBox stdDeviationBox;
        private System.Windows.Forms.TextBox esVersionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.Button updateBtn;
    }
}