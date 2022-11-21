

namespace PlcApp.Classes
{
    using PlcApp.Views;
    using S7.Net;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConnectionPLC
    {
        public void ConnectToPLC(string ipAdress)
        {
            using (var plc = new Plc(CpuType.S71200, ipAdress, 0, 1))
            {
                plc.Open();

                ReadSingleVariable(plc);
                WriteSingleVariable(plc);
                //plc.Write("DB1.DBX0.0", 1);
                //byte[] db1Bytes = new byte[18];
                //plc.WriteBytes(DataType.DataBlock, 1, 0, db1Bytes);
            }
        }

        public void ReadSingleVariable(Plc plc)
        {
            bool db1Bool1 = (bool)plc.Read("DB1.DBX0.0");
            bool db1Bool2 = (bool)plc.Read("DB1.DBX0.1");
            var db1IntVariable = (ushort)plc.Read("DB1.DBW2.0");
            var db1RealVariable = ((uint)plc.Read("DB1.DBD4.0")).ConvertToFloat();
            var db1DintVariable = (uint)plc.Read("DB1.DBD8.0");
            var db1DWordVariable = (uint)plc.Read("DB1.DBD12.0");
            var db1WordVariable = (ushort)plc.Read("DB1.DBW16.0");
            var test = db1Bool1;
        }

        public void WriteSingleVariable(Plc plc)
        {
            bool b1 = true;
            plc.Write("DB1.DBX0.0", 0);
        }
    }
}
