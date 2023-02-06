// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using PlcApp.Classes;
    using PlcApp.Models;
    using S7.Net;

    public class ConnectionRepository : RepositoryBase, IConnectionRepository
    {
        private Plc? plc;

        public bool Connect(string ipAddress)
        {
            this.plc = new Plc(CpuType.S71200, ipAddress, 0, 1);
            this.plc.Open();

            return this.plc.IsConnected;
        }

        public bool Disconnect(string ipAddress)
        {
            this.plc = new Plc(CpuType.S71200, ipAddress, 0, 1);

            if (this.plc.IsConnected)
            {
                this.plc.Close();
                return true;
            }

            return false;
        }

        public Db1Model ReadSingleVariables()
        {
            bool db1Bool1 = (bool)this.plc.Read("DB1.DBX0.0");
            var db1IntVariable = (ushort)this.plc.Read("DB1.DBW2.0");
            var db1RealVariable = ((uint)this.plc.Read("DB1.DBD4.0")).ConvertToFloat();
            var db1DintVariable = (uint)this.plc.Read("DB1.DBD8.0");
            var db1DWordVariable = (uint)this.plc.Read("DB1.DBD12.0");
            var db1WordVariable = (ushort)this.plc.Read("DB1.DBW16.0");

            var db1 = new Db1Model(db1Bool1, (short)db1IntVariable, db1RealVariable, (int)db1DintVariable, (int)db1DWordVariable, db1WordVariable);

            return db1;
        }

        public void WriteSingleVariables(bool bool1, ushort intVariable, uint realVariable, int dIntVariable, uint dWordVariable, ushort wordVariable)
        {
            this.plc.Write("DB1.DBX0.0", bool1);
            //this.plc.Write("DB1.DBX0.1", bool2);
            this.plc.Write("DB1.DBW2.0", intVariable);
            this.plc.Write("DB1.DBD4.0", realVariable);
            this.plc.Write("DB1.DBD8.0", dIntVariable);
            this.plc.Write("DB1.DBD12.0", dWordVariable);
            this.plc.Write("DB1.DBW16.0", wordVariable);
        }
    }
}
