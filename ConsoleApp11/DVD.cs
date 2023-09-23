using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public class DVD : Storage
    {
        public DVD(string mediaName, string model, int mediaSize, int allMemory) : base(mediaName, model, mediaSize, allMemory)
        {
        }

        public override void Copy()
        {
            base.Copy();
        }

        public override void DownloadMedia()
        {
            base.DownloadMedia();
        }

        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();
        }
        public override void showFreeMemory()
        {
            base.showFreeMemory();
        }
    }
}