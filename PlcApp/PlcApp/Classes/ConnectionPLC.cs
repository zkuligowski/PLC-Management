

namespace PlcApp.Classes
{
    using S7.Net;

    public class ConnectionPLC
    {
        public void ConnectToPLC(string ipAdress)
        {
            using (var plc = new Plc(CpuType.S71200, ipAdress, 0, 1))
            {
                plc.Open();

                ReadSingleVariable(plc);
                WriteSingleVariable(plc);
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
            plc.Write("DB1.DBX0.0", 1);
            plc.Write("DB1.DBX0.1", 1);
            plc.Write("DB1.DBW2.0", (ushort)69);
            plc.Write("DB1.DBD4.0", 21.37);
            plc.Write("DB1.DBD8.0", 123123);
            plc.Write("DB1.DBD12.0", (uint)123123);
            plc.Write("DB1.DBW16.0", (ushort)12312);

        }
    }
}
