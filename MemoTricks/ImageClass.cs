using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MemoTricks
{
    class ImageClass
    {
        public Image ReturnImage(int _image)
        {
             Image img = new Bitmap(250 , 160);
            #region
            switch (_image)
            {
                case 1:
                    {
                        img = Imagini1._1_img;
                        break;
                    }
                case 2:
                    {
                        img = Imagini1._2_img;
                        break;
                    }
                case 3:
                    {
                        img = Imagini1._3_img;
                        break;
                    }
                case 4:
                    {
                        img = Imagini1._4_img;
                        break;
                    }
                case 5:
                    {
                        img = Imagini1._5_img;
                        break;
                    }
                case 6:
                    {
                        img = Imagini1._6_img;
                        break;
                    }
                case 7:
                    {
                        img = Imagini1._7_img;
                        break;
                    }
                case 8:
                    {
                        img = Imagini1._8_img;
                        break;
                    }
                case 9:
                    {
                        img = Imagini1._9_img;
                        break;
                    }
                case 10:
                    {
                        img = Imagini1._10_img;
                        break;
                    }

            }
            #endregion
            return img;
        }
        public Bitmap CropImage(Bitmap sourceImage,int x, int y, int width, int height)
        {
            Rectangle cropRect = new Rectangle(x, y, width, height);
             sourceImage = Imagini2.loci_house;
            Bitmap returnImage = sourceImage.Clone(cropRect, sourceImage.PixelFormat);

            return returnImage;
        }

        public Bitmap SetHouseImage(int location)
        {
            int space1 = 35;
            int space2 = 35;
            switch(location)
            {
              case 1:
              {
                 return CropImage(Imagini2.loci_house, 890 - space1, 1085 - space1, 540 + space2, 400 + space2);
              }
              case 2:
              {
                  return CropImage(Imagini2.loci_house, 600 - space1, 1085 - space1, 295 + space2, 395 + space2);
              }
              case 3:
              {
                  return CropImage(Imagini2.loci_house, 250 - space1, 1085 - space1, 365 + space2, 395 + space2);
              }
              case 4:
              {
                  return CropImage(Imagini2.loci_house, 1005 - space1, 730 - space1, 430 + space2, 355 + space2);
              }
              case 5:
              {
                  return CropImage(Imagini2.loci_house, 620 - space1, 730 - space1, 390 + space2, 355 + space2);
              }
              case 6:
              {
                  return CropImage(Imagini2.loci_house, 235 - space1, 730 - space1, 410 + space2, 355 + space2);
              }
              case 7:
              {
                  return CropImage(Imagini2.loci_house, 845 - space1, 445 - space1, 475 + space2, 300 + space2);
              }
              case 8:
              {
                  return CropImage(Imagini2.loci_house, 400 - space1, 430 - space1, 440 + space2, 300 + space2);
              }
              
            }
            return null;
        }
    }
}
