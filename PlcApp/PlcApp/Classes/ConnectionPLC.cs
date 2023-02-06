// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Classes
{
    using S7.Net;

    public class ConnectionPLC
    {
        private readonly Plc? plc;

        public ConnectionPLC(string ipAdress)
        {
            this.plc = new Plc(CpuType.S71200, ipAdress, 0, 1);
            this.plc.Open();
        }

        public void DisconnectPLC()
        {
            this.plc.Close();
        }

        public Db1 ReadSingleVariables()
        {
            bool db1Bool1 = (bool)this.plc.Read("DB1.DBX0.0");
            bool db1Bool2 = (bool)this.plc.Read("DB1.DBX0.1");
            var db1IntVariable = (ushort)this.plc.Read("DB1.DBW2.0");
            var db1RealVariable = ((uint)this.plc.Read("DB1.DBD4.0")).ConvertToFloat();
            var db1DintVariable = (uint)this.plc.Read("DB1.DBD8.0");
            var db1DWordVariable = (uint)this.plc.Read("DB1.DBD12.0");
            var db1WordVariable = (ushort)this.plc.Read("DB1.DBW16.0");

            var db1 = new Db1();
            db1.Bool1 = db1Bool1;
            db1.Bool2 = db1Bool2;
            db1.IntVariable = (short)db1IntVariable;
            db1.RealVariable = db1RealVariable;
            db1.DIntVariable = (int)db1DintVariable;
            db1.DWordVariable = (int)db1DWordVariable;
            db1.WordVariable = db1WordVariable;

            return db1;
        }

        public void WriteSingleVariables(bool bool1, bool bool2, ushort intVariable, uint realVariable, int dIntVariable, uint dWordVariable, ushort wordVariable)
        {
            this.plc.Write("DB1.DBX0.0", bool1);
            this.plc.Write("DB1.DBX0.1", bool2);
            this.plc.Write("DB1.DBW2.0", intVariable);
            this.plc.Write("DB1.DBD4.0", realVariable);
            this.plc.Write("DB1.DBD8.0", dIntVariable);
            this.plc.Write("DB1.DBD12.0", dWordVariable);
            this.plc.Write("DB1.DBW16.0", wordVariable);
        }
    }
}
