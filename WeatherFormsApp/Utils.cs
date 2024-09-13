using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherFormsApp
{
    internal class Utils
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        public void ActAsFormBorder(Control sender)
        {
            ReleaseCapture();
            SendMessage(sender.Handle, 0x112, 0xf012, 0);
        }

    }
}
