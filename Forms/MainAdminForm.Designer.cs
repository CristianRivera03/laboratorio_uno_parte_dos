namespace LaboratorioDos.Forms
{
    partial class MainAdminForm
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
            this.components = new System.ComponentModel.Container();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PrestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreAdminTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadAdminNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MostrarLabel = new System.Windows.Forms.Label();
            this.DuiAdminTextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.EstadoAdminLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadAdminNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.TituloLabel.Font = new System.Drawing.Font("Product Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TituloLabel.Location = new System.Drawing.Point(41, 9);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(479, 45);
            this.TituloLabel.TabIndex = 1;
            this.TituloLabel.Text = "Administrador de Prestamos";
            // 
            // PrestamosDataGridView
            // 
            this.PrestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dui,
            this.Nombre,
            this.Cantidad,
            this.Estado});
            this.PrestamosDataGridView.Location = new System.Drawing.Point(49, 257);
            this.PrestamosDataGridView.Name = "PrestamosDataGridView";
            this.PrestamosDataGridView.Size = new System.Drawing.Size(442, 172);
            this.PrestamosDataGridView.TabIndex = 2;
            this.PrestamosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamosDataGridView_CellClick);
            // 
            // dui
            // 
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(75, 80);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 3;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreAdminTextBox
            // 
            this.NombreAdminTextBox.Location = new System.Drawing.Point(142, 77);
            this.NombreAdminTextBox.Name = "NombreAdminTextBox";
            this.NombreAdminTextBox.Size = new System.Drawing.Size(154, 20);
            this.NombreAdminTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DUI";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(75, 167);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(49, 13);
            this.CantidadLabel.TabIndex = 7;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // CantidadAdminNumericUpDown
            // 
            this.CantidadAdminNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CantidadAdminNumericUpDown.Location = new System.Drawing.Point(142, 160);
            this.CantidadAdminNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CantidadAdminNumericUpDown.Name = "CantidadAdminNumericUpDown";
            this.CantidadAdminNumericUpDown.Size = new System.Drawing.Size(154, 20);
            this.CantidadAdminNumericUpDown.TabIndex = 9;
            this.CantidadAdminNumericUpDown.ThousandsSeparator = true;
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(335, 77);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(156, 23);
            this.AñadirButton.TabIndex = 11;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(335, 106);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(156, 23);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MostrarLabel
            // 
            this.MostrarLabel.AutoSize = true;
            this.MostrarLabel.Location = new System.Drawing.Point(75, 203);
            this.MostrarLabel.Name = "MostrarLabel";
            this.MostrarLabel.Size = new System.Drawing.Size(17, 13);
            this.MostrarLabel.TabIndex = 13;
            this.MostrarLabel.Text = "\"\"";
            // 
            // DuiAdminTextBox
            // 
            this.DuiAdminTextBox.Location = new System.Drawing.Point(142, 103);
            this.DuiAdminTextBox.Name = "DuiAdminTextBox";
            this.DuiAdminTextBox.Size = new System.Drawing.Size(154, 20);
            this.DuiAdminTextBox.TabIndex = 14;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado",
            "Esperando Aprobacion"});
            this.EstadoComboBox.Location = new System.Drawing.Point(142, 129);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(154, 21);
            this.EstadoComboBox.TabIndex = 15;
            this.EstadoComboBox.Text = "Estado de prestamo";
            // 
            // EstadoAdminLabel
            // 
            this.EstadoAdminLabel.AutoSize = true;
            this.EstadoAdminLabel.Location = new System.Drawing.Point(75, 137);
            this.EstadoAdminLabel.Name = "EstadoAdminLabel";
            this.EstadoAdminLabel.Size = new System.Drawing.Size(40, 13);
            this.EstadoAdminLabel.TabIndex = 16;
            this.EstadoAdminLabel.Text = "Estado";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaboratorioDos.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.EstadoAdminLabel);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(this.DuiAdminTextBox);
            this.Controls.Add(this.MostrarLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.CantidadAdminNumericUpDown);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreAdminTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.PrestamosDataGridView);
            this.Controls.Add(this.TituloLabel);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadAdminNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.DataGridView PrestamosDataGridView;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreAdminTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.NumericUpDown CantidadAdminNumericUpDown;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label MostrarLabel;
        private System.Windows.Forms.TextBox DuiAdminTextBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label EstadoAdminLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}