using CRANameGeneratorLib.Abstractions;
using CRANameGeneratorLib.DataAccessImplementations;
using CRANameGeneratorLib.Models;
using CRANameGeneratorUI.Properties;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRANameGeneratorUI
{
    /// <summary>
    /// Principam form of the application.
    /// </summary>
    public partial class FmHome : Form
    {
        private readonly IDataAccess _dataAccessor;
        private readonly ILogger<FmHome> _logger;
        private readonly INameGenerable _nameGenerator;
        private readonly IConfiguration _configuration;

        private readonly string COL_TYPE = "Type";
        private readonly string COL_CLIENT_NAME = "Nom du client";
        private readonly string COL_PROJECT_NAME = "Nom du projet";
        private readonly string COL_BUSINESS_CODE = "Code affaire";
        private readonly string COL_COPY = "Nom du fichier";
        private readonly string COL_DEL = "Supprimer";        

        /// <summary>
        /// Constructor.
        /// </summary>
        public FmHome(IDataAccess dataAccess, ILogger<FmHome> logger, INameGenerable nameGenerator, IConfiguration configuration)
        {
            _dataAccessor = dataAccess;
            _logger = logger;
            _nameGenerator = nameGenerator;
            _configuration = configuration;
        }

        /// <summary>
        /// Initialise the frame.
        /// </summary>
        public void Init()
        {
            _logger.LogInformation("App initialization");

            try
            {
                InitializeComponent();
                RefreshBusinessGrid(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when initializing the main form");
            }
        }

        /// <summary>
        /// Event triggered when add is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBusinessAdd_Click(object sender, EventArgs e)
        {            
            if (CheckAddBusinessForm())
            {
                Business newBusiness = new Business();
                
                newBusiness.BusinessCode = textBoxBusinessCode.Text;
                newBusiness.ClientName = textBoxBusinessClientName.Text;
                newBusiness.ProjectName = textBoxBusinessProjectName.Text;
                newBusiness.Type = comboBoxBusinessType.Text;

                _dataAccessor.Add(newBusiness);
                ResetBusinessForm();
                RefreshBusinessGrid();
            }
        }

        /// <summary>
        /// Check if all required fields are filled.
        /// </summary>
        /// <returns>True if it is ok.</returns>
        private bool CheckAddBusinessForm()
        {
            if(textBoxBusinessClientName.Text != "" && textBoxBusinessCode.Text != "" && textBoxBusinessProjectName.Text != "" && comboBoxBusinessType.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Reset the form.
        /// </summary>
        private void ResetBusinessForm()
        {
            textBoxBusinessClientName.Text = "";
            textBoxBusinessCode.Text = "";
            textBoxBusinessProjectName.Text = "";
        }

        /// <summary>
        /// Update the business data grid view.
        /// </summary>
        /// <param name="pAddButton">Say if we add the column with the buttons.</param>
        private void RefreshBusinessGrid(bool pAddButton = false)
        {
            dataGridViewBusiness.DataSource = GetBusinessTable();

            if (pAddButton)
            {
                DataGridViewButtonColumn btnCopy = new DataGridViewButtonColumn();
                btnCopy.HeaderText = COL_COPY;
                btnCopy.Name = COL_COPY;
                btnCopy.UseColumnTextForButtonValue = true;                

                dataGridViewBusiness.Columns.Add(btnCopy);

                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = COL_DEL;
                btnDel.Name = COL_DEL;
                btnDel.UseColumnTextForButtonValue = true;

                dataGridViewBusiness.Columns.Add(btnDel);
            }

        }

        /// <summary>
        /// Call when user click on a cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clique sur bouton copier
            if(e.ColumnIndex == dataGridViewBusiness.Columns[COL_COPY].Index)
            {
                Business b = GetBusinessFromDataLine(e.RowIndex);

                Clipboard.SetText(_nameGenerator.GenerateName(b, _configuration.GetValue<string>("TriGram")));
                MessageBox.Show(_nameGenerator.GenerateName(b, _configuration.GetValue<string>("TriGram")));
            }

            // Si clique sur bouton supprimer
            if (e.ColumnIndex == dataGridViewBusiness.Columns[COL_DEL].Index)
            {
                MessageBox.Show("Normalement on supprime");
                Business b = GetBusinessFromDataLine(e.RowIndex);     
                
                if(_dataAccessor.Delete(b))
                {
                    RefreshBusinessGrid();
                }
            }
        }

        /// <summary>
        /// Get the Business stored in a row of the dataGridView
        /// </summary>
        /// <param name="index">Index of the line</param>
        /// <returns>The Business stored at the line in the dataGridView.</returns>
        private Business GetBusinessFromDataLine(int index)
        {
            Business b = new Business();
            b.Type = dataGridViewBusiness.Rows[index].Cells[COL_TYPE].Value.ToString();
            b.ClientName = dataGridViewBusiness.Rows[index].Cells[COL_CLIENT_NAME].Value.ToString();
            b.ProjectName = dataGridViewBusiness.Rows[index].Cells[COL_PROJECT_NAME].Value.ToString();
            b.BusinessCode = dataGridViewBusiness.Rows[index].Cells[COL_BUSINESS_CODE].Value.ToString();

            return b;
        }

        /// <summary>
        /// Call to draw icon on the delete button and copy button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBusiness_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Dessin de l'icone copier
            if(e.ColumnIndex >= 0 && dataGridViewBusiness.Columns[e.ColumnIndex].Name == COL_COPY && e.RowIndex >=0)
            {
                PaintCell(e, Resources.imgCopy);
            }

            // Dessin de l'icone supprimer
            if (e.ColumnIndex >= 0 && dataGridViewBusiness.Columns[e.ColumnIndex].Name == COL_DEL && e.RowIndex >= 0)
            {
                PaintCell(e, Resources.imgDelete);
            }
        }

        /// <summary>
        /// Paint the cell with the bitmap.
        /// </summary>
        /// <param name="e">Cell to paint.</param>
        /// <param name="img">Image to paint on the cell.</param>
        private void PaintCell(DataGridViewCellPaintingEventArgs e, Bitmap img)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            e.Graphics.DrawImage(
                img,
                ((e.CellBounds.Width / 2) - (img.Width / 2)) + e.CellBounds.X,
                ((e.CellBounds.Height / 2) - (img.Height / 2)) + e.CellBounds.Y
                );
            e.Handled = true;
        }

        /// <summary>
        /// Get data table fill with the businesses.
        /// </summary>
        /// <returns>A data table.</returns>
        private DataTable GetBusinessTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(COL_TYPE);
            dt.Columns.Add(COL_CLIENT_NAME);
            dt.Columns.Add(COL_PROJECT_NAME);
            dt.Columns.Add(COL_BUSINESS_CODE);

            List<Business> businesses = _dataAccessor.GetAll();
            
            foreach(Business b in businesses)
            {
                var dr = dt.NewRow();

                dr[COL_TYPE] = b.Type;
                dr[COL_CLIENT_NAME] = b.ClientName;
                dr[COL_PROJECT_NAME] = b.ProjectName;
                dr[COL_BUSINESS_CODE] = b.BusinessCode;

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
