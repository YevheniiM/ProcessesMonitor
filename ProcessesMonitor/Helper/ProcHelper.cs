using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessesMonitor.Helper
{
    // auxiliary class for storing the status of processes in the dictionary
    public class PInfo
    {
        public bool fromOld = false;
        public bool fromNew = false;
        public PInfo(bool v1, bool v2)
        {
            this.fromOld = v1;
            this.fromNew = v2;
        }
    }

    class ProcHelper
    {
        private List<Process> _last = new List<Process>();
        public List<Process> CurrentProcesses { get; set; }

        public ProcHelper()
        {
            CurrentProcesses = new List<Process>();
        }

        // the function updates current list of active processes
        private void UpdateCurrentProcesses()
        {
            CurrentProcesses.Clear();
            foreach (var p in Process.GetProcesses())
            {
                CurrentProcesses.Add(p);
            }
        }

        public void Update()
        {
            _last = CurrentProcesses;
            CurrentProcesses = new List<Process>();
            UpdateCurrentProcesses();
        }

        public ProcessDifference Diff()
        {
            var Old = new List<Process>();
            var New = new List<Process>();
            var Finished = new List<Process>();

            // dictionary to save process id + information about life expectancy
            var infos = new Dictionary<int, PInfo>();
            // set all current processes are new
            foreach (var p in CurrentProcesses)
                infos[p.Id] = new PInfo(false, true);

            // if there is a process from last step, it's old
            foreach (var p in _last)
            {
                if (!infos.ContainsKey(p.Id))
                    infos[p.Id] = new PInfo(true, false);
                infos[p.Id].fromOld = true;
            }

            // split up all processes into old, new and finished groups
            foreach (var infoPair in infos)
            {
                var proc = _last.Concat(CurrentProcesses).First(x => x.Id == infoPair.Key);
                if (infoPair.Value.fromNew & infoPair.Value.fromOld)
                    Old.Add(proc);
                else
                    if (infoPair.Value.fromNew & !infoPair.Value.fromOld)
                    New.Add(proc);
                else
                    Finished.Add(proc);
            }

            return new ProcessDifference(Old, New, Finished);
        }
    }
}
