using System;
using System.Diagnostics;

namespace NMS.Core.Utility.Converters
{
    public class FFmpegProcess : IDisposable
    {
        private Process _process = new Process();

        public FFmpegProcess(string ffmpegPath, string arguments)
        {
            _process.StartInfo.FileName = ffmpegPath;
            _process.StartInfo.Arguments = arguments;
            _process.StartInfo.RedirectStandardOutput = true;
            _process.StartInfo.CreateNoWindow = true;
            _process.StartInfo.UseShellExecute = false;

            _process.Start();
            _process.WaitForExit();
        }


        ~FFmpegProcess()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        public bool Start()
        {
            return _process.Start();
        }


        #region IDisposable Support

        private bool _disposed = false;

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // dispose managed state (managed objects).
                ((IDisposable)_process).Dispose();
            }

            // free unmanaged resources (unmanaged objects) and override a finalizer below.
            // set large fields to null.

            _disposed = true;
        }

        #endregion
    }
}
