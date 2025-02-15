﻿using Proyecto_Final_AP1.BLL;
using Proyecto_Final_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Final_AP1.UI.Registros
{
    /// <summary>
    /// Interaction logic for rNegocios.xaml
    /// </summary>
    public partial class rNegocios : Window
    {
        private Negocios Negocio = new Negocios();
        public rNegocios()
        {
            Negocio = new Negocios();
            this.DataContext = this.Negocio;
            InitializeComponent();
            LLenarComboNegocio();
            LLenarComboCliente();
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombreTextBox.Text.Length <= 2)
            {
                esValido = false;
                MessageBox.Show("Transacción Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (DireccionTextBox.Text.Length <= 4)
            {
                esValido = false;
                MessageBox.Show("Debes agregar una Direccion", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (NombresComboBox.Items.Count == 0)
            {
                esValido = false;
                MessageBox.Show("Debes agregar un Nombre", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TelefonoTextBox.Text.Length < 12)
            {
                esValido = false;
                MessageBox.Show("Complete el numero", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (!TelefonoTextBox.Text.Contains("-") && !TelefonoTextBox.Text.Contains("-"))
            {
                esValido = false;
                MessageBox.Show("Debe arreglar el formato del telefono....");
            }
            if (NegocioIdTextBox.Text.ToInt() < 0)
            {
                esValido = false;
                MessageBox.Show("Debe ingresar un Id valido");
            }

            return esValido;
        }
        private void LLenarComboNegocio()
        {
            this.TipoNegocio.ItemsSource = TipoNegociosBLL.GetList(x => true);
            this.TipoNegocio.SelectedValuePath = "TipoNegocioId";
            this.TipoNegocio.DisplayMemberPath = "Descripcion";

            if (TipoNegocio.Items.Count > 0)
            {
                TipoNegocio.SelectedIndex = 0;
            }
        }

        private void LLenarComboCliente()
        {
            this.NombresComboBox.ItemsSource = ClientesBLL.GetList(x => true);
            this.NombresComboBox.SelectedValuePath = "ClienteId";
            this.NombresComboBox.DisplayMemberPath = "Nombres";

            if (NombresComboBox.Items.Count > 0)
            {
                NombresComboBox.SelectedIndex = 0;
            }
        }
        private void Limpiar()
        {
            Negocio = new Negocios();
            DataContext = new Negocios();
            LLenarComboNegocio();
            Cargar();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

            Negocios existe = NegociosBLL.Buscar(Utilidades.ToInt(Negocio.NegocioId));

            if (NegociosBLL.Eliminar(this.Negocio.NegocioId))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("No fue posible eliminarlo", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            Negocio.TipoNegocioId = ((TipoNegocios)this.TipoNegocio.SelectedItem).TipoNegocioId;
            Negocio.ClientesId = ((Clientes)NombresComboBox.SelectedItem).ClienteId;
            var paso = NegociosBLL.Guardar(this.Negocio);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            var Negocio = NegociosBLL.Buscar(Utilidades.ToInt(NegocioIdTextBox.Text));

            if (Negocio != null)
            {
                this.Negocio = Negocio;
                this.TipoNegocio.SelectedValue = Negocio.TipoNegocioId;
                this.NombresComboBox.SelectedValue = Negocio.ClientesId;
            }
            else
            {
                this.Negocio = new Negocios();
                MessageBox.Show("Este Negocio no existe", "No existe", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            this.DataContext = this.Negocio;
            Cargar();

        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = this.Negocio;
        }

        private void NegocioIdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void NombreTextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TelefonoTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DireccionTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9#.,/]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
