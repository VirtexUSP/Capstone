namespace Capstone
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password.Location = new System.Drawing.Point(12, 18);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(40, 16);
            this.Password.TabIndex = 0;
            this.Password.Text = "암호";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordBox.Location = new System.Drawing.Point(58, 13);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.Size = new System.Drawing.Size(387, 26);
            this.PasswordBox.TabIndex = 16;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordCheck.Enabled = false;
            this.PasswordCheck.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PasswordCheck.Location = new System.Drawing.Point(451, 13);
            this.PasswordCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(48, 26);
            this.PasswordCheck.TabIndex = 17;
            this.PasswordCheck.Text = "확인";
            this.PasswordCheck.UseVisualStyleBackColor = true;
            this.PasswordCheck.Click += new System.EventHandler(this.PasswordCheck_Click);
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.PasswordCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 52);
            this.Controls.Add(this.PasswordCheck);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PasswordForm";
            this.Text = "암호입력";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button PasswordCheck;
    }
}