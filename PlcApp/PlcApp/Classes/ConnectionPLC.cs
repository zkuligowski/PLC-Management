// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Classes
{
    using DotNetSiemensPLCToolBoxLibrary.Communication;
    using S7.Net;
    using System.Net;
    using System.Windows.Controls.Primitives;
    using System;
    using DotNetSiemensPLCToolBoxLibrary.DataTypes;
    using System.Diagnostics;
    using System.Collections.Generic;

    public class ConnectionPLC
    {
        private readonly Plc? plc;
        private PLCConnection _plcConnection;

        public ConnectionPLC(string ipAdress)
        {
            var cfg = new PLCConnectionConfiguration
            {
                CpuIP = ipAdress,
                Port = 102,
                CpuRack = 0,
                CpuSlot = 1,
                TimeoutIPConnect = TimeSpan.FromSeconds(5),
                Timeout = TimeSpan.FromSeconds(5),
                ConnectionType = LibNodaveConnectionTypes.ISO_over_TCP,
                ConnectionName = "S7_Connection",
                Routing = false,
                RoutingDestinationRack = 0,
                RoutingDestinationSlot = 0,
                RoutingDestination = string.Empty,
            };

            cfg.SaveConfiguration();

            this._plcConnection = new PLCConnection(cfg);

            this._plcConnection.Connect();

            var testconnection = this._plcConnection.Connected;

            var bool1 = new PLCTag("DB1.DBX0.0", TagDataType.Bool) { Value = 0 };
            var bool2 = new PLCTag("DB1.DBX0.0", TagDataType.Bool) { Value = 0 };
            var db1IntVariable = new PLCTag("DB1.DBW2.0", TagDataType.Int) { Value = 51 };
            var db1RealVariable = new PLCTag("DB1.DBD4.0", TagDataType.Float) { Value = 25.40 };
            var db1DintVariable = new PLCTag("DB1.DBD8.0", TagDataType.Dint) { Value = 123451 };
            var db1DWordVariable = new PLCTag("DB1.DBD12.0", TagDataType.Dword) { Value = 123451 };
            var db1WordVariable = new PLCTag("DB1.DBW16.0", TagDataType.Word) { Value = 12341 };

            this._plcConnection.WriteValue(bool1);
            this._plcConnection.WriteValue(bool2);
            this._plcConnection.WriteValue(db1IntVariable);
            this._plcConnection.WriteValue(db1RealVariable);
            this._plcConnection.WriteValue(db1DintVariable);
            this._plcConnection.WriteValue(db1DWordVariable);
            this._plcConnection.WriteValue(db1WordVariable);

            this._plcConnection.ReadValue(bool1);
            this._plcConnection.ReadValue(bool2);
            this._plcConnection.ReadValue(db1IntVariable);
            this._plcConnection.ReadValue(db1RealVariable);
            this._plcConnection.ReadValue(db1DintVariable);
            this._plcConnection.ReadValue(db1DWordVariable);
            this._plcConnection.ReadValue(db1WordVariable);
            var test = 0;

        }

        public void DisconnectPLC()
        {
            this._plcConnection.Disconnect();
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
