using Microsoft.AspNetCore.Mvc;
using Image_Manipulation_Api.Models;

namespace Image_Manipulation_Api.Controllers
{
    public class imageController : Controller
    {
        public object imglength { get; private set; }
        public object imgwidth { get; private set; }
        public object blurpixalcount { get; private set; }
        public object graypixalcount { get; private set; }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult imgResize(image model)
        {
            if (ModelState.IsValid)
            {
                imgResize( imglength, imgwidth);
            }
            return View(model);
        }

        private void imgResize(object imglength, object imgwidth)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult imgBlur(image model)
        {
            if (ModelState.IsValid)
            {
                imgBlur(blurpixalcount);
            }
            return View(model);
            
        }

        private void imgBlur(object blurpixalcount)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult imgGrayscale(image model)
        {
            if (ModelState.IsValid)
            {
                imgGrayscale(graypixalcount);
            }
            return View(model);
        }

        private void imgGrayscale(object graypixalcount)
        {
            throw new NotImplementedException();
        }

    }
}
