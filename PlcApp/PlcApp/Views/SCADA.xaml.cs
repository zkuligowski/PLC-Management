using PlcApp.Classes;
using System;
using System.Windows;
using System.Windows.Controls;
using S7.Net;
using S7.Net.Types;
using System.Globalization;

namespace PlcApp.Views
{
    /// <summary>
    /// Interaction logic for SCADA.xaml
    /// </summary>
    public partial class SCADA : Window
    {
        private ConnectionPLC connectionPLC;

        public SCADA()
        {
            InitializeComponent();
        }

        private void ConnectPLC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.connectionPLC = new ConnectionPLC(this.IPAdressText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void WritePLC_Click(object sender, RoutedEventArgs e)
        {
            bool bool1 = Convert.ToBoolean(this.bool1Txt.Text);
            bool bool2 = Convert.ToBoolean(this.bool2Txt.Text);
            ushort intVariable = (ushort)Convert.ToInt16(this.intTxt.Text);
            var realVariable = float.Parse(this.realTxt.Text, CultureInfo.InvariantCulture.NumberFormat).ConvertToUInt();
            int dIntVariable = Convert.ToInt32(this.dIntTxt.Text);
            uint dWordVariable = Convert.ToUInt32(this.dWordTxt.Text);
            ushort wordVariable = Convert.ToUInt16(this.wordTxt.Text);

            this.connectionPLC.WriteSingleVariables(
                bool1,
                bool2,
                intVariable,
                realVariable,
                dIntVariable,
                dWordVariable,
                wordVariable);
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ReadPLC_Click(object sender, RoutedEventArgs e)
        {
            var db1 = this.connectionPLC.ReadSingleVariables();
            this.bool1Txt.Text = db1.Bool1.ToString();
            this.bool2Txt.Text = db1.Bool2.ToString();
            this.intTxt.Text = db1.IntVariable.ToString();
            this.realTxt.Text = db1.RealVariable.ToString();
            this.dIntTxt.Text = db1.DIntVariable.ToString();
            this.dWordTxt.Text = db1.DWordVariable.ToString();
            this.wordTxt.Text = db1.WordVariable.ToString();
        }
    }
}
