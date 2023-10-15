using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
eww{
    public abstract class Storage
    {

        public string mediaName { get; set; }
        public string Model { get; set; }
        public int mediaSize { get; set; }
        public int allMemory { get; set; }

        protected Storage(string mediaName, string model, int mediaSize, int allMemory)
        {
            this.mediaName = mediaName;
            Model = model;
            this.mediaSize = mediaSize;
            this.allMemory = allMemory;
        }

        public virtual void DownloadMedia()
        {
            Console.WriteLine("Medianin olcusu " + mediaSize);

            if (allMemory - mediaSize >= 0)
            {
                allMemory -= mediaSize;

            }

            else
            {
                Console.WriteLine("Sizin media yuklemeye bos yeriniz yoxdur");
            }

        }

        public virtual void Copy()
        {
            int calculate = allMemory / mediaSize;
            Console.WriteLine($"Sizin umumi yaddasiniz {allMemory}\nSizin medianizin olcusu{mediaSize}\n Bu yaddasa siz umumiyyetle {calculate} media yukleye bildiniz");
            allMemory /= mediaSize;
        }

        public virtual void showFreeMemory()
        {
            Console.WriteLine("Bos qalan yer " + allMemory);
        }

        public virtual void PrintDeviceInfo()
        {
            Console.WriteLine($"Medianin adi {mediaName}\nMedianin modeli {Model}\nMedianin olcusu {mediaSize}\nUmumi yaddas {allMemory}");
        }
    }
}
