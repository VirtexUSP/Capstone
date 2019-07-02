using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Capstone
{
    static class GTU
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>

        [STAThread]
        static void Main()
        {
            ProtectedProcess.Protect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    /// <summary>
    /// Class responsible for exposing undocumented functionality making the host process unkillable.
    /// </summary>

    public static class ProtectedProcess
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

        /// <summary>
        /// Flag for maintaining the state of protection.
        /// </summary>

        private static volatile bool s_isProtected = false;

        /// <summary>
        /// For synchronizing our current state.
        /// </summary>

        private static ReaderWriterLockSlim s_isProtectedLock = new ReaderWriterLockSlim();

        /// <summary>
        /// Gets whether or not the host process is currently protected.
        /// </summary>

        public static bool IsProtected
        {
            get
            {
                try
                {
                    s_isProtectedLock.EnterReadLock();

                    return s_isProtected;
                }

                finally
                {
                    s_isProtectedLock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// If not alreay protected, will make the host process a system-critical process so it
        /// cannot be terminated without causing a shutdown of the entire system.
        /// </summary>

        public static void Protect()
        {
            try
            {
                s_isProtectedLock.EnterWriteLock();

                if (!s_isProtected)
                {
                    Process.EnterDebugMode();
                    RtlSetProcessIsCritical(1, 0, 0);
                    s_isProtected = true;
                }
            }

            finally
            {
                s_isProtectedLock.ExitWriteLock();
            }
        }

        /// <summary>
        /// If already protected, will remove protection from the host process, so that it will no
        /// longer be a system-critical process and thus will be able to shut down safely.
        /// </summary>

        public static void Unprotect()
        {
            try
            {
                s_isProtectedLock.EnterWriteLock();

                if (s_isProtected)
                {
                    RtlSetProcessIsCritical(0, 0, 0);
                    s_isProtected = false;
                }
            }

            finally
            {
                s_isProtectedLock.ExitWriteLock();
            }
        }
    }
}