using System;
using System.Collections.Generic;
using System.Text;

namespace OOT
{
    class PhotoAlbumTarea
    {
        class PhotoAlbum
        {
            protected int numberOfPages;

            public PhotoAlbum()
            {
                numberOfPages = 16;
            }

            public PhotoAlbum(int numberOfPages)
            {
                this.numberOfPages = numberOfPages;
            }

            public int GetNumberOfPages()
            {
                return numberOfPages;
            }
        }

        class BigPhotoAlbum : PhotoAlbum
        {
            public BigPhotoAlbum()
            {
                numberOfPages = 64;
            }
        }

        class AlbumTest
        {
            static void Main()
            {
                bool debug = false;

                PhotoAlbum myAlbum1 = new PhotoAlbum();
                Console.WriteLine(myAlbum1.GetNumberOfPages());

                PhotoAlbum myAlbum2 = new PhotoAlbum(24);
                Console.WriteLine(myAlbum2.GetNumberOfPages());

                BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
                Console.WriteLine(myBigPhotoAlbum1.GetNumberOfPages());

                if (debug)
                    Console.ReadLine();
            }
        }
    }

}
