using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tasker
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskerService" in both code and config file together.
    [ServiceContract]
    public interface ITaskerService
    {
        [OperationContract]
        bool CreateTask(Task t);

        [OperationContract]
        bool EditTask(Task t);

        [OperationContract]
        bool FinishTask(int taskId);

        [OperationContract]
        string ShowTask(int taskId);

        [OperationContract]
        string GetTask(int priorityId);
    }
}
