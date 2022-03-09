using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QA7.Desktop.Core.Utility
{
    public interface IWaitContext : IDisposable
    {
    }

    /// <summary>
    /// Provides a simple way to set a wait cursor (or other cursor)
    /// around a block of code.
    /// </summary>
    /// <example>
    /// <code>
    /// using (new WaitCursor())
    /// {
    ///     // Do something
    /// }
    /// </code>
    /// </example>
    public sealed class WaitCursor : IWaitContext
    {
        private readonly Dictionary<Control, bool> _oldEnabledStates = new Dictionary<Control, bool>();
        private readonly Cursor _oldCursor;


        /// <summary>
        /// <para>Initialize a new instance of the <see cref="WaitCursor"/> class.</para>
        /// </summary>
        public WaitCursor()
            : this(Cursors.WaitCursor) { }

        /// <summary>
        /// <para>Initialize a new instance of the <see cref="WaitCursor"/> class.</para>
        /// </summary>
        /// <param name="cursor">
        /// <para>The <see cref="Cursor"/> to use as the wait <see cref="Cursor"/>.</para>
        /// </param>
        public WaitCursor(Cursor cursor)
        {
            _oldCursor = Cursor.Current;
            Cursor.Current = cursor;
        }

        /// <summary>
        /// <para>Initialize a new instance of the <see cref="WaitCursor"/> class.</para>
        /// </summary>
        /// <param name="controlsToDisable">Array of controls to be disabled while WaitCursor is existing.</param>
        public WaitCursor(params Control[] controlsToDisable)
            : this(Cursors.WaitCursor)
        {
            if (controlsToDisable == null)
                throw new ArgumentNullException("controlsToDisable");

            _oldEnabledStates.Clear();

            foreach (var control in controlsToDisable)
            {
                if (control == null)
                    continue;

                _oldEnabledStates.Add(control, control.Enabled);
                control.Enabled = false;
            }
        }


        /// <summary>
        /// <para>Releases the unmanaged resources used by the <see cref="WaitCursor"/> and optionally releases the managed resources.</para>
        /// </summary>
        public void Dispose()
        {
            Cursor.Current = _oldCursor;

            foreach (var pair in _oldEnabledStates)
            {
                pair.Key.Enabled = pair.Value;
            }
        }
    }
}
