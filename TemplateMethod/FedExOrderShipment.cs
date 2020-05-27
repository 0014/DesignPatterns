namespace TemplateMethod
{
    public class FedExOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            Label = $"FedEx:[{ShippingAddress}]";
        }
    }
}
