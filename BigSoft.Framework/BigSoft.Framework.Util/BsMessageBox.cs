﻿using System.Windows.Forms;

namespace BigSoft.Framework.Util
{
    public static class BsMessageBox
    {
        public static void Show(BsNewResult result)
        {
            switch (result.OpType)
            {
                case OpType.Successful:
                    MessageBox.Show(result.Message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case OpType.UserError:
                    MessageBox.Show(result.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case OpType.SystemError:
                    MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Ask(string message)
        {
            return MessageBox.Show(message, "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}