using HatenaRSS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HatenaRSS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームが読み込まれた際のイベント
        /// </summary>
        /// <param name="sender">イベント元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // カテゴリコンボボックスの初期化
                FormUtil.SetCategoryComboItem(this.CbCategory);

                // 総合カテゴリの HTML を取得する。
                Uri uri = new Uri(BookmarkURLs.ComprehensiveHotentry);
                string htmlString = await NetworkUtil.GetHTMLStringForURL(uri);
                // 取得した htmlString から XML パースして、必要な情報を取得する。

            }
            catch(Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                SystemUtil.ShowErrorMessage(ex);
            }
            finally
            { }
        }

        /// <summary>
        ///「更新」ボタン押下時のイベント
        /// </summary>
        /// <param name="sender">イベント元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 更新処理を行う。
            }
            catch(Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                SystemUtil.ShowErrorMessage(ex);
            }
            finally
            { }
        }

        /// <summary>
        ///「表示内容を CSV ファイルにエクスポート」メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void ExportCSVFIleMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        ///「終了」メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void ExitMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        ///「バージョン情報」メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント元オブジェクト</param>
        /// <param name="e">イベントオブジェクト</param>
        private void VersionInfoMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
