using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW4_Generics_and_Interfaces
{
    enum MediaType { Audio, Video, Image } 
    abstract class IMedia
    {
        public string Path { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public MediaType MediaType { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
