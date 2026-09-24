namespace Reto2RutaTesoro
{
    /// <summary>
    /// Main form. It only handles user interaction (reading inputs, showing
    /// messages, refreshing the grid). All real list logic lives in
    /// <see cref="SimpleLinkedList"/> - button click handlers never
    /// manipulate nodes directly, they just call the list's methods.
    /// </summary>
    public partial class FrmRutaTesoro : Form
    {
        // The only real data store in the whole application.
        private readonly SimpleLinkedList route = new SimpleLinkedList();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            ConfigureGrid();
            LoadSampleData();
        }

        /// <summary>
        /// Defines the (read-only, display-only) columns of the grid.
        /// The grid never stores data - it is rebuilt from the linked list
        /// every time something changes.
        /// </summary>
        private void ConfigureGrid()
        {
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Width = 50
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Lugar",
                Width = 120
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colClue",
                HeaderText = "Pista",
                Width = 190,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvRoute.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDanger",
                HeaderText = "Peligro",
                Width = 60
            });
        }

        /// <summary>
        /// Seeds the linked list with the sample route from the challenge
        /// statement, so the grid is not empty on startup.
        /// </summary>
        private void LoadSampleData()
        {
            route.InsertAtEnd(1, "Londres, Inglaterra", "Busca la cabina roja frente al reloj mas famoso del mundo.", 3);
            route.InsertAtEnd(2, "Zermatt, Suiza", "La montana con forma de piramide vigila el pueblo alpino.", 6);
            route.InsertAtEnd(3, "Paris, Francia", "Bajo la torre de hierro florecen los cerezos al atardecer.", 4);
            route.InsertAtEnd(4, "Monte Fuji, Japon", "El volcan sagrado corona el paisaje mas alla de la carretera.", 7);
            route.InsertAtEnd(5, "Ciudad de Mexico", "El angel dorado vigila la avenida mas emblematica de la ciudad.", 5);
            route.InsertAtEnd(6, "Las Vegas, Nevada", "Las luces de neon anuncian la ciudad que nunca duerme.", 8);
            route.InsertAtEnd(7, "Monte Rushmore", "Cuatro rostros de piedra observan desde la montana.", 6);
            RefreshGrid();
        }

        /// <summary>
        /// Rebuilds the DataGridView by walking the linked list from Head to
        /// null. This is called after every insert, modify or delete.
        /// </summary>
        private void RefreshGrid()
        {
            dgvRoute.Rows.Clear();

            foreach (Node node in route)
            {
                dgvRoute.Rows.Add(node.Id, node.LocationName, node.Clue, node.DangerLevel);
            }

            lblStatus.Text = $"Total de lugares en la ruta: {route.Count}";
        }

        // ---------------------------------------------------------------
        // Button handlers: each one only reads the form, calls the list,
        // and refreshes the view. No linked-list logic lives here.
        // ---------------------------------------------------------------

        private void btnAddEnd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out string clue, out int danger))
            {
                return;
            }

            int id = (int)numId.Value;

            try
            {
                route.InsertAtEnd(id, name, clue, danger);
                RefreshGrid();
                ClearForm();
                lblStatus.Text = $"Lugar '{name}' insertado al final.";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddBeginning_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out string clue, out int danger))
            {
                return;
            }

            int id = (int)numId.Value;

            try
            {
                route.InsertAtBeginning(id, name, clue, danger);
                RefreshGrid();
                ClearForm();
                lblStatus.Text = $"Lugar '{name}' insertado al inicio.";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            int id = (int)numId.Value;
            Node? found = route.Search(id);

            if (found == null)
            {
                MessageBox.Show($"No se encontro ningun lugar con el ID {id}.", "No Encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = $"Busqueda: ID {id} no encontrado.";
                return;
            }

            txtName.Text = found.LocationName;
            txtClue.Text = found.Clue;
            numDanger.Value = found.DangerLevel;
            HighlightRow(id);
            MostrarImagenLugar(found.LocationName);
            lblStatus.Text = $"Encontrado: '{found.LocationName}' (Nivel de peligro {found.DangerLevel}).";
        }

        private void btnModify_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out string clue, out int danger))
            {
                return;
            }

            int id = (int)numId.Value;
            bool success = route.Modify(id, name, clue, danger);

            if (success)
            {
                RefreshGrid();
                lblStatus.Text = $"Lugar {id} actualizado correctamente.";
            }
            else
            {
                MessageBox.Show($"No se encontro ningun lugar con el ID {id} para modificar.", "No Encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            int id = (int)numId.Value;

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el lugar con ID {id}?",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            bool success = route.Delete(id);

            if (success)
            {
                RefreshGrid();
                ClearForm();
                lblStatus.Text = $"Lugar {id} eliminado.";
            }
            else
            {
                MessageBox.Show($"No se encontro ningun lugar con el ID {id} para eliminar.", "No Encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
            lblStatus.Text = "Formulario limpiado.";
        }

        /// <summary>
        /// Clicking a grid row loads that node's data into the input
        /// fields, ready for a Modify or Delete operation. This only reads
        /// from the grid for convenience - the grid is never the data source.
        /// </summary>
        private void dgvRoute_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvRoute.Rows[e.RowIndex];
            numId.Value = Convert.ToInt32(row.Cells["colId"].Value);
            txtName.Text = row.Cells["colName"].Value?.ToString() ?? string.Empty;
            txtClue.Text = row.Cells["colClue"].Value?.ToString() ?? string.Empty;
            numDanger.Value = Convert.ToInt32(row.Cells["colDanger"].Value);

            MostrarImagenLugar(txtName.Text);
        }

        // ---------------------------------------------------------------
        // Imagenes: cada lugar puede tener una imagen en la carpeta
        // "Imagenes" del proyecto, nombrada igual que el lugar
        // (ej. "Playa del Naufragio.jpg"). Solo es presentacion visual,
        // no toca la logica de la lista enlazada.
        // ---------------------------------------------------------------

        private static readonly string CarpetaImagenes =
            Path.Combine(AppContext.BaseDirectory, "Imagenes");

        private void MostrarImagenLugar(string nombreLugar)
        {
            picLugar.Image?.Dispose();
            picLugar.Image = null;

            if (string.IsNullOrWhiteSpace(nombreLugar))
            {
                lblSinImagen.Text = "Selecciona un lugar de la tabla para ver su imagen.";
                lblSinImagen.Visible = true;
                return;
            }

            string? rutaImagen = BuscarArchivoImagen(nombreLugar);

            if (rutaImagen == null)
            {
                lblSinImagen.Text = $"Sin imagen disponible para:\n'{nombreLugar}'";
                lblSinImagen.Visible = true;
                return;
            }

            try
            {
                using FileStream stream = new(rutaImagen, FileMode.Open, FileAccess.Read);
                picLugar.Image = Image.FromStream(stream);
                lblSinImagen.Visible = false;
            }
            catch
            {
                lblSinImagen.Text = $"No se pudo cargar la imagen de:\n'{nombreLugar}'";
                lblSinImagen.Visible = true;
            }
        }

        private static string? BuscarArchivoImagen(string nombreLugar)
        {
            if (!Directory.Exists(CarpetaImagenes))
            {
                return null;
            }

            string[] extensiones = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            foreach (string ext in extensiones)
            {
                string candidato = Path.Combine(CarpetaImagenes, nombreLugar + ext);
                if (File.Exists(candidato))
                {
                    return candidato;
                }
            }

            return null;
        }

        // ---------------------------------------------------------------
        // Helpers
        // ---------------------------------------------------------------

        private bool ValidateInputs(out string name, out string clue, out int danger)
        {
            name = txtName.Text.Trim();
            clue = txtClue.Text.Trim();
            danger = (int)numDanger.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Por favor ingresa el nombre del lugar.", "Error de Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(clue))
            {
                MessageBox.Show("Por favor ingresa una pista.", "Error de Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            numId.Value = numId.Minimum;
            txtName.Clear();
            txtClue.Clear();
            numDanger.Value = numDanger.Minimum;
            MostrarImagenLugar(string.Empty);
            txtName.Focus();
        }

        private void HighlightRow(int id)
        {
            foreach (DataGridViewRow row in dgvRoute.Rows)
            {
                if (row.Cells["colId"].Value != null &&
                    Convert.ToInt32(row.Cells["colId"].Value) == id)
                {
                    dgvRoute.ClearSelection();
                    row.Selected = true;
                    dgvRoute.CurrentCell = row.Cells["colId"];
                    break;
                }
            }
        }
    }
}
