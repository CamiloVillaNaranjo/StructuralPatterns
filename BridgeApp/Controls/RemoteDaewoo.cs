using BridgeApp.Bridge;
using BridgeApp.Devices;

namespace BridgeApp.Controls
{
    public class RemoteDaewoo : Remote
    {
        public RemoteDaewoo(IDevice device) : base(device) { }

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
                device.SetChannel(88.9);
                device.SetVolume(0);
            }
            else
                device.Enable();
        }

        public override void VolumeDown(int volume = 0)
        {
            var oldVolume = device.GetVolume();
            if (volume > 0)
                device.SetVolume(volume - 1);
            else
                device.SetVolume(0);
        }

        public override void VolumeUp(int volume = 0)
        {
            var oldVolume = device.GetVolume();
            if (volume < 100)
                device.SetVolume(volume + 1);
            else
                device.SetVolume(100);
        }
    }
}
