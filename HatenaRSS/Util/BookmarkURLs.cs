using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HatenaRSS.Util
{
    /// <summary>
    /// はてなブックマーク RSS URL 管理クラス
    /// </summary>
    public static class BookmarkURLs
    {
        /// <summary>
        /// 総合: 人気
        /// </summary>
        public const string ComprehensiveHotentry = @"http://b.hatena.ne.jp/hotentry.rss";
        /// <summary>
        /// 総合: 新着
        /// </summary>
        public const string ComprehensiveNewEntry = @"http://b.hatena.ne.jp/entrylist.rss";

        /// <summary>
        /// 世の中: 人気
        /// </summary>
        public const string SocialHotentry = @"http://b.hatena.ne.jp/hotentry/social.rss";
        /// <summary>
        /// 世の中: 新着
        /// </summary>
        public const string SocialNewEntry = @"http://b.hatena.ne.jp/entrylist/social.rss";

        /// <summary>
        /// 政治と経済: 人気
        /// </summary>
        public const string EconomicsHotently = @"http://b.hatena.ne.jp/hotentry/economics.rss";
        /// <summary>
        /// 政治と経済: 新着
        /// </summary>
        public const string EconomicsNewEntry = @"http://b.hatena.ne.jp/entrylist/economics.rss";

        /// <summary>
        /// 暮らし: 人気
        /// </summary>
        public const string LifeHotently = @"http://b.hatena.ne.jp/hotentry/life.rss";
        /// <summary>
        /// 暮らし: 新着
        /// </summary>
        public const string LifeNewEntry = @"http://b.hatena.ne.jp/entrylist/life.rss";

        /// <summary>
        /// 学び: 人気
        /// </summary>
        public const string KnowledgeHotEntry = @"http://b.hatena.ne.jp/hotentry/knowledge.rss";
        /// <summary>
        /// 学び: 人気
        /// </summary>
        public const string KnowledgeNewEntry = @"http://b.hatena.ne.jp/entrylist/knowledge.rss";

        /// <summary>
        /// テクノロジー: 人気
        /// </summary>
        public const string TechnorogyHotEntry = @"http://b.hatena.ne.jp/hotentry/it.rss";
        /// <summary>
        /// テクノロジー: 新着
        /// </summary>
        public const string TechnorogyNewEntry = @"http://b.hatena.ne.jp/entrylist/it.rss";

        /// <summary>
        /// エンタメ: 人気
        /// </summary>
        public const string EntertainmentHotEntry = @"http://b.hatena.ne.jp/hotentry/entertainment.rss";
        /// <summary>
        /// エンタメ: 新着
        /// </summary>
        public const string EntertainmentNewEntry = @"http://b.hatena.ne.jp/entrylist/entertainment.rss";

        /// <summary>
        /// アニメとゲーム: 人気
        /// </summary>
        public const string AnimeGameHotEntry = @"http://b.hatena.ne.jp/hotentry/game.rss";
        /// <summary>
        /// アニメとゲーム: 新着
        /// </summary>
        public const string AnimeGameNewEntry = @"http://b.hatena.ne.jp/entrylist/game.rss";

        /// <summary>
        /// おもしろ: 人気
        /// </summary>
        public const string FunHotEntry = @"http://b.hatena.ne.jp/hotentry/fun.rss";
        /// <summary>
        /// おもしろ: 新着
        /// </summary>
        public const string FunNewEntry = @"http://b.hatena.ne.jp/entrylist/fun.rss";

        /// <summary>
        /// 動画
        /// </summary>
        public const string VideoEntry = @"http://b.hatena.ne.jp/video.rss";
    }
}
