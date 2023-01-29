using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatenaRSS.Util
{
    /// <summary>
    /// メッセージ管理クラス
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// 発生したエラーをダイアログへ表示する際のメッセージ
        /// </summary>
        public const string DIALOG_ERROR_MESSAGE = "下記のエラーが発生しました。\n\n" +
                                                   "【オリジナルエラーメッセージ】\n" +
                                                   "{0}\n\n" +
                                                   "【エラー発生箇所】\n" +
                                                   "{1}";
    }
}
