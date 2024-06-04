using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this class is used to set an image for an item (such as a picture of a steak, salad, etc) using a URL link
//if it fails, a default image is set.
namespace OrderingSystem
{
    class SetImage
    {
        public static void CheckAndSetImage(ref PictureBox picture, string imageLink)
        {
            //try to get image from web
            try
            {
                var request = WebRequest.Create(imageLink);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    picture.Image = Bitmap.FromStream(stream);
                }
            }

            //this is thrown if the url is not a valid link
            catch (Exception ex)
            {
                if (ex is System.Net.WebException || ex is System.UriFormatException)
                {
                    //try to show the NO IMAGE from web
                    try
                    {
                        var request = WebRequest.Create(GlobalData.IMAGEFAILED);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            picture.Image = Bitmap.FromStream(stream);

                        }
                    }

                    //if not just show the initial image
                    catch (Exception except)
                    {
                        if (except is System.Net.WebException || except is System.UriFormatException)
                            picture.Image = picture.InitialImage;
                    }
                }
            }
        }

       
        
    }
}
