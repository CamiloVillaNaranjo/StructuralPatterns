using BridgeApp.Devices;

namespace BridgeApp.Bridge
{
    public abstract class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public abstract void TogglePower();

        public abstract void VolumeUp(int volume = 0);

        public abstract void VolumeDown(int volume = 0);

        public abstract void ChannelUp(double channel = 0);

        public abstract void ChannelDown(double channel = 0);

        public override string ToString()
        {
            var status = device.IsEnabled() ? "ON" : "OFF";
            var typeChannel = (device.Type() == "Radio" ? "Frequency" : "Channel");
            return $"Device {device.Type()} is ON/OFF: { status }, current Volume: {device.GetVolume()}, current {typeChannel}: {device.GetChannel()}";
        }
    }
}
