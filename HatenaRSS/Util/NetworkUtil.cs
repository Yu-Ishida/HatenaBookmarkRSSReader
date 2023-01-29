using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.CodeDom;

namespace HatenaRSS.Util
{
    /// <summary>
    /// ネットワークユーティリティクラス
    /// </summary>
    public static class NetworkUtil
    {
        /// <summary>
        /// インターネットに接続されているかを確認します。
        /// </summary>
        /// <returns>インターネットに接続されている場合: true, 接続されていない場合: false</returns>
        public async static Task<bool> IsInternetConnected()
        {
            bool res = false;

            try
            {
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("http://clients3.google.com/generate_204");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

            }
            catch (Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                // 発生した例外は呼び出し元に返却する。
                throw;
            }
            finally
            { }

            return res;
        }

        /// <summary>
        /// 指定した URL から HTML のコードを取得します。
        /// </summary>
        /// <param name="targetURL">取得したいページの URL</param>
        /// <returns>取得した HTML コード</returns>
        public async static Task<string> GetHTMLStringForURL(Uri targetURL)
        {
            string res = string.Empty;

            HttpClient? client = null;


            try
            {
                client = new HttpClient();
                
                // ユーザーエージェントの設定
                client.DefaultRequestHeaders.Add(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36 Edg/109.0.1518.61"
                    );

                try
                {
                    // Web ページを取得する。
                    res = await client.GetStringAsync(targetURL);
                }
                catch(Exception ex)
                {
                    // 取得に失敗
                    throw;
                }

            }
            catch(Exception ex)
            {
                SystemUtil.ConsoleOutputLine(ex.Message);
                SystemUtil.ConsoleOutputLine(ex.StackTrace);

                // 発生した例外は呼び出し元に返却する。
                throw;
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }

            return res;
        }
    }
}
