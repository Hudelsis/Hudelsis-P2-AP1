using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hudelsis_P2_AP1.BLL;
using Hudelsis_P2_AP1.Entidades;


namespace Hudelsis_P2_AP1.UI.Consultas
{
    public partial class cTareas : Window
    {
        public cTareas()
        {
            InitializeComponent();
            
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Proyectos>();
            listado = ProyectosBLL.GetList(c => true);
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
            
    }
}
