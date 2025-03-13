namespace Blog.Controllers;

using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public AppDbContext Context { get; init; }
    public HomeController(AppDbContext ctx)
    {
        Context = ctx;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Post()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Edit()
    {
        return View(new Post());
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Post post)
    {
        Context.Add(post);
        await Context.SaveChangesAsync();
        return RedirectToAction("Index");
    }

}