

using System.Diagnostics.CodeAnalysis;

namespace murachProductManager.Models{
    internal sealed class Software : Product, WebPrintable
    {

        public string Version { get; set; }

        public Software(int id, string code, string description, decimal price, string version) :
            base(id, code, description, price)
        {
            Version = version;
        }

        public override string ToString()
        {
            return base.ToString() + $" , - {Version}";
        }

        public override void PrintToWeb()
        {
            ;
        }
    }

}
