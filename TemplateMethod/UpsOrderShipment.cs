namespace TemplateMethod
{
    public class UpsOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            Label = $"UPS:[{ShippingAddress}]";
        }
    }
}
