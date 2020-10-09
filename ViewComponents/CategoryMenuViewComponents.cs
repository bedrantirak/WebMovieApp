using AppForMovie.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppForMovie.ViewComponents
{
    public class CategoryMenuViewComponents:ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View(CategoryRepository.Categories);
        }
    }
}