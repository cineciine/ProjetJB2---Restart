using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetJB2.Models
{
    public class ProjectStepTask
    {
        public Project Project { get; set; }
        public Step Step { get; set; }
        public Task Task { get; set; }

        public ProjectStepTask(Project p, Step s, Task t)
        {
            this.Project = p;
            this.Step = s;
            this.Task = t;
        }
    }

}