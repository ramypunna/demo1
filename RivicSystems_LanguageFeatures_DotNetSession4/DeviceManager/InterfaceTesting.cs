using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceManager
{
    public abstract class RivicDevice
    {
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void TransmitSignal();
        public abstract int DisplayStatus();

    }

    public interface IRivicDevice
    {
        void SwitchOn();
        void SwitchOff();
        void TransmitSignal();
        int DisplayStatus();

    }

    public class AppleDevice : IRivicDevice
    {
        public int DisplayStatus()
        {
            return 0;
        }

        public void SwitchOff()
        {
            // Switch off device
        }

        public void SwitchOn()
        {
            //Switch on
        }

        public void TransmitSignal()
        {
           // Transmit signal
        }
    }

    public class AndroidDevice : IRivicDevice
    {
        public int DisplayStatus()
        {
            return 0;
        }

        public void SwitchOff()
        {
            // Switch off device
        }

        public void SwitchOn()
        {
            //Switch on
        }

        public void TransmitSignal()
        {
            // Transmit signal
        }
    }

}
