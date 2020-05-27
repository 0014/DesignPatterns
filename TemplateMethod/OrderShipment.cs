using System;
using System.IO;

namespace TemplateMethod
{
    public abstract class OrderShipment
    {
        public string ShippingAddress { get; set; }
        public string Label { get; set; }

        public abstract void GetShippingLabelFromCarrier();

        public void Ship(TextWriter writer)
        {
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            PrintLabel(writer);
        }

        public virtual void VerifyShippingData()
        {
            if (String.IsNullOrEmpty(ShippingAddress))
            {
                throw new ApplicationException("Invalid address.");
            }
        }

        public virtual void PrintLabel(TextWriter writer)
        {
            writer.Write(Label);
        }
    }
}
