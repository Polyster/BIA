namespace BIA.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.windowLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.functionLabel = new System.Windows.Forms.Label();
            this.functionsBox = new System.Windows.Forms.ComboBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yMaxLbl = new System.Windows.Forms.Label();
            this.yMinLbl = new System.Windows.Forms.Label();
            this.xMaxLbl = new System.Windows.Forms.Label();
            this.xMinBox = new System.Windows.Forms.TextBox();
            this.xMaxBox = new System.Windows.Forms.TextBox();
            this.xMinLbl = new System.Windows.Forms.Label();
            this.yMaxBox = new System.Windows.Forms.TextBox();
            this.yMinBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sizeofPopulationLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.dshValuesChecked = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.algorithmBox = new System.Windows.Forms.ComboBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.populationGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilPanel = new ILNumerics.Drawing.ILPanel();
            this.individualsTxtBox = new System.Windows.Forms.TextBox();
            this.windowLayoutPanel.SuspendLayout();
            this.leftLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.populationGridView ) ).BeginInit();
            this.SuspendLayout();
            // 
            // windowLayoutPanel
            // 
            this.windowLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.windowLayoutPanel.ColumnCount = 2;
            this.windowLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 333F ) );
            this.windowLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.windowLayoutPanel.Controls.Add( this.leftLayoutPanel, 0, 0 );
            this.windowLayoutPanel.Controls.Add( this.ilPanel, 1, 0 );
            this.windowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
            this.windowLayoutPanel.Margin = new System.Windows.Forms.Padding( 5 );
            this.windowLayoutPanel.Name = "windowLayoutPanel";
            this.windowLayoutPanel.Padding = new System.Windows.Forms.Padding( 7, 6, 7, 6 );
            this.windowLayoutPanel.RowCount = 2;
            this.windowLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.windowLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            this.windowLayoutPanel.Size = new System.Drawing.Size( 1201, 594 );
            this.windowLayoutPanel.TabIndex = 1;
            // 
            // leftLayoutPanel
            // 
            this.leftLayoutPanel.ColumnCount = 1;
            this.leftLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.leftLayoutPanel.Controls.Add( this.functionLabel, 0, 0 );
            this.leftLayoutPanel.Controls.Add( this.functionsBox, 0, 1 );
            this.leftLayoutPanel.Controls.Add( this.drawBtn, 0, 3 );
            this.leftLayoutPanel.Controls.Add( this.tableLayoutPanel1, 0, 2 );
            this.leftLayoutPanel.Controls.Add( this.tableLayoutPanel2, 0, 4 );
            this.leftLayoutPanel.Controls.Add( this.tableLayoutPanel3, 0, 9 );
            this.leftLayoutPanel.Controls.Add( this.populationGridView, 0, 10 );
            this.leftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayoutPanel.Location = new System.Drawing.Point( 11, 9 );
            this.leftLayoutPanel.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.leftLayoutPanel.Name = "leftLayoutPanel";
            this.leftLayoutPanel.RowCount = 10;
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.leftLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            this.leftLayoutPanel.Size = new System.Drawing.Size( 327, 555 );
            this.leftLayoutPanel.TabIndex = 1;
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point( 3, 0 );
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size( 62, 17 );
            this.functionLabel.TabIndex = 101;
            this.functionLabel.Text = "Function";
            // 
            // functionsBox
            // 
            this.functionsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionsBox.FormattingEnabled = true;
            this.functionsBox.Location = new System.Drawing.Point( 3, 19 );
            this.functionsBox.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.functionsBox.Name = "functionsBox";
            this.functionsBox.Size = new System.Drawing.Size( 322, 24 );
            this.functionsBox.TabIndex = 0;
            this.functionsBox.SelectedIndexChanged += new System.EventHandler( this.functionsBox_SelectedIndexChanged );
            // 
            // drawBtn
            // 
            this.drawBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.drawBtn.Location = new System.Drawing.Point( 224, 125 );
            this.drawBtn.Margin = new System.Windows.Forms.Padding( 4 );
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size( 100, 33 );
            this.drawBtn.TabIndex = 5;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler( this.drawBtn_Click );
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 16.25F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.33333F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 17.91667F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 32.08333F ) );
            this.tableLayoutPanel1.Controls.Add( this.yMaxLbl, 2, 1 );
            this.tableLayoutPanel1.Controls.Add( this.yMinLbl, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.xMaxLbl, 2, 0 );
            this.tableLayoutPanel1.Controls.Add( this.xMinBox, 1, 0 );
            this.tableLayoutPanel1.Controls.Add( this.xMaxBox, 3, 0 );
            this.tableLayoutPanel1.Controls.Add( this.xMinLbl, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.yMaxBox, 3, 1 );
            this.tableLayoutPanel1.Controls.Add( this.yMinBox, 1, 1 );
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 4, 49 );
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding( 4 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 320, 68 );
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // yMaxLbl
            // 
            this.yMaxLbl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.yMaxLbl.AutoSize = true;
            this.yMaxLbl.Location = new System.Drawing.Point( 163, 30 );
            this.yMaxLbl.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.yMaxLbl.Name = "yMaxLbl";
            this.yMaxLbl.Size = new System.Drawing.Size( 46, 38 );
            this.yMaxLbl.TabIndex = 105;
            this.yMaxLbl.Text = "Ymax:";
            this.yMaxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yMinLbl
            // 
            this.yMinLbl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.yMinLbl.AutoSize = true;
            this.yMinLbl.Location = new System.Drawing.Point( 4, 30 );
            this.yMinLbl.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.yMinLbl.Name = "yMinLbl";
            this.yMinLbl.Size = new System.Drawing.Size( 43, 38 );
            this.yMinLbl.TabIndex = 104;
            this.yMinLbl.Text = "Ymin:";
            this.yMinLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xMaxLbl
            // 
            this.xMaxLbl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.xMaxLbl.AutoSize = true;
            this.xMaxLbl.Location = new System.Drawing.Point( 163, 0 );
            this.xMaxLbl.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.xMaxLbl.Name = "xMaxLbl";
            this.xMaxLbl.Size = new System.Drawing.Size( 46, 30 );
            this.xMaxLbl.TabIndex = 103;
            this.xMaxLbl.Text = "Xmax:";
            this.xMaxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xMinBox
            // 
            this.xMinBox.Location = new System.Drawing.Point( 56, 4 );
            this.xMinBox.Margin = new System.Windows.Forms.Padding( 4 );
            this.xMinBox.Name = "xMinBox";
            this.xMinBox.Size = new System.Drawing.Size( 97, 22 );
            this.xMinBox.TabIndex = 1;
            // 
            // xMaxBox
            // 
            this.xMaxBox.Location = new System.Drawing.Point( 220, 4 );
            this.xMaxBox.Margin = new System.Windows.Forms.Padding( 4 );
            this.xMaxBox.Name = "xMaxBox";
            this.xMaxBox.Size = new System.Drawing.Size( 95, 22 );
            this.xMaxBox.TabIndex = 2;
            // 
            // xMinLbl
            // 
            this.xMinLbl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.xMinLbl.AutoSize = true;
            this.xMinLbl.Location = new System.Drawing.Point( 4, 0 );
            this.xMinLbl.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.xMinLbl.Name = "xMinLbl";
            this.xMinLbl.Size = new System.Drawing.Size( 43, 30 );
            this.xMinLbl.TabIndex = 102;
            this.xMinLbl.Text = "Xmin:";
            this.xMinLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yMaxBox
            // 
            this.yMaxBox.Location = new System.Drawing.Point( 220, 34 );
            this.yMaxBox.Margin = new System.Windows.Forms.Padding( 4 );
            this.yMaxBox.Name = "yMaxBox";
            this.yMaxBox.Size = new System.Drawing.Size( 95, 22 );
            this.yMaxBox.TabIndex = 4;
            // 
            // yMinBox
            // 
            this.yMinBox.Location = new System.Drawing.Point( 56, 34 );
            this.yMinBox.Margin = new System.Windows.Forms.Padding( 4 );
            this.yMinBox.Name = "yMinBox";
            this.yMinBox.Size = new System.Drawing.Size( 97, 22 );
            this.yMinBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel2.Controls.Add( this.sizeofPopulationLbl, 0, 0 );
            this.tableLayoutPanel2.Controls.Add( this.generateBtn, 1, 1 );
            this.tableLayoutPanel2.Controls.Add( this.dshValuesChecked, 0, 1 );
            this.tableLayoutPanel2.Controls.Add( this.individualsTxtBox, 1, 0 );
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point( 4, 166 );
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding( 4 );
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            this.tableLayoutPanel2.Size = new System.Drawing.Size( 320, 69 );
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // sizeofPopulationLbl
            // 
            this.sizeofPopulationLbl.AutoSize = true;
            this.sizeofPopulationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeofPopulationLbl.Location = new System.Drawing.Point( 4, 0 );
            this.sizeofPopulationLbl.Margin = new System.Windows.Forms.Padding( 4, 0, 4, 0 );
            this.sizeofPopulationLbl.Name = "sizeofPopulationLbl";
            this.sizeofPopulationLbl.Size = new System.Drawing.Size( 152, 28 );
            this.sizeofPopulationLbl.TabIndex = 106;
            this.sizeofPopulationLbl.Text = "Size of population:";
            this.sizeofPopulationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.generateBtn.Location = new System.Drawing.Point( 216, 32 );
            this.generateBtn.Margin = new System.Windows.Forms.Padding( 4 );
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size( 100, 33 );
            this.generateBtn.TabIndex = 8;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler( this.generateBtn_Click );
            // 
            // dshValuesChecked
            // 
            this.dshValuesChecked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dshValuesChecked.Location = new System.Drawing.Point( 3, 30 );
            this.dshValuesChecked.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.dshValuesChecked.Name = "dshValuesChecked";
            this.dshValuesChecked.Size = new System.Drawing.Size( 154, 37 );
            this.dshValuesChecked.TabIndex = 7;
            this.dshValuesChecked.Text = "DSH values";
            this.dshValuesChecked.UseVisualStyleBackColor = true;
            this.dshValuesChecked.CheckedChanged += new System.EventHandler( this.dshValuesChecked_CheckedChanged );
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel3.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            this.tableLayoutPanel3.Controls.Add( this.algorithmBox, 0, 0 );
            this.tableLayoutPanel3.Controls.Add( this.stepButton, 0, 1 );
            this.tableLayoutPanel3.Controls.Add( this.playButton, 1, 1 );
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point( 4, 243 );
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding( 4 );
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel3.Size = new System.Drawing.Size( 320, 75 );
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // algorithmBox
            // 
            this.tableLayoutPanel3.SetColumnSpan( this.algorithmBox, 2 );
            this.algorithmBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmBox.FormattingEnabled = true;
            this.algorithmBox.Location = new System.Drawing.Point( 4, 4 );
            this.algorithmBox.Margin = new System.Windows.Forms.Padding( 4 );
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size( 312, 24 );
            this.algorithmBox.TabIndex = 9;
            this.algorithmBox.SelectedIndexChanged += new System.EventHandler( this.algorithmBox_SelectedIndexChanged );
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point( 4, 36 );
            this.stepButton.Margin = new System.Windows.Forms.Padding( 4 );
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size( 100, 33 );
            this.stepButton.TabIndex = 10;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler( this.stepButton_Click );
            // 
            // playButton
            // 
            this.playButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.playButton.Location = new System.Drawing.Point( 216, 36 );
            this.playButton.Margin = new System.Windows.Forms.Padding( 4 );
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size( 100, 33 );
            this.playButton.TabIndex = 11;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler( this.playButton_Click );
            // 
            // populationGridView
            // 
            this.populationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.populationGridView.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1} );
            this.populationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.populationGridView.Location = new System.Drawing.Point( 4, 326 );
            this.populationGridView.Margin = new System.Windows.Forms.Padding( 4 );
            this.populationGridView.Name = "populationGridView";
            this.populationGridView.Size = new System.Drawing.Size( 320, 229 );
            this.populationGridView.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // ilPanel
            // 
            this.ilPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ilPanel.Driver = ILNumerics.Drawing.RendererTypes.OpenGL;
            this.ilPanel.Editor = null;
            this.ilPanel.Location = new System.Drawing.Point( 345, 9 );
            this.ilPanel.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.ilPanel.Name = "ilPanel";
            this.ilPanel.Rectangle = ( (System.Drawing.RectangleF)( resources.GetObject( "ilPanel.Rectangle" ) ) );
            this.ilPanel.ShowUIControls = false;
            this.ilPanel.Size = new System.Drawing.Size( 845, 555 );
            this.ilPanel.TabIndex = 2;
            // 
            // individualsTxtBox
            // 
            this.individualsTxtBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.individualsTxtBox.Location = new System.Drawing.Point( 220, 3 );
            this.individualsTxtBox.Name = "individualsTxtBox";
            this.individualsTxtBox.Size = new System.Drawing.Size( 97, 22 );
            this.individualsTxtBox.TabIndex = 107;
            this.individualsTxtBox.Text = "20";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1201, 594 );
            this.Controls.Add( this.windowLayoutPanel );
            this.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIA";
            this.windowLayoutPanel.ResumeLayout( false );
            this.leftLayoutPanel.ResumeLayout( false );
            this.leftLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout( false );
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.populationGridView ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel windowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel leftLayoutPanel;
        private System.Windows.Forms.ComboBox functionsBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Button drawBtn;
        private ILNumerics.Drawing.ILPanel ilPanel;
        private System.Windows.Forms.TextBox xMaxBox;
        private System.Windows.Forms.TextBox yMaxBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox xMinBox;
        private System.Windows.Forms.TextBox yMinBox;
        private System.Windows.Forms.Label xMinLbl;
        private System.Windows.Forms.Label xMaxLbl;
        private System.Windows.Forms.Label yMaxLbl;
        private System.Windows.Forms.Label yMinLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label sizeofPopulationLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox algorithmBox;
        private System.Windows.Forms.DataGridView populationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.CheckBox dshValuesChecked;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox individualsTxtBox;
    }
}

