using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeApp.Devices
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int value);
        double GetChannel();
        void SetChannel(double value);
        string Type();
    }
}
