using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HatenaRSS.Data
{
    /// <summary>
    /// ブックマークデータクラス
    /// </summary>
    public class BookmarkData
    {
        /// <summary>
        /// ブックーマーク数を取得または設定します。
        /// </summary>
        public int BookMarkCount { get; set; }

        /// <summary>
        /// ページの URL を取得または設定します。
        /// </summary>
        public string? PageUrl { get; set; }

        /// <summary>
        /// ページのタイトルを取得または設定します。
        /// </summary>
        public string? PageTitle { get; set; }

        /// <summary>
        /// ページの概要を取得または設定します。
        /// </summary>
        public string? PageSummary { get; set; }

        /// <summary>
        /// ページに設定されているタグを取得または設定します。
        /// </summary>
        public string? PageTag { get; set; }

        /// <summary>
        /// ページの日付を取得または設定します。
        /// </summary>
        public DateTime PageDate { get; set; }
    }
}
