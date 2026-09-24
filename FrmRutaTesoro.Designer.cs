namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblClue;
        private System.Windows.Forms.TextBox txtClue;
        private System.Windows.Forms.Label lblDanger;
        private System.Windows.Forms.NumericUpDown numDanger;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAddEnd;
        private System.Windows.Forms.Button btnAddBeginning;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picLugar;
        private System.Windows.Forms.Label lblSinImagen;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClue = new System.Windows.Forms.Label();
            this.txtClue = new System.Windows.Forms.TextBox();
            this.lblDanger = new System.Windows.Forms.Label();
            this.numDanger = new System.Windows.Forms.NumericUpDown();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAddEnd = new System.Windows.Forms.Button();
            this.btnAddBeginning = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picLugar = new System.Windows.Forms.PictureBox();
            this.lblSinImagen = new System.Windows.Forms.Label();

            this.grpInput.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 32);
            this.lblTitle.Text = "La Ruta del Tesoro Perdido \u2013 Lista Enlazada";

            // grpInput
            this.grpInput.Controls.Add(this.lblId);
            this.grpInput.Controls.Add(this.numId);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.lblClue);
            this.grpInput.Controls.Add(this.txtClue);
            this.grpInput.Controls.Add(this.lblDanger);
            this.grpInput.Controls.Add(this.numDanger);
            this.grpInput.Controls.Add(this.pnlButtons);
            this.grpInput.Location = new System.Drawing.Point(20, 60);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(300, 470);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Datos del Lugar";

            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(90, 15);
            this.lblId.Text = "ID del Lugar:";

            // numId
            this.numId.Location = new System.Drawing.Point(140, 28);
            this.numId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 23);
            this.numId.TabIndex = 0;
            this.numId.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 15);
            this.lblName.Text = "Nombre:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(140, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 23);
            this.txtName.TabIndex = 1;

            // lblClue
            this.lblClue.AutoSize = true;
            this.lblClue.Location = new System.Drawing.Point(15, 104);
            this.lblClue.Name = "lblClue";
            this.lblClue.Size = new System.Drawing.Size(38, 15);
            this.lblClue.Text = "Pista:";

            // txtClue
            this.txtClue.Location = new System.Drawing.Point(140, 101);
            this.txtClue.Multiline = true;
            this.txtClue.Name = "txtClue";
            this.txtClue.Size = new System.Drawing.Size(140, 60);
            this.txtClue.TabIndex = 2;

            // lblDanger
            this.lblDanger.AutoSize = true;
            this.lblDanger.Location = new System.Drawing.Point(15, 175);
            this.lblDanger.Name = "lblDanger";
            this.lblDanger.Size = new System.Drawing.Size(130, 15);
            this.lblDanger.Text = "Nivel de Peligro (1-10):";

            // numDanger
            this.numDanger.Location = new System.Drawing.Point(140, 172);
            this.numDanger.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numDanger.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDanger.Name = "numDanger";
            this.numDanger.Size = new System.Drawing.Size(120, 23);
            this.numDanger.TabIndex = 3;
            this.numDanger.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnAddEnd);
            this.pnlButtons.Controls.Add(this.btnAddBeginning);
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Controls.Add(this.btnModify);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Location = new System.Drawing.Point(15, 215);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(270, 245);
            this.pnlButtons.TabIndex = 4;

            // btnAddEnd
            this.btnAddEnd.Location = new System.Drawing.Point(0, 0);
            this.btnAddEnd.Name = "btnAddEnd";
            this.btnAddEnd.Size = new System.Drawing.Size(265, 32);
            this.btnAddEnd.TabIndex = 0;
            this.btnAddEnd.Text = "Insertar al Final";
            this.btnAddEnd.UseVisualStyleBackColor = true;
            this.btnAddEnd.Click += new System.EventHandler(this.btnAddEnd_Click);

            // btnAddBeginning
            this.btnAddBeginning.Location = new System.Drawing.Point(0, 38);
            this.btnAddBeginning.Name = "btnAddBeginning";
            this.btnAddBeginning.Size = new System.Drawing.Size(265, 32);
            this.btnAddBeginning.TabIndex = 1;
            this.btnAddBeginning.Text = "Insertar al Inicio";
            this.btnAddBeginning.UseVisualStyleBackColor = true;
            this.btnAddBeginning.Click += new System.EventHandler(this.btnAddBeginning_Click);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(0, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(265, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar por ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnModify
            this.btnModify.Location = new System.Drawing.Point(0, 114);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(265, 32);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar ID Seleccionado";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(0, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar por ID";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(0, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(265, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar Formulario";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvRoute
            this.dgvRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.AutoGenerateColumns = false;
            this.dgvRoute.ReadOnly = true;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.MultiSelect = false;
            this.dgvRoute.Location = new System.Drawing.Point(340, 60);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.RowHeadersWidth = 30;
            this.dgvRoute.Size = new System.Drawing.Size(430, 435);
            this.dgvRoute.TabIndex = 5;
            this.dgvRoute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoute_CellClick);

            // grpImage
            this.grpImage.Controls.Add(this.picLugar);
            this.grpImage.Controls.Add(this.lblSinImagen);
            this.grpImage.Location = new System.Drawing.Point(790, 60);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(230, 435);
            this.grpImage.TabIndex = 7;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Imagen del Lugar";
            this.grpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right))));

            // picLugar
            this.picLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLugar.Location = new System.Drawing.Point(10, 25);
            this.picLugar.Name = "picLugar";
            this.picLugar.Size = new System.Drawing.Size(210, 400);
            this.picLugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLugar.TabIndex = 0;
            this.picLugar.TabStop = false;
            this.picLugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            // lblSinImagen
            this.lblSinImagen.Location = new System.Drawing.Point(10, 190);
            this.lblSinImagen.Name = "lblSinImagen";
            this.lblSinImagen.Size = new System.Drawing.Size(210, 40);
            this.lblSinImagen.TabIndex = 1;
            this.lblSinImagen.Text = "Selecciona un lugar de la tabla para ver su imagen.";
            this.lblSinImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblStatus
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(20, 542);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1000, 28);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Listo.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            // FrmRutaTesoro
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 590);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvRoute);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.lblStatus);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "FrmRutaTesoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reto 2 - La Ruta del Tesoro Perdido";

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
