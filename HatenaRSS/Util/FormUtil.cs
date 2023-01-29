using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HatenaRSS.Util
{
    /// <summary>
    /// フォームユーティリティクラス
    /// </summary>
    public static class FormUtil
    {
        /// <summary>
        /// メインカテゴリを示す列挙体
        /// </summary>
        public enum MainCategory
        {
            総合 = 0,
            世の中,
            政治と経済,
            くらし,
            学び,
            テクノロジー,
            エンタメ,
            アニメとゲーム,
            おもしろ,
            動画
        }

        /// <summary>
        /// カテゴリコンボボックスに対して項目を設定します。
        /// </summary>
        /// <param name="cbCategory">項目を設定するコンボボックスコントロール</param>
        public static void SetCategoryComboItem(ComboBox cbCategory)
        {
            try
            {
                Dictionary<int, string> dictCategory = new Dictionary<int, string>();
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.総合), MainCategory.総合.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.世の中), MainCategory.世の中.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.政治と経済), MainCategory.政治と経済.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.くらし), MainCategory.くらし.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.学び), MainCategory.学び.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.テクノロジー), MainCategory.テクノロジー.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.エンタメ), MainCategory.エンタメ.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.アニメとゲーム), MainCategory.アニメとゲーム.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.おもしろ), MainCategory.おもしろ.ToString());
                dictCategory.Add(SystemUtil.ConvertEnumToInt(MainCategory.動画), MainCategory.動画.ToString());

                cbCategory.ItemsSource = dictCategory;
            }
            catch (Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                throw;
            }
            finally
            { }
        }
    }
}
