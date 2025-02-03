namespace MovieLibrary.cs
{
    partial class frmMovieLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieLibrary));
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddDirectors = new System.Windows.Forms.TextBox();
            this.txtAddWriters = new System.Windows.Forms.TextBox();
            this.txtAddStars = new System.Windows.Forms.TextBox();
            this.txtAddRelease = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.numAddRating = new System.Windows.Forms.NumericUpDown();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCsvMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPdfMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDirectors = new System.Windows.Forms.TextBox();
            this.txtWriters = new System.Windows.Forms.TextBox();
            this.txtStars = new System.Windows.Forms.TextBox();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAddRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTitle.Location = new System.Drawing.Point(80, 125);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(110, 30);
            this.txtAddTitle.TabIndex = 0;
            // 
            // txtAddDirectors
            // 
            this.txtAddDirectors.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddDirectors.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDirectors.Location = new System.Drawing.Point(196, 125);
            this.txtAddDirectors.Name = "txtAddDirectors";
            this.txtAddDirectors.Size = new System.Drawing.Size(110, 30);
            this.txtAddDirectors.TabIndex = 1;
            // 
            // txtAddWriters
            // 
            this.txtAddWriters.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddWriters.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWriters.Location = new System.Drawing.Point(312, 125);
            this.txtAddWriters.Name = "txtAddWriters";
            this.txtAddWriters.Size = new System.Drawing.Size(110, 30);
            this.txtAddWriters.TabIndex = 2;
            // 
            // txtAddStars
            // 
            this.txtAddStars.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddStars.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStars.Location = new System.Drawing.Point(428, 125);
            this.txtAddStars.Name = "txtAddStars";
            this.txtAddStars.Size = new System.Drawing.Size(110, 30);
            this.txtAddStars.TabIndex = 3;
            // 
            // txtAddRelease
            // 
            this.txtAddRelease.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddRelease.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRelease.Location = new System.Drawing.Point(544, 125);
            this.txtAddRelease.Name = "txtAddRelease";
            this.txtAddRelease.Size = new System.Drawing.Size(110, 30);
            this.txtAddRelease.TabIndex = 4;
            // 
            // cbGenre
            // 
            this.cbGenre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(660, 124);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(110, 31);
            this.cbGenre.TabIndex = 5;
            // 
            // numAddRating
            // 
            this.numAddRating.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numAddRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddRating.Location = new System.Drawing.Point(777, 125);
            this.numAddRating.Name = "numAddRating";
            this.numAddRating.Size = new System.Drawing.Size(103, 30);
            this.numAddRating.TabIndex = 6;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(80, 505);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(87, 34);
            this.btnAddMovie.TabIndex = 7;
            this.btnAddMovie.Text = "Add ";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(173, 505);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(87, 34);
            this.btnUpdateMovie.TabIndex = 8;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(266, 505);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(87, 34);
            this.btnDeleteMovie.TabIndex = 9;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(80, 162);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(800, 337);
            this.dgvMovies.TabIndex = 10;
            this.dgvMovies.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.exportMenuItem,
            this.settingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.updateMenuItem,
            this.deleteMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editMenuItem.Text = "Edit";
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateMenuItem.Text = "Update";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCsvMenuItem,
            this.exportToExcelMenuItem,
            this.exportToPdfMenuItem});
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportMenuItem.Text = "Export";
            // 
            // exportToCsvMenuItem
            // 
            this.exportToCsvMenuItem.Name = "exportToCsvMenuItem";
            this.exportToCsvMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToCsvMenuItem.Text = "Export to csv";
            this.exportToCsvMenuItem.Click += new System.EventHandler(this.exportToCsvMenuItem_Click);
            // 
            // exportToExcelMenuItem
            // 
            this.exportToExcelMenuItem.Name = "exportToExcelMenuItem";
            this.exportToExcelMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToExcelMenuItem.Text = "Export to excel";
            this.exportToExcelMenuItem.Click += new System.EventHandler(this.exportToExcelMenuItem_Click);
            // 
            // exportToPdfMenuItem
            // 
            this.exportToPdfMenuItem.Name = "exportToPdfMenuItem";
            this.exportToPdfMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToPdfMenuItem.Text = "Export to pdf";
            this.exportToPdfMenuItem.Click += new System.EventHandler(this.exportToPdfMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnectionMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsMenuItem.Text = "Settings";
            // 
            // testConnectionMenuItem
            // 
            this.testConnectionMenuItem.Name = "testConnectionMenuItem";
            this.testConnectionMenuItem.Size = new System.Drawing.Size(224, 26);
            this.testConnectionMenuItem.Text = "Test Connection";
            this.testConnectionMenuItem.Click += new System.EventHandler(this.testConnectionMenuItem_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(80, 89);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(110, 30);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            // 
            // txtDirectors
            // 
            this.txtDirectors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDirectors.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectors.Location = new System.Drawing.Point(196, 89);
            this.txtDirectors.Name = "txtDirectors";
            this.txtDirectors.ReadOnly = true;
            this.txtDirectors.Size = new System.Drawing.Size(110, 30);
            this.txtDirectors.TabIndex = 13;
            this.txtDirectors.TabStop = false;
            this.txtDirectors.Text = "Directors";
            // 
            // txtWriters
            // 
            this.txtWriters.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWriters.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriters.Location = new System.Drawing.Point(312, 89);
            this.txtWriters.Name = "txtWriters";
            this.txtWriters.ReadOnly = true;
            this.txtWriters.Size = new System.Drawing.Size(110, 30);
            this.txtWriters.TabIndex = 14;
            this.txtWriters.TabStop = false;
            this.txtWriters.Text = "Writers";
            // 
            // txtStars
            // 
            this.txtStars.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtStars.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStars.Location = new System.Drawing.Point(428, 89);
            this.txtStars.Name = "txtStars";
            this.txtStars.ReadOnly = true;
            this.txtStars.Size = new System.Drawing.Size(110, 30);
            this.txtStars.TabIndex = 15;
            this.txtStars.TabStop = false;
            this.txtStars.Text = "Stars";
            // 
            // txtRelease
            // 
            this.txtRelease.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRelease.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelease.Location = new System.Drawing.Point(544, 89);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.ReadOnly = true;
            this.txtRelease.Size = new System.Drawing.Size(110, 30);
            this.txtRelease.TabIndex = 16;
            this.txtRelease.TabStop = false;
            this.txtRelease.Text = "Release";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(660, 89);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(110, 30);
            this.txtGenre.TabIndex = 17;
            this.txtGenre.TabStop = false;
            this.txtGenre.Text = "Genre";
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRating.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(777, 89);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(103, 30);
            this.txtRating.TabIndex = 18;
            this.txtRating.TabStop = false;
            this.txtRating.Text = "Rating";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(793, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(687, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 10;
            // 
            // frmMovieLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(998, 632);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.txtStars);
            this.Controls.Add(this.txtWriters);
            this.Controls.Add(this.txtDirectors);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.numAddRating);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.txtAddRelease);
            this.Controls.Add(this.txtAddStars);
            this.Controls.Add(this.txtAddWriters);
            this.Controls.Add(this.txtAddDirectors);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovieLibrary";
            this.Text = "Movie Library";
            ((System.ComponentModel.ISupportInitialize)(this.numAddRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.TextBox txtAddDirectors;
        private System.Windows.Forms.TextBox txtAddWriters;
        private System.Windows.Forms.TextBox txtAddStars;
        private System.Windows.Forms.TextBox txtAddRelease;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.NumericUpDown numAddRating;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCsvMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPdfMenuItem;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDirectors;
        private System.Windows.Forms.TextBox txtWriters;
        private System.Windows.Forms.TextBox txtStars;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

