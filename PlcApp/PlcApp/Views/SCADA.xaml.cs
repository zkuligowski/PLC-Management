using PlcApp.Classes;
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
using S7.Net;

namespace PlcApp.Views
{
    /// <summary>
    /// Interaction logic for SCADA.xaml
    /// </summary>
    public partial class SCADA : Window
    {
        public SCADA()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConnectionPLC connectionPLC = new ConnectionPLC();
            try
            {
                connectionPLC.ConnectToPLC(this.IPAdressText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
