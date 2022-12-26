using Microsoft.AspNetCore.Mvc;

public class NumberController: Controller
{
    public IActionResult Greet()
    {
        return View();
    }
}
