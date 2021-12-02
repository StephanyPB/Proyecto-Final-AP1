﻿using Proyecto_Final_AP1.BLL;
using Proyecto_Final_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for rRoles.xaml
    /// </summary>
    public partial class rRoles : Window
    {
        private Roles Rol;
        public rRoles()
        {
            InitializeComponent();
            this.DataContext = this.Rol = new Roles(); ;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (DescripcionTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transacción Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (RolesBLL.ExisteDescripcion(DescripcionTextBox.Text))
            {
                esValido = false;
                MessageBox.Show("Esta descripcion ya existe ..");
            }
            if (RolIDTextBox.Text.Contains("-"))
            {
                esValido = false;
                MessageBox.Show("Corregir formato de Id!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
        private void Limpiar()
        {
            RolIDTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            FechaDatePicker.SelectedDate = DateTime.Now;
            Rol = new Roles();
        }  

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = RolesBLL.Guardar(this.Rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (RolesBLL.Eliminar(this.Rol.RolId))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("No fue posible eliminarlo", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void BuscarIDButton_Click(object sender, RoutedEventArgs e)
        {
         
            var Rol = RolesBLL.Buscar(Utilidades.ToInt(RolIDTextBox.Text));
           

            if (Rol != null)
                this.Rol = Rol;
            else
            {
                this.Rol = new Roles();
                MessageBox.Show("No existe este Rol!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.Rol;
        }

    }
}
