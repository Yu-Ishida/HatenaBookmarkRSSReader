   M S B A M L   `   `   `  ????D  @HatenaRSS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HatenaRSS	HatenaRSS  5   	       HatenaRSS.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:HatenaRSS     5   	   -   5          ?Name$  	MainWndow??5   	    ? Title$ Hatena Bookmark ??5   	   $	??450??6"   $	??800??6/   .??5	      ]? .+?5
   
   o? -   5         o?Name$ MainMenu??5
      $	??Top=?6!   .@?5      m? $??ファイル(_X)??6   .@?5      m? -   5        $???9表示内容を CSV ファイルへエクスポート(_E)??5      6`   m? 5      -   5        $??
終了(_X)??5      6D   5      m? 5      $??ヘルプ(_H)??6   .@?5      m? -   5        $??バージョン情報(_A)??5      6P   5      5      ? 5   
   -   5         ?Name$ MainGrid??5      .+?5      ?? -   5         ??Name$ 	BtnReload??5      $??更新??6(   $
??Left=?65   $??	375,6,0,0q?6P   $	??Top=?6c   $??50??6{   $??30??6?   6?   ?? 5      -   5         ??Name$ 
CbCategory??5       ?? SelectedValue$	 Key??6+    ?? DisplayMemberPath$ Value??6?    ?? SelectedIndex$ 0??6Y   $
??Left=?6k   $??	67,12,0,0q?6?   $	??Top=?6?   $	??200??6?   ?? 5      -	   5        	 ??Name$	 LbCategoryNotice??5      $??カテゴリ：??6.   $
??Left=?6>   $??	10,10,0,0q?6Y   $	??Top=?6l   	? 5      -
   5        
 	?Name$
 
RbHotEntry??5      $??人気??6.   $
??Left=?6;   $??
272,16,0,0q?6V   $	??Top=?6j    d? 	IsChecked$
 TrueY?6?   	? 5      -   5        $
 
RbNewEntry??5      $??新着??6.   $
??Left=?6;   $??
320,16,0,0q?6V   $	??Top=?6j   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	DgContent??5      $??10,41,10,10q?6U      SelectionMode$ Single=?6j      AutoGenerateColumns$ False??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ タイトル??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 67   5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $ ページURL??6.   $	 180 6>     5      $ 登録タグ??6)   $	 180 67     5      $ 日付??6)   $	 100 65     5      $ 概要??6)   $
 Auto 65   5!      ?? 5"      -   5        $	 LbUpdateTime??5"      $#??最終更新日時: 未更新??6*   $
??Left=?6@   $??	430,8,0,0q?6[   $	??Top=?6n   5#      5$      5%      