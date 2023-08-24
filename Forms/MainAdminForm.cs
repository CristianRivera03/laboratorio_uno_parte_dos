using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioDos.Forms
{
    public partial class MainAdminForm : Form
    {
        private int n = 0; // Variable para almacenar el índice de la fila seleccionada

        public MainAdminForm()
        {
            InitializeComponent();
            DuiAdminTextBox.KeyPress += DuiAdminTextBox_KeyPress;
        }

        private void DuiAdminTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter ingresado
            }
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Añadir nueva fila al DataGridView
                int n = PrestamosDataGridView.Rows.Add();

                // Colocar información en las celdas de la fila
                PrestamosDataGridView.Rows[n].Cells[0].Value = DuiAdminTextBox.Text;
                PrestamosDataGridView.Rows[n].Cells[1].Value = NombreAdminTextBox.Text;
                PrestamosDataGridView.Rows[n].Cells[2].Value = CantidadAdminNumericUpDown.Text;
                PrestamosDataGridView.Rows[n].Cells[3].Value = EstadoComboBox.Text;

                // Limpiar campos de entrada
                DuiAdminTextBox.Text = "";
                NombreAdminTextBox.Text = "";
                CantidadAdminNumericUpDown.Text = "";
                EstadoComboBox.Text = "";
            }
        }

        private void PrestamosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex; // Almacenar el índice de la fila seleccionada
            if (n != -1)
            {
                // Mostrar el valor de la segunda celda (columna 1) en un control Label
                MostrarLabel.Text = (string)PrestamosDataGridView.Rows[n].Cells[1].Value;
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                // Eliminar la fila seleccionada del DataGridView
                PrestamosDataGridView.Rows.RemoveAt(n);
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (DuiAdminTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(DuiAdminTextBox, "Ingresar Dui");
            }
            else
            {
                errorProvider1.SetError(DuiAdminTextBox, "");
            }

            if (NombreAdminTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(NombreAdminTextBox, "Ingresar Nombre");
            }
            else
            {
                errorProvider1.SetError(NombreAdminTextBox, "");
            }

            if (CantidadAdminNumericUpDown.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CantidadAdminNumericUpDown, "Ingresar Cantidad");
            }
            else
            {
                errorProvider1.SetError(CantidadAdminNumericUpDown, "");
            }

            if (EstadoComboBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(EstadoComboBox, "Ingresar estado");
            }
            else
            {
                errorProvider1.SetError(EstadoComboBox, "");
            }

            return ok;
        }
    }
}
