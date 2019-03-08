using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Domains;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        public static readonly List<TaskItem> Tasks = new List<TaskItem>();

        public IActionResult Index()
        {
            return View(Tasks);
        }

        [HttpPost]
        public ActionResult Add(string task)
        {
            var taskItem = new TaskItem(task);
            Tasks.Add(taskItem);
            return RedirectToAction("Index");
        }
    }
}
