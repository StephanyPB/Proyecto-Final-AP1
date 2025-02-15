﻿using Proyecto_Final_AP1.Entidades;
using Proyecto_Final_AP1.UI.Consultas;
using Proyecto_Final_AP1.UI.Registros;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Final_AP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Usuarios user { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Usuarios usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void NegocioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rNegocios negocios = new rNegocios();
            negocios.Show();
        }

        private void ConsultaNegocioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cNegocios cNegocio = new cNegocios();
            cNegocio.Show();
        }

        private void GaranteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rGarantes garante = new rGarantes();
            garante.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rClientes clientes = new rClientes();
            clientes.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            cClientes cclientes = new cClientes();
            cclientes.Show();
        }

        private void ConsultaGaranteMenuitem_Click(object sender, RoutedEventArgs e)
        {
            cGarantes garante = new cGarantes();
            garante.Show();
        }

        private void EstadoCivilesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEstadosCiviles estadosciviles = new rEstadosCiviles();
            estadosciviles.Show();
        }

        private void ConsultaEstadosCivilesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cEstadosCiviles estadosciviless = new cEstadosCiviles();
            estadosciviless.Show();
        }

        private void TipoViviendaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rTipoViviendas viviendas = new rTipoViviendas();
            viviendas.Show();
        }

        private void ConsultaTipoViviendas_Click_1(object sender, RoutedEventArgs e)
        {
            cTipoViviendas viviendas = new cTipoViviendas();
            viviendas.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            rPermisos permisos = new rPermisos();
            permisos.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            cPermisos permisosc = new cPermisos();
            permisosc.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            rSexos sexos = new rSexos();
            sexos.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            cSexos sexosc = new cSexos();
            sexosc.Show();
        }

        private void RolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles roles = new rRoles();
            roles.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            rPrestamos prestamos = new rPrestamos();
            prestamos.Show();
        }

        private void CobrosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCobros cobros = new rCobros();
            cobros.Show();
        }

        private void UsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios usuarios = new rUsuarios();
            usuarios.Show();
        }
        private void ConsultaRolesMenuitem_Click_1(object sender, RoutedEventArgs e)
        {
            cRoles cRoles = new cRoles();
            cRoles.Show();
        }

        private void ConsultaUsuarioMenuitem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cUsuario = new cUsuarios();
            cUsuario.Show();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            cPrestamos prestamosc = new cPrestamos();
            prestamosc.Show();
        }

        private void MorasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rMoras moras = new rMoras();
            moras.Show();
        }

        private void ConsultaMorasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cMoras cMoras = new cMoras();
            cMoras.Show();
        }

        private void ConsultadeCobros_Click(object sender, RoutedEventArgs e)
        {
            cCobros cobros = new cCobros();
            cobros.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            cPrestamosDetalle prestamosDetalle = new cPrestamosDetalle();
            prestamosDetalle.Show();
        }

        private void ConsultaUsuarioDetalleMenuitem_Click(object sender, RoutedEventArgs e)
        {
            cUsuariosDetalle cUsuariosDetalle = new cUsuariosDetalle();
            cUsuariosDetalle.Show();
        }
    }
}
