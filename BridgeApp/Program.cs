using BridgeApp.Bridge;
using BridgeApp.Controls;
using BridgeApp.Devices;
using System;

namespace BridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteTVSamsung = new RemoteSamsung(new Television());

            remoteTVSamsung.TogglePower();
            remoteTVSamsung.VolumeUp(50);
            remoteTVSamsung.ChannelUp(120);

            Console.WriteLine(remoteTVSamsung);

            remoteTVSamsung.TogglePower();
            Console.WriteLine(remoteTVSamsung);

            var remoteRadioDaewoo = new RemoteDaewoo(new Radio());

            remoteRadioDaewoo.TogglePower();
            remoteRadioDaewoo.ChannelUp(97.9);
            remoteRadioDaewoo.VolumeUp(15);

            Console.WriteLine(remoteRadioDaewoo);

            remoteRadioDaewoo.TogglePower();

            Console.WriteLine(remoteRadioDaewoo);

            Console.ReadLine();
        }
    }
}
