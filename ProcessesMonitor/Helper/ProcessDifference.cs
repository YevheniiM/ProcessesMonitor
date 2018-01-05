using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessesMonitor.Helper
{
    // class to save the current state of all processes
    class ProcessDifference
    {
        public List<Process> Old { get; private set; }
        public List<Process> New { get; private set; }
        public List<Process> Finished { get; private set; }

        public ProcessDifference(List<Process> _old, List<Process> _new, List<Process> _finished)
        {
            this.Old = _old;
            this.New = _new;
            this.Finished = _finished;
        }
    }
}
