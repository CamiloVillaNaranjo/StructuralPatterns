using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeApp.Devices
{
    public class Radio : IDevice
    {
        private bool state;
        private double channelNumber;
        private int volumeLevel;
        public void Disable()
        {
            state = false;
        }

        public void Enable()
        {
            state = true;
        }

        public double GetChannel()
        {
            return channelNumber;
        }

        public int GetVolume()
        {
            return volumeLevel;
        }

        public bool IsEnabled()
        {
            return state;
        }

        public void SetChannel(double value)
        {
            channelNumber = value;
        }

        public void SetVolume(int value)
        {
            volumeLevel = value;
        }

        public string Type() => "Radio";
    }
}
