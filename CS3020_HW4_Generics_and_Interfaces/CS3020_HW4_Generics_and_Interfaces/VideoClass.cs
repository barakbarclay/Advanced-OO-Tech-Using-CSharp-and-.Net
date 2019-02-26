﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS3020_HW4_Generics_and_Interfaces
{
    class VideoClass : IMedia
    {
        public VideoClass(string path, string fileName, string fileType)
        {
            this.Path = path;
            this.FileType = fileType;
            this.FileName = fileName;
            this.MediaType = MediaType.Video;
            this.DateAdded = File.GetLastWriteTime(@path);
        }
    }
}
