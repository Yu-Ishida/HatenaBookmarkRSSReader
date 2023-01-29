using System;
using System.CodeDom;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HatenaRSS.Util
{
    /// <summary>
    /// システムユーティリティクラス
    /// </summary>
    public static class SystemUtil
    {
        /// <summary>
        /// デバッガアタッチ時に指定したオブジェクトの内容をコンソールへ出力します。
        /// </summary>
        /// <param name="value">コンソールへ出力するオブジェクト</param>
        public static void ConsoleOutputLine(object? value)
        {
            if (Debugger.IsAttached)
            {
                // Console.WriteLine(value);    // VisualStudio 2019 以降は IDE の出力タブに表示されないようだ。
                Debug.WriteLine(value);
            }
        }

        /// <summary>
        /// 例外オブジェクトをダイアログメッセージとして表示します。
        /// </summary>
        /// <param name="ex">例外オブジェクト</param>
        public static void ShowErrorMessage(Exception ex)
        {
            string dialogMessage = Messages.DIALOG_ERROR_MESSAGE;
            dialogMessage = string.Format(dialogMessage, ex.Message, ex.StackTrace);

            MessageBox.Show(dialogMessage, "Hatena Bookmark RSS", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// 指定した列挙子の値を数値に変換します。
        /// </summary>
        /// <param name="value">数値に変換する列挙子</param>
        /// <returns>数値に変換された列挙子</returns>
        public static int ConvertEnumToInt(object value)
        {
            int res = 0;

            try
            {
                res = Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                throw;
            }
            finally
            { }

            return res;
        }
    }
}
