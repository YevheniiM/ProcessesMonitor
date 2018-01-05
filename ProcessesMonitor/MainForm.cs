using ProcessesMonitor.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ProcessesMonitor
{
    public partial class MainForm : Form
    {
        private Thread AllProcesses_thread;
        private Thread IDProceses_thread;
        private Thread checkSelectedProcesses_thread;
        private List<Process> selectedActiveProcesses;
        private List<Process> selectedNonActiveProcesses;

        public MainForm()
        {
            InitializeComponent();
            selectedActiveProcesses = new List<Process>();
            selectedNonActiveProcesses = new List<Process>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // statring all program threads
            AllProcesses_thread = new Thread(new ThreadStart(FillAllProcesses_LB)) { IsBackground = true };
            IDProceses_thread = new Thread(new ThreadStart(Fill_CB_ProcessID)) { IsBackground = true };
            checkSelectedProcesses_thread = new Thread(new ThreadStart(CheckSelectedProcesses)) { IsBackground = true };
            AllProcesses_thread.Start();
            IDProceses_thread.Start();
            checkSelectedProcesses_thread.Start();
        }

        private void BUT_Close_Click(object sender, EventArgs e)
        {
            // aborting all program threads
            AllProcesses_thread.Abort();
            IDProceses_thread.Abort();
            checkSelectedProcesses_thread.Abort();
            Application.Exit();
            this.Close();
        }

        private void BUT_AddProcess_Click(object sender, EventArgs e)
        {
            ProcHelper _procHelper = new ProcHelper();
            // update current processes
            _procHelper.Update();
            bool isProcessActive = false;

            if (CB_ProcessID.SelectedItem == null)
            {
                if (TB_ProcessName.Text == String.Empty) // if data is incorrect
                    MessageBox.Show("Please, enter correct values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // loop for all the processes and place their names into listbox
                    foreach (var p in _procHelper.CurrentProcesses)
                        if (p.ProcessName == TB_ProcessName.Text && !selectedActiveProcesses.Exists(proc => proc.Id == p.Id))
                        {
                            selectedActiveProcesses.Add(p);
                            LB_SelectedActiveProcesses.Items.Add(String.Format("{0} ({1})", selectedActiveProcesses.Last().ProcessName, selectedActiveProcesses.Last().Id));
                            isProcessActive = true;
                        }
                    if (!isProcessActive) // if process wasn't found
                        MessageBox.Show("Please, enter correct values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // if user has selected process id
            {
                foreach (var p in _procHelper.CurrentProcesses)
                    // find according the id
                    if (p.Id == int.Parse(CB_ProcessID.SelectedItem.ToString()) && !selectedActiveProcesses.Exists(proc => proc.Id == p.Id))
                    {
                        selectedActiveProcesses.Add(p);
                        // adding to listbox
                        LB_SelectedActiveProcesses.Items.Add(String.Format("{0} ({1})", selectedActiveProcesses.Last().ProcessName, selectedActiveProcesses.Last().Id));
                    }
            }
            // clear data, which user has entered
            SetDeafult();
        }

        private void CheckSelectedProcesses()
        {
            ProcHelper _procHelper = new ProcHelper();
            ProcessDifference diff;

            while (true)
            {
                _procHelper.Update();
                diff = _procHelper.Diff();

                if(selectedActiveProcesses.Count > 0)
                    CheckSelectedActiveProcesses();
                if(selectedNonActiveProcesses.Count > 0)
                    CheckSelectedNonActiveProcesses();

                // if there is no one new or finished process - do nothing
                while (diff.New.Count == 0 && diff.Finished.Count == 0)
                {
                    _procHelper.Update();
                    diff = _procHelper.Diff();
                    continue;
                }
            }
        }
        
        private void CheckSelectedActiveProcesses()
        {
            ProcHelper _procHelper = new ProcHelper();
            _procHelper.Update();

            // if there are some processes in the active list, but they are not in current - they are finished
            foreach (var p in selectedActiveProcesses)
                if (!_procHelper.CurrentProcesses.Exists(proc => proc.Id == p.Id))
                    selectedNonActiveProcesses.Add(p);

            // updating list of active processes and show information about finished
            foreach (var p in selectedNonActiveProcesses)
                if (selectedActiveProcesses.Exists(proc => proc.Id == p.Id))
                {
                    selectedActiveProcesses.Remove(p);
                    MessageBox.Show(String.Format("Process {0} ({1}) has finished", p.ProcessName, p.Id));
                    UpdateActiveProcesses_LB(selectedActiveProcesses);
                }
        }

        private void CheckSelectedNonActiveProcesses()
        {
            ProcHelper _procHelper = new ProcHelper();
            _procHelper.Update();

            // updating non-active processes list
            foreach (var p in selectedNonActiveProcesses)
                UpdateNonActiveProcesses_LB(selectedNonActiveProcesses);
        }

        private void UpdateActiveProcesses_LB(List<Process> procList)
        {
            // the function updates active processes list
            LB_SelectedActiveProcesses.Invoke(new Action(() => LB_SelectedActiveProcesses.Items.Clear()));
            foreach (var p in procList)
            {
                // add the name of process to the list
                LB_SelectedActiveProcesses.Invoke(new Action(() => LB_SelectedActiveProcesses.Items.Add(String.Format("Process started: {0} ({1})", p.ProcessName, p.Id))));
                // change selected index (to autoscroll the listbox)
                LB_SelectedActiveProcesses.Invoke(new Action(() => LB_SelectedActiveProcesses.SelectedIndex = LB_SelectedActiveProcesses.Items.Count - 1));
            }
        }

        private void UpdateNonActiveProcesses_LB(List<Process> procList)
        {
            // the function updates non-active processes list
            LB_SelectedNonActiveProcesses.Invoke(new Action(() => LB_SelectedNonActiveProcesses.Items.Clear()));
            foreach (var p in procList)
            {
                // add the name of process to the list
                LB_SelectedNonActiveProcesses.Invoke(new Action(() => LB_SelectedNonActiveProcesses.Items.Add(String.Format("Process finished: {0} ({1})", p.ProcessName, p.Id))));
                // change selected index (to autoscroll the listbox)
                LB_SelectedNonActiveProcesses.Invoke(new Action(() => LB_SelectedNonActiveProcesses.SelectedIndex = LB_SelectedNonActiveProcesses.Items.Count - 1));
            }
        }

        private void FillAllProcesses_LB()
        {
            ProcHelper _procHelper = new ProcHelper();
            ProcessDifference diff = _procHelper.Diff();
            bool alreadyUpdated = false;

            while (true)
            {
                if (!alreadyUpdated)
                {
                    _procHelper.Update();
                    diff = _procHelper.Diff();
                    
                }
                alreadyUpdated = false;
                // updating all processes listbox
                LB_AllProcesses.Invoke(new Action(() => LB_AllProcesses.Items.Clear()));
                foreach (var process in _procHelper.CurrentProcesses)
                    LB_AllProcesses.Invoke(new Action(() => LB_AllProcesses.Items.Add(String.Format("{0} ({1})", process.ProcessName, process.Id))));

                // if there are some new processes, show them
                if (diff.New.Count > 0 && (diff.New.Count < diff.Old.Count))
                    foreach (var p in diff.New)
                        LB_AllProcessesInfo.Invoke(new Action(() => LB_AllProcessesInfo.Items.Add(String.Format("Process started: {0} ({1})", p.ProcessName, p.Id))));

                // if there are some finished processes, show them
                if (diff.Finished.Count > 0)
                    foreach (var p in diff.Finished)
                            LB_AllProcessesInfo.Invoke(new Action(() => LB_AllProcessesInfo.Items.Add(String.Format("Process finished: {0} ({1})", p.ProcessName, p.Id))));

                // if there is no one new or finished - do nothing
                while (diff.New.Count == 0 && diff.Finished.Count == 0)
                {
                    _procHelper.Update();
                    diff = _procHelper.Diff();
                    alreadyUpdated = true;
                    continue;
                }
                // change selected index (for autoscroll)
                LB_AllProcessesInfo.Invoke(new Action(() => LB_AllProcessesInfo.SelectedIndex = LB_AllProcessesInfo.Items.Count - 1));
            }
        }

        private void Fill_CB_ProcessID()
        {
            ProcHelper _procHelper = new ProcHelper();
            ProcessDifference diff;

            while (true)
            {
                _procHelper.Update();
                diff = _procHelper.Diff();
                CB_ProcessID.Invoke(new Action(() => CB_ProcessID.Items.Clear()));

                // fill combobox with processes ids
                foreach (var p in _procHelper.CurrentProcesses)
                    CB_ProcessID.Invoke(new Action(() => CB_ProcessID.Items.Add(p.Id)));

                while (diff.New.Count == 0 && diff.Finished.Count == 0)
                {
                    _procHelper.Update();
                    diff = _procHelper.Diff();
                    continue;
                }
            }
        }

        private void CB_ProcessID_SelectedIndexChanged(object sender, EventArgs e)  
        {
            ProcHelper _procHelper = new ProcHelper();
            _procHelper.Update();

            // if user selected some process by id, print its name to the textbox
            foreach (var p in _procHelper.CurrentProcesses)
            {
                if (CB_ProcessID.SelectedItem == null)
                    break;
                if (CB_ProcessID.SelectedItem.ToString() == p.Id.ToString())
                    TB_ProcessName.Text = p.ProcessName;
            }
        }

        private void SetDeafult()
        {
            // set data, which user has entered to default values
            TB_ProcessName.Text = String.Empty;
            CB_ProcessID.SelectedItem = null;
        }
    }
}