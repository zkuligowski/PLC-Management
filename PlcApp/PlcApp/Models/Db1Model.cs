// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    public class Db1Model
    {
        public bool Bool1 { get; set; }

        public short IntVariable { get; set; }

        public double RealVariable { get; set; }

        public int DIntVariable { get; set; }

        public int DWordVariable { get; set; }

        public ushort WordVariable { get; set; }

        public Db1Model(bool bool1, short intVariable, double realVariable, int dIntVariable, int dWordVariable, ushort wordVariable)
        {
            this.Bool1 = bool1;
            this.IntVariable = intVariable;
            this.RealVariable = realVariable;
            this.DIntVariable = dIntVariable;
            this.DWordVariable = dWordVariable;
            this.WordVariable = wordVariable;
        }
    }
}
