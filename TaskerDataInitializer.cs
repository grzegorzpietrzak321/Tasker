using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tasker
{
    public class TaskerDataInitializer :DropCreateDatabaseIfModelChanges<TaskerDataModel>
    {
        protected override void Seed(TaskerDataModel contextTaskerDataModel)
        {
            IList<Task> tasks = new List<Task>();
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 1", id = 1, isFinished = false, name = "zadanie 1", priority = 0});
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 12", id = 2, isFinished = false, name = "zadanie 12", priority = 1 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 13", id = 3, isFinished = false, name = "zadanie 13", priority = 2 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 14", id = 4, isFinished = false, name = "zadanie 14", priority = 2 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 15", id = 5, isFinished = false, name = "zadanie 15", priority = 2 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 16", id = 6, isFinished = false, name = "zadanie 16", priority = 1 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 17", id = 7, isFinished = false, name = "zadanie 17", priority = 0 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 18", id = 8, isFinished = false, name = "zadanie 18", priority = 3 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 19", id = 9, isFinished = false, name = "zadanie 19", priority = 0 });
            tasks.Add(new Task() { CreateDate = DateTime.Now, deadlineDate = DateTime.Now, description = "opis 20", id = 10, isFinished = false, name = "zadanie 20", priority = 0 });

            foreach (Task task in tasks)
            {
                contextTaskerDataModel.Tasks.Add(task);
            }

            base.Seed(contextTaskerDataModel);
        }
    }
}