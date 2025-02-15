﻿using Proyecto_Final_AP1.BLL;
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
    /// Interaction logic for rLogin.xaml
    /// </summary>
    public partial class rLogin : Window
    {
        public rLogin()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void IniciarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Login(NombreTextBox.Text, UsuariosBLL.SHA1(ContraseñaTextBox.Password)))
            {
                var usuario = UsuariosBLL.BuscarPorNombre(NombreTextBox.Text);
                this.Hide();//ocultamos la ventana del login
                MainWindow mainWindow = new MainWindow(usuario);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                NombreTextBox.Text = "";
                ContraseñaTextBox.Password = "";
                MessageBox.Show("Usuario o Contraseña Incorrecto!!", "Login");
            }

        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ContraseñaTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ContraseñaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (UsuariosBLL.Login(NombreTextBox.Text, UsuariosBLL.SHA1(ContraseñaTextBox.Password)))
                {
                    var usuario = UsuariosBLL.BuscarPorNombre(NombreTextBox.Text);
                    this.Hide();//ocultamos la ventana del login
                    MainWindow mainWindow = new MainWindow(usuario);
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    NombreTextBox.Text = "";
                    ContraseñaTextBox.Password = "";
                    MessageBox.Show("Usuario o Contraseña Incorrecto!!", "Login");
                }
            }
        }
    }
}
