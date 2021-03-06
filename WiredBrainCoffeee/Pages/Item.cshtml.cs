using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ItemModel : PageModel
    {
        public MenuItem Item { get; set; }

        public void OnGet(int id)
        {
            var menuService = new MenuService();
            Item = menuService.GetMenuItems().FirstOrDefault(x => x.Id == id);
        }
    }
}
