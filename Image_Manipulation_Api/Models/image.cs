namespace Image_Manipulation_Api.Models
{
    public class image
    {
        public int imglength { get; set; }

        public int imgwidth { get; set; }

        public string imgname { get; set; }

        public int blurpixalcount { get; set; }

        public int graypixalcount { get; set; }

        public string NormalImage { get; set; }

        public string WebPImage { get; set; }

    }
}
