using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3020_HW4_Generics_and_Interfaces
{
    class GenericCollection<T> : IEnumerable<T> where T : IMedia
    {
        List<T> medias = new List<T>();

        public GenericCollection() { }

        public IEnumerator<T> GetEnumerator()
        {
            return medias.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enqueue(int index, T val)
        {
            medias.Insert(index, val);
        }

        public void EmptyList()
        {
            medias.Clear();
        }

        public void PrintLibary()
        {
            Console.WriteLine("Index\tFile Name\tFile Extension\tDate Last Accessed");
            int index = 0;
            foreach (T media in medias)
            {
                Console.WriteLine(index + "\t" + media.FileName + "\t" + media.FileType + "\t" + media.DateAdded);
                index++;
            }
        }

        public void SortByName()
        {
            medias = medias.OrderBy(t => t.FileName).ToList();
        }

        public void SortByExtension()
        {
            medias = medias.OrderBy(t => t.FileType).ToList();
        }

        public void SortByDateLastAccessed()
        {
            medias = medias.OrderBy(t => t.DateAdded).ToList();
        }

        public void TouchFile(int userIndex)
        {
            medias[userIndex].DateAdded = DateTime.Now;
        }

        public void RemoveFile(int userIndex)
        {
            medias.RemoveAt(userIndex);
        }

        public void AudioLibrary()
        {
            medias = medias.Where(t => t.MediaType == MediaType.Audio).ToList();
        }

        public void VideoLibrary()
        {
            medias = medias.Where(t => t.MediaType == MediaType.Video).ToList();
        }

        public void ImageLibrary()
        {
            medias = medias.Where(t => t.MediaType == MediaType.Image).ToList();
        }
    }
}
