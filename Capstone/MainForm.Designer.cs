using System.Windows.Forms;

namespace Capstone
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Hidding = new System.Windows.Forms.CheckBox();
            this.FindCopyPath = new System.Windows.Forms.Button();
            this.CopyPathBox = new System.Windows.Forms.TextBox();
            this.CopyPath = new System.Windows.Forms.Label();
            this.Backgrounding = new System.Windows.Forms.CheckBox();
            this.ProgramSuspend = new System.Windows.Forms.Button();
            this.PasswordRequired = new System.Windows.Forms.CheckBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SecureIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BackgroundIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsecureIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SetPassword = new System.Windows.Forms.Button();
            this.BackgroundIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hidding
            // 
            this.Hidding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hidding.AutoSize = true;
            this.Hidding.Checked = true;
            this.Hidding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Hidding.Location = new System.Drawing.Point(15, 44);
            this.Hidding.Name = "Hidding";
            this.Hidding.Size = new System.Drawing.Size(451, 20);
            this.Hidding.TabIndex = 12;
            this.Hidding.Text = "파일 숨기기(복사되는 파일과 저장되는 폴더를 숨깁니다)";
            this.Hidding.UseVisualStyleBackColor = true;
            // 
            // FindCopyPath
            // 
            this.FindCopyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindCopyPath.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindCopyPath.Location = new System.Drawing.Point(395, 12);
            this.FindCopyPath.Name = "FindCopyPath";
            this.FindCopyPath.Size = new System.Drawing.Size(104, 26);
            this.FindCopyPath.TabIndex = 11;
            this.FindCopyPath.Text = "찾아보기...";
            this.FindCopyPath.UseVisualStyleBackColor = true;
            this.FindCopyPath.Click += new System.EventHandler(this.FindCopyPath_Click);
            // 
            // CopyPathBox
            // 
            this.CopyPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyPathBox.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CopyPathBox.Location = new System.Drawing.Point(98, 12);
            this.CopyPathBox.Name = "CopyPathBox";
            this.CopyPathBox.Size = new System.Drawing.Size(291, 26);
            this.CopyPathBox.TabIndex = 10;
            this.CopyPathBox.Text = "C:\\GTU";
            // 
            // CopyPath
            // 
            this.CopyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyPath.AutoSize = true;
            this.CopyPath.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CopyPath.Location = new System.Drawing.Point(12, 17);
            this.CopyPath.Name = "CopyPath";
            this.CopyPath.Size = new System.Drawing.Size(80, 16);
            this.CopyPath.TabIndex = 9;
            this.CopyPath.Text = "복사 위치";
            this.CopyPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backgrounding
            // 
            this.Backgrounding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backgrounding.AutoSize = true;
            this.Backgrounding.Location = new System.Drawing.Point(15, 71);
            this.Backgrounding.Name = "Backgrounding";
            this.Backgrounding.Size = new System.Drawing.Size(467, 20);
            this.Backgrounding.TabIndex = 13;
            this.Backgrounding.Text = "백그라운드 모드(창을 닫아도 프로그램이 계속 실행됩니다)";
            this.Backgrounding.UseVisualStyleBackColor = true;
            this.Backgrounding.Click += new System.EventHandler(this.Backgrounding_Click);
            // 
            // ProgramSuspend
            // 
            this.ProgramSuspend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramSuspend.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProgramSuspend.Location = new System.Drawing.Point(12, 128);
            this.ProgramSuspend.Name = "ProgramSuspend";
            this.ProgramSuspend.Size = new System.Drawing.Size(487, 26);
            this.ProgramSuspend.TabIndex = 11;
            this.ProgramSuspend.Text = "파일 훔치기 일시 정지";
            this.ProgramSuspend.UseVisualStyleBackColor = true;
            this.ProgramSuspend.Click += new System.EventHandler(this.ProgramSuspend_Click);
            // 
            // PasswordRequired
            // 
            this.PasswordRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordRequired.AutoSize = true;
            this.PasswordRequired.Enabled = false;
            this.PasswordRequired.Location = new System.Drawing.Point(15, 98);
            this.PasswordRequired.Name = "PasswordRequired";
            this.PasswordRequired.Size = new System.Drawing.Size(171, 20);
            this.PasswordRequired.TabIndex = 14;
            this.PasswordRequired.Text = "프로그램 실행 암호";
            this.PasswordRequired.UseVisualStyleBackColor = true;
            this.PasswordRequired.Click += new System.EventHandler(this.PasswordRequired_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordBox.Enabled = false;
            this.PasswordBox.Location = new System.Drawing.Point(192, 96);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.Size = new System.Drawing.Size(253, 26);
            this.PasswordBox.TabIndex = 15;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            // 
            // SecureIcon
            // 
            this.SecureIcon.ContextMenuStrip = this.BackgroundIconMenu;
            this.SecureIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SecureIcon.Icon")));
            this.SecureIcon.Text = "SecureEnabled";
            this.SecureIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SecureIcon_MouseDoubleClick);
            // 
            // BackgroundIconMenu
            // 
            this.BackgroundIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.BackgroundIconMenu.Name = "contextMenuStrip1";
            this.BackgroundIconMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // InsecureIcon
            // 
            this.InsecureIcon.ContextMenuStrip = this.BackgroundIconMenu;
            this.InsecureIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("InsecureIcon.Icon")));
            this.InsecureIcon.Text = "SecureDisabled";
            this.InsecureIcon.Visible = true;
            this.InsecureIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InsecureIcon_MouseDoubleClick);
            // 
            // SetPassword
            // 
            this.SetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPassword.Enabled = false;
            this.SetPassword.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetPassword.Location = new System.Drawing.Point(451, 96);
            this.SetPassword.Name = "SetPassword";
            this.SetPassword.Size = new System.Drawing.Size(48, 26);
            this.SetPassword.TabIndex = 11;
            this.SetPassword.Text = "설정";
            this.SetPassword.UseVisualStyleBackColor = true;
            this.SetPassword.Click += new System.EventHandler(this.SetPassword_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ProgramSuspend;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 166);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordRequired);
            this.Controls.Add(this.Backgrounding);
            this.Controls.Add(this.Hidding);
            this.Controls.Add(this.ProgramSuspend);
            this.Controls.Add(this.SetPassword);
            this.Controls.Add(this.FindCopyPath);
            this.Controls.Add(this.CopyPathBox);
            this.Controls.Add(this.CopyPath);
            this.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Grand Theft USB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Before_MainFormClose);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.After_MainFormClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackgroundIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox Hidding;
        private System.Windows.Forms.Button FindCopyPath;
        private System.Windows.Forms.TextBox CopyPathBox;
        private System.Windows.Forms.Label CopyPath;
        private System.Windows.Forms.CheckBox Backgrounding;
        private System.Windows.Forms.Button ProgramSuspend;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.NotifyIcon SecureIcon;
        private ContextMenuStrip BackgroundIconMenu;
        private ToolStripMenuItem 열기ToolStripMenuItem;
        private ToolStripMenuItem 종료ToolStripMenuItem;
        private NotifyIcon InsecureIcon;
        protected CheckBox PasswordRequired;
        private Button SetPassword;
    }
}

