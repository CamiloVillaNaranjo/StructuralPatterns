using BridgeApp.Bridge;
using BridgeApp.Devices;

namespace BridgeApp.Controls
{
    public class RemoteSamsung : Remote
    {
        public RemoteSamsung(IDevice device):base(device){}

        public override void ChannelDown(double channel = 0)
        {
            var oldChannel = device.GetChannel();
            if (oldChannel - channel > 0)
                device.SetChannel(oldChannel - channel);
            else
                device.SetChannel(0);
        }

        public override void ChannelUp(double channel = 0)
        {
            var oldChannel = device.GetChannel();
            if (oldChannel + channel < 100)
                device.SetChannel(oldChannel + channel);
            else
                device.SetChannel(100);
        }

        public override void TogglePower()
        {
            if (device.IsEnabled())
            {
                device.Disable();
                if (device.Type() == "Radio")
                    device.SetChannel(86.0);
                else
                    device.SetChannel(1);
                device.SetVolume(0);
            }
            else
                device.Enable();
        }

        public override void VolumeDown(int volume = 0)
        {
            var oldVolume = device.GetVolume();
            if (oldVolume - volume > 0)
                device.SetVolume(oldVolume - volume);
            else
                device.SetVolume(0);
        }

        public override void VolumeUp(int volume = 0)
        {
            var oldVolume = device.GetVolume();
            if (oldVolume + volume < 100)
                device.SetVolume(oldVolume + volume);
            else
                device.SetVolume(100);
        }
    }
}
