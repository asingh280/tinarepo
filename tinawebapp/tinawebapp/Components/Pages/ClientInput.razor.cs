using Microsoft.AspNetCore.Components;
using System;

namespace tinawebapp.Components.Pages
{
    public partial class ClientInput
    {
        private TaskModel task = new TaskModel { StartDate = DateTime.Today };

        public class TaskModel
        {
            public string EstimatedTime { get; set; }
            public DateTime StartDate { get; set; } = DateTime.Today;
            public DateTime DueDate { get; set; }
            public string Type { get; set; }
            public string Priority { get; set; }
            public string Description { get; set; }
        }
    }
}


