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
        int id { get; set; }

        [DataMember]
        string name { get; set; }

        [DataMember]
        string description { get; set; }

        [DataMember]
        int priority { get; set; }

        
        DateTime createDate;

        [DataMember]
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = DateTime.Now; }
        }

        [DataMember]
        DateTime deadlineDate { get; set; }

        bool isFinished = false;

        [DataMember]
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }
    }
}