using System.Windows.Forms;

namespace QA7.Desktop.Core.Utility
{
    public static class DialogUtility
    {
        private static string AttentionDialogCaption = "Attention";
        private static string InfoDialogCaption = "Info";


        public static void ShowErrorMessage(Form owner, string errorMessage)
        {
            MessageBox.Show(owner, errorMessage,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessage(string errorMessage)
        {
            ShowErrorMessage(null, errorMessage);
        }

        public static void ShowErrorMessage(string messageTemplate, params object[] args)
        {
            ShowErrorMessage(null, messageTemplate, args);
        }

        public static void ShowErrorMessage(Form owner, string messageTemplate, params object[] args)
        {
            string message = string.Format(messageTemplate, args);

            ShowErrorMessage(owner, message);
        }

        public static void ShowWarningMessage(string template, params object[] args)
        {
            ShowWarningMessage(null, template, args);
        }


        public static void ShowWarningMessage(Form owner, string template, params object[] args)
        {
            ShowWarningMessage(owner, string.Format(template, args));
        }

        public static void ShowWarningMessage(Form owner, string message)
        {
            MessageBox.Show(owner, message,
                AttentionDialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowWarningMessage(string message)
        {
            ShowWarningMessage(null, message);
        }

        public static void ShowInfoMessage(string messageTemplate, params object[] args)
        {
            ShowInfoMessage(null, messageTemplate, args);
        }

        public static void ShowInfoMessage(Form owner, string messageTemplate, params object[] args)
        {
            string message = string.Format(messageTemplate, args);
            ShowInfoMessage(owner, message);
        }

        public static void ShowInfoMessage(string message)
        {
            ShowInfoMessage(null, message);
        }

        public static void ShowInfoMessage(Form owner, string message)
        {
            MessageBox.Show(owner, message,
                InfoDialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ConfirmCloseWithoutSaving(string formCaption)
        {
            string confirmMessage = string.Format("Form '{0}' has unsaved changes. Do you want to save ones?", formCaption);
            return MessageBox.Show(confirmMessage,
                AttentionDialogCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ShowConfirmMessageWithCancel(string messageTemplate, params object[] args)
        {
            string message = string.Format(messageTemplate, args);
            return ShowConfirmMessageWithCancel(message);
        }

        public static DialogResult ShowConfirmMessageWithCancel(string message)
        {
            return MessageBox.Show(message,
                AttentionDialogCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static bool ShowConfirmMessage(string confirmMessage, bool isExclamation, params object[] messageParams)
        {
            var message = string.Format(confirmMessage, messageParams);
            return ShowConfirmMessage(message, defaultIcon: isExclamation ? MessageBoxIcon.Exclamation : MessageBoxIcon.Question);
        }

        public static bool ShowConfirmMessage(string confirmMessage,
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
            MessageBoxIcon defaultIcon = MessageBoxIcon.Question)
        {
            return MessageBox.Show(confirmMessage,
                AttentionDialogCaption, MessageBoxButtons.YesNo, defaultIcon, defaultButton) == DialogResult.Yes;
        }
    }
}
