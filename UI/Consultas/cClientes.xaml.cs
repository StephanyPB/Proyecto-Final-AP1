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

namespace Proyecto_Final_AP1.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cClientes.xaml
    /// </summary>
    public partial class cClientes : Window
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void BuscarCriterioButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Clientes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //ClienteId
                        int.TryParse(CriterioTextBox.Text, out int ClienteId);
                        listado = ClientesBLL.GetList(a => a.ClienteId == ClienteId);
                        break;

                    case 1: //NombreCliente
                        listado = ClientesBLL.GetList(a => a.Nombres.ToLower().Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = ClientesBLL.GetList(c => true);
            }

            DetalleDataGrid.ItemsSource = null;
            DetalleDataGrid.ItemsSource = listado;
        }
        private void CriterioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var listado = new List<Clientes>();

                if (CriterioTextBox.Text.Trim().Length > 0)
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //ClienteId
                            int.TryParse(CriterioTextBox.Text, out int ClienteId);
                            listado = ClientesBLL.GetList(a => a.ClienteId == ClienteId);
                            break;

                        case 1: //NombreCliente
                            listado = ClientesBLL.GetList(a => a.Nombres.ToLower().Contains(CriterioTextBox.Text));
                            break;
                    }
                }
                else
                {
                    listado = ClientesBLL.GetList(c => true);
                }

                DetalleDataGrid.ItemsSource = null;
                DetalleDataGrid.ItemsSource = listado;
            }
        }
    }
}
