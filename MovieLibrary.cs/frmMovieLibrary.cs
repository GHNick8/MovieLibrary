using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

using OfficeOpenXml;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants; 
using iText.Kernel.Font;
using System.Drawing;

namespace MovieLibrary.cs
{
    public partial class frmMovieLibrary : Form
    {
        public frmMovieLibrary()
        {
            InitializeComponent();
            LoadMovies();
            StyleDataGridView(dgvMovies);
        }

        // Method to load user interface with database and array list with genres
        private void frmMovieLibrary_Load(object sender, EventArgs e)
        {
            InitializeGenres();
        }

        private void InitializeGenres()
        {
            List<string> genres = new List<string>
            {
                "Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary",
                "Drama", "Experimental", "Fantasy", "Film Noir", "Historical", "Historical Fiction",
                "Horror", "Musical", "Mystery", "Romance", "Science Fiction", "Thriller",
                "Western", "Other..."
            };
            cbGenre.DataSource = genres;
        }

        // Method to load data grid view with exception handling 
        private void LoadMovies()
        {
            try
            {
                dgvMovies.DataSource = MovieService.GetAllMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to load movies.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method if textboxes, combobox, numericupdown are empty and returns false if they are. 
        private bool ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        // Method validate if textboxes, combobox, numericupdown are empty
        // and returns true if they're not empty
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
                return ShowValidationError("Title is required.", txtAddTitle);

            if (cbGenre.SelectedIndex < 0)
                return ShowValidationError("Please select a genre.", cbGenre);

            if (!int.TryParse(txtAddRelease.Text, out int releaseYear) ||
                releaseYear < 1800 || releaseYear > DateTime.Now.Year)
                return ShowValidationError("Please enter a valid release year.", txtAddRelease);

            if (numAddRating.Value < 0 || numAddRating.Value > 10)
                return ShowValidationError("Rating must be between 0 and 10.", numAddRating);

            return true;
        }

        // Method to clear all textboxes
        private void ClearFields()
        {
            txtAddTitle.Clear();
            cbGenre.SelectedIndex = -1;
            txtAddDirectors.Clear();
            txtAddWriters.Clear();
            txtAddStars.Clear();
            txtAddRelease.Clear();
            numAddRating.Value = 0;
        }

        // Methods - buttons to add, update and delete movies
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                Movie movie = new Movie
                {
                    Title = txtAddTitle.Text,
                    Genre = cbGenre.SelectedItem.ToString(),
                    Director = txtAddDirectors.Text,
                    Writer = txtAddWriters.Text,
                    Stars = txtAddStars.Text,
                    ReleaseYear = int.Parse(txtAddRelease.Text),
                    Rating = (decimal)numAddRating.Value
                };

                MovieService.AddMovie(movie);

                MessageBox.Show("Movie added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to add movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                int id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value);

                Movie movie = new Movie
                {
                    Id = id,
                    Title = txtAddTitle.Text,
                    Genre = cbGenre.SelectedItem.ToString(),
                    Director = txtAddDirectors.Text,
                    Writer = txtAddWriters.Text,
                    Stars = txtAddStars.Text,
                    ReleaseYear = int.Parse(txtAddRelease.Text),
                    Rating = (decimal)numAddRating.Value
                };

                MovieService.UpdateMovie(movie);
                MessageBox.Show("Movie updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to update movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value);
                MovieService.DeleteMovie(id);
                MessageBox.Show("Movie deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to delete movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to show error log if the database connection fails 
        private void LogError(Exception ex)
        {
            string logFile = "error.log";
            File.AppendAllText(logFile, $"{DateTime.Now}:{ex.Message} {Environment.NewLine} {ex.StackTrace} {Environment.NewLine}");
        }

        // Methods - Menu items 
        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                Movie movie = new Movie
                {
                    Title = txtAddTitle.Text,
                    Genre = cbGenre.SelectedItem.ToString(),
                    Director = txtAddDirectors.Text,
                    Writer = txtAddWriters.Text,
                    Stars = txtAddStars.Text,
                    ReleaseYear = int.Parse(txtAddRelease.Text),
                    Rating = (decimal)numAddRating.Value
                };

                MovieService.AddMovie(movie);

                MessageBox.Show("Movie added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to add movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                int id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value);

                Movie movie = new Movie
                {
                    Id = id,
                    Title = txtAddTitle.Text,
                    Genre = cbGenre.SelectedItem.ToString(),
                    Director = txtAddDirectors.Text,
                    Writer = txtAddWriters.Text,
                    Stars = txtAddStars.Text,
                    ReleaseYear = int.Parse(txtAddRelease.Text),
                    Rating = (decimal)numAddRating.Value
                };

                MovieService.UpdateMovie(movie);
                MessageBox.Show("Movie updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to update movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value);
                MovieService.DeleteMovie(id);
                MessageBox.Show("Movie deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMovies();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Failed to delete movie.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methods to export to csv, excel, pdf files 
        private void ExportToCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sb.Append(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            sb.Append(row.Cells[i].Value?.ToString().Replace(",", " "));
                            if (i < dataGridView.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("CSV file saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportToCsvMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save as CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCsv(dgvMovies, saveFileDialog.FileName);
            }
        }

        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Exported Data");

                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                    }

                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    File.WriteAllBytes(filePath, package.GetAsByteArray());
                    MessageBox.Show("Excel file saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToExcelMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save as Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvMovies, saveFileDialog.FileName);
            }
        }

        private void ExportToPdf(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var pdfWriter = new PdfWriter(filePath))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    var document = new Document(pdfDocument);

                    // Add a title to the PDF
                    var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    document.Add(new Paragraph("Exported Data")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont)
                        .SetFontSize(14));

                    // Create a table with the same number of columns as the DataGridView
                    var table = new Table(dataGridView.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100)); // Make table span the full width

                    // Add column headers
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SetFont(boldFont)));
                    }

                    // Add rows from DataGridView
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                            }
                        }
                    }

                    // Add table to the document
                    document.Add(table);

                    document.Close();
                    MessageBox.Show("PDF file saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exportToPdfMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save as PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(dgvMovies, saveFileDialog.FileName);
            }
        }

        // Method to test database connection
        private void testConnectionMenuItem_Click(object sender, EventArgs e)
        {
            // Exception handling to determine database connection 
            try
            {
                if (MovieService.TestDatabaseConnection())
                    MessageBox.Show("Database connection successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Database connection failed.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error testing database connection.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customized datagridview method 
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            dgv.EnableHeadersVisualStyles = false; 

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
         
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false; 

            // Auto-size columns to fit content
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Selects full row to update or delete movie
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}