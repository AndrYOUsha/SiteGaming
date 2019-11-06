using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteGaming.Models
{
    public class Support
    {
        public string[] GetImages(string pathToRoot, string picturePath)
        {
            string[] array = System.IO.Directory.GetFiles(pathToRoot + picturePath);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].TrimStart(pathToRoot.ToCharArray());
            }

            return array;
        }
    }
}
