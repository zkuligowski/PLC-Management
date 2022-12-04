// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Views
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Controls;
    using PlcApp.Classes;
    using S7.Net;

    /// <summary>
    /// Interaction logic for SCADA.xaml.
    /// </summary>
    public partial class SCADA : Window
    {
        private ConnectionPLC connectionPLC;

        public SCADA()
        {
            this.InitializeComponent();
        }

        private void ConnectPLC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.connectionPLC = new ConnectionPLC(this.IPAddressTxt.Text);
                this.IPAddressTxt.IsEnabled = false;
                this.ConnectPLCbtn.IsEnabled = false;
                this.DisconnectPLCbtn.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void WritePLC_Click(object sender, RoutedEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ReadPLC_Click(object sender, RoutedEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DisconnectPLC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.connectionPLC.DisconnectPLC();
                this.IPAddressTxt.IsEnabled = true;
                this.ConnectPLCbtn.IsEnabled = true;
                this.DisconnectPLCbtn.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
