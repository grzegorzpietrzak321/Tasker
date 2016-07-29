using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tasker
{
    [DataContract]
    public class Task
    {
        [Key]
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public int priority { get; set; }
        
        [DataMember]
        public DateTime deadlineDate { get; set; }

        [DataMember]
        public bool isFinished { get; set; }

        [DataMember]
        public DateTime CreateDate;
        public Task(string name, string description, int priority, DateTime deadlineDate)
        {
            this.name = name;
            this.description = description;
            this.priority = priority;
            this.deadlineDate = deadlineDate;
        }

        public Task()
        {
            
        }
    }
}