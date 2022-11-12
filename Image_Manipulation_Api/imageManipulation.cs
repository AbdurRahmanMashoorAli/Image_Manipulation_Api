using Image_Manipulation_Api.Controllers;
using Image_Manipulation_Api.Models;

namespace Image_Manipulation_Api
{
    public class imageManipulation
    {
        /*public int imglength;
        public int imgwidth;
        public int pixalcount;

        public void EditImg()
        {
            imgResize( imglength, imgwidth);
            imgBlur( pixalcount);
            imgGrayscale( pixalcount);
        }

        public void imgResize(int imglength, int imgwidth)
        {

        }

        public void imgBlur(int pixalcount)
        {

        }

        public void imgGrayscale(int pixalcount)
        {

        }*/
        public void UploadFile(object sender, EventArgs e, object server, string fileuplod)
        {
            string folderPath = server.MapPath("~/Images/");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            switch (fileuplod)
            {
                case fileupload1:
                    fileupload1.SaveAs(folderPath + Path.GetFileName(fileupload1.FileName));

                    image1.ImageUrl = "~/Image/" + Path.GetFileName(fileupload1.FileName);
                    break;
                case fileupload2:
                    fileupload1.SaveAs(folderPath + Path.GetFileName(fileupload1.FileName));

                    image2.ImageUrl = "~/Image/" + Path.GetFileName(fileupload1.FileName);
                    break;
                case fileupload3:
                    fileupload1.SaveAs(folderPath + Path.GetFileName(fileupload1.FileName));

                    image3.ImageUrl = "~/Image/" + Path.GetFileName(fileupload1.FileName);
                    break;
            }

        }
    }
}