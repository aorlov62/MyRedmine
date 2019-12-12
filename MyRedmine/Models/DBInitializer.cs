using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyRedmine.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            context.Tasks.Add(new Task()
            {
                Name = "ASP.NET MVC",
                Description = "Необходимо разобраться с ASP.NET MVC",
                AutorId = 1,
                AssignedToId = 1,
                Status = 1,
                Priority = 5,
                SpendTime = 0
            });

            context.Tasks.Add(new Task()
            {
                Name = "Приложение для тренировок",
                Description = "Разработать консольное приложение, которое будет через телеграмм бота генерить круговые тренировки",
                AutorId = 1,
                AssignedToId = 1,
                Status = 1,
                Priority = 5,
                SpendTime = 0
            });

            context.Tasks.Add(new Task()
            {
                Name = "Хостинг для сайтов на asp.net",
                Description = "Найти хостинг позволяющий развернуть сайт на asp.net",
                AutorId = 1,
                AssignedToId = 1,
                Status = 1,
                Priority = 3,
                SpendTime = 0
            });

            context.Users.Add(new User()
            {
                Name = "Орлов Алексей",
                HashOfPassword = "4397A09C4CB35E85A293B857C53C00CA",
                IsAdmin = 1
            });

            context.Users.Add(new User()
            {
                Name = "Маринов Владислав",
                HashOfPassword = "4397A09C4CB35E85A293B857C53C00CA",
                IsAdmin = 0
            });

            context.Users.Add(new User()
            {
                Name = "Юрьев Павел",
                HashOfPassword = "4397A09C4CB35E85A293B857C53C00CA",
                IsAdmin = 0
            });

            context.Statuses.Add(new Status() { Name = "Открыто" });
            context.Statuses.Add(new Status() { Name = "Закрыто" });

            context.Prioritys.Add(new Priority() { Name = "Low" });
            context.Prioritys.Add(new Priority() { Name = "Normal" });
            context.Prioritys.Add(new Priority() { Name = "High" });
            context.Prioritys.Add(new Priority() { Name = "Urgent" });
            context.Prioritys.Add(new Priority() { Name = "Immediately" });

            base.Seed(context);
        }
    }
}