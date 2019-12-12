using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyRedmine.Models;

namespace MyRedmine.Controllers
{
    public class TaskController : Controller
    {
        TaskContext taskContext = new TaskContext();

        public ActionResult Index()
        {
            IEnumerable<Priority> prioritys = taskContext.Prioritys.ToList();
            IEnumerable<Status> statuses = taskContext.Statuses.ToList();
            IEnumerable<User> users = taskContext.Users.ToList();
            IEnumerable<Task> tasks = taskContext.Tasks.ToList();

            ViewBag.Prioritys = prioritys;
            ViewBag.Statuses = statuses;
            ViewBag.Users = users;
            ViewBag.Tasks = tasks;

            return View();
        }


        [HttpGet]
        public ActionResult Work(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            //TODO: После добавления авторизации - сделать получение текущего юзера
            int userId = 1;

            Task task = taskContext.Tasks
                                    .Where(b => b.Id == id)
                                    .FirstOrDefault();

            IEnumerable<Status> statuses = taskContext.Statuses.ToList();

            foreach (var status in statuses)
            {
                if (status.Id == task.Status)
                {
                    ViewBag.StatuseName = status.Name;
                }
            }

            IEnumerable<Priority> prioritys = taskContext.Prioritys.ToList();

            foreach (var priority in prioritys)
            {
                if (priority.Id == task.Priority)
                {
                    ViewBag.PriorityName = priority.Name;
                }
            }

            IEnumerable<User> users = taskContext.Users.ToList();

            foreach (var user in users)
            {
                if (user.Id == task.AssignedToId)
                {
                    ViewBag.UserName = user.Name;
                }
            }

            if (task != null)
            {
                ViewBag.Statuses = new SelectList(taskContext.Statuses, "Id", "Name");
                ViewBag.Prioritys = new SelectList(taskContext.Prioritys, "Id", "Name");
                ViewBag.Users = new SelectList(taskContext.Users, "Id", "Name");

                ViewBag.Task = task;

                Work work = new Work()
                {
                    AssignedToIdBefore = task.AssignedToId,
                    AssignedToIdAfter = task.AssignedToId,
                    PriorityBefore = task.Priority,
                    PriorityAfter = task.Priority,
                    StatusBefore = task.Status,
                    StatusAfter = task.Status,
                    TaskId = task.Id,
                    UserId = userId
                };

                return View(work);
            }
            return Redirect("/Task/Index/");
        }

        [HttpPost]
        public ActionResult Work(Work work)
        {
            taskContext.Works.Add(work);

            Task task = taskContext.Tasks
                                    .Where(b => b.Id == work.TaskId)
                                    .FirstOrDefault();

            task.AssignedToId = work.AssignedToIdAfter;
            task.Priority = work.PriorityAfter;
            task.Status = work.StatusAfter;

            taskContext.SaveChanges();

            return Redirect("/Task/Index/");
        }
    }
}