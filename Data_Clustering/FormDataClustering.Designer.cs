namespace Data_Clustering
{
    partial class FormDataClustering
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridViewDataCluster = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCoba = new System.Windows.Forms.Button();
            this.SepalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCluster)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepalToolStripMenuItem,
            this.petalToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // sepalToolStripMenuItem
            // 
            this.sepalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.sepalToolStripMenuItem.Name = "sepalToolStripMenuItem";
            this.sepalToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.sepalToolStripMenuItem.Text = "Sepal";
            // 
            // lengthToolStripMenuItem
            // 
            this.lengthToolStripMenuItem.Name = "lengthToolStripMenuItem";
            this.lengthToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.lengthToolStripMenuItem.Text = "Length";
            this.lengthToolStripMenuItem.Click += new System.EventHandler(this.lengthToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.widthToolStripMenuItem.Text = "Width";
            this.widthToolStripMenuItem.Click += new System.EventHandler(this.widthToolStripMenuItem_Click);
            // 
            // petalToolStripMenuItem
            // 
            this.petalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthToolStripMenuItem1,
            this.widthToolStripMenuItem1});
            this.petalToolStripMenuItem.Name = "petalToolStripMenuItem";
            this.petalToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.petalToolStripMenuItem.Text = "Petal";
            // 
            // lengthToolStripMenuItem1
            // 
            this.lengthToolStripMenuItem1.Name = "lengthToolStripMenuItem1";
            this.lengthToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.lengthToolStripMenuItem1.Text = "Length";
            this.lengthToolStripMenuItem1.Click += new System.EventHandler(this.lengthToolStripMenuItem1_Click);
            // 
            // widthToolStripMenuItem1
            // 
            this.widthToolStripMenuItem1.Name = "widthToolStripMenuItem1";
            this.widthToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.widthToolStripMenuItem1.Text = "Width";
            this.widthToolStripMenuItem1.Click += new System.EventHandler(this.widthToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 16;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 321);
            this.listBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(776, 180);
            this.listBoxDisplay.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(713, 507);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridViewDataCluster
            // 
            this.dataGridViewDataCluster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataCluster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SepalLength,
            this.SepalWidth,
            this.PetalLength,
            this.PetalWidth,
            this.Species});
            this.dataGridViewDataCluster.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewDataCluster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDataCluster.Name = "dataGridViewDataCluster";
            this.dataGridViewDataCluster.RowHeadersWidth = 51;
            this.dataGridViewDataCluster.RowTemplate.Height = 24;
            this.dataGridViewDataCluster.Size = new System.Drawing.Size(776, 284);
            this.dataGridViewDataCluster.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCoba
            // 
            this.buttonCoba.Location = new System.Drawing.Point(365, 508);
            this.buttonCoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCoba.Name = "buttonCoba";
            this.buttonCoba.Size = new System.Drawing.Size(75, 23);
            this.buttonCoba.TabIndex = 5;
            this.buttonCoba.Text = "Coba";
            this.buttonCoba.UseVisualStyleBackColor = true;
            this.buttonCoba.Click += new System.EventHandler(this.buttonCoba_Click_1);
            // 
            // SepalLength
            // 
            this.SepalLength.HeaderText = "Sepal Length";
            this.SepalLength.MinimumWidth = 6;
            this.SepalLength.Name = "SepalLength";
            this.SepalLength.Width = 125;
            // 
            // SepalWidth
            // 
            this.SepalWidth.HeaderText = "Sepal Width";
            this.SepalWidth.MinimumWidth = 6;
            this.SepalWidth.Name = "SepalWidth";
            this.SepalWidth.Width = 125;
            // 
            // PetalLength
            // 
            this.PetalLength.HeaderText = "Petal Length";
            this.PetalLength.MinimumWidth = 6;
            this.PetalLength.Name = "PetalLength";
            this.PetalLength.Width = 125;
            // 
            // PetalWidth
            // 
            this.PetalWidth.HeaderText = "Petal Width";
            this.PetalWidth.MinimumWidth = 6;
            this.PetalWidth.Name = "PetalWidth";
            this.PetalWidth.Width = 125;
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.MinimumWidth = 6;
            this.Species.Name = "Species";
            this.Species.Width = 125;
            // 
            // FormDataClustering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.buttonCoba);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDataCluster);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDataClustering";
            this.Text = "Data Clustering";
            this.Load += new System.EventHandler(this.FormDataClustering_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataCluster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridViewDataCluster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
    }
}

