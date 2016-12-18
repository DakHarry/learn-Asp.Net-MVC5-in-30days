Entity Framework是微軟為 .Net平台推出的ORM解決方案。

## 何謂ORM(物件關聯對應)?
定義:是一種程式設計技術，用於實現物件導向編程語言裡不同類型系統的資料之間的轉換。
簡單來說，將SQL語法用物件導向的方式做對應連結來表達。


 
### ADO.Net 與 Entity Framework 的差異：
 
ADO.Net
透過SQL語法對底層資料庫引擎進行直接操作，開發者需要自行組裝SQL語法與
參數。
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808VMqWIvGmor.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808VMqWIvGmor.png)

Entity Framework
使用類似 SQL 的 linq 語法進行操作，取得對應的資料庫物件後，直接對物件內容進行操作。
有別於ADO.Net可以直接執行語法，Entity Framework 新增、修改與刪除等行為不會立課執行，而是透過saveChange()語法，讓物件對資料庫進行更新。
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808b5FhWyDNUC.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808b5FhWyDNUC.png)
EF提供了一個封裝的方式，讓我們不需要直接對資料庫進行操作，而是對EF進行溝通再向資料庫做存取。

### EF架構
概念層(CSDL)：負責向上的物件與屬性顯露與存取。(eg.Attribute屬性、關係0..1等等)
對應層(C-S)：將上方的概念層和底下的儲存層的資料結構對應在一起。(畫出edmx所看到的圖形介面)
儲存層(SSDL)：依不同資料庫與資料結構，而顯露出實體的資料結構體，和 Provider 一起，負責實際對資料庫的存取和 SQL 的產生。

## 好處

- 1 對開發人員:不需要懂T-SQL/Stored Procedure，可以更專注在開發技巧
- 2 對DBA:可以不懂Entity Framework、OOP或.NET而專注在資料庫上
- 3 「封閉」通用資料庫的接觸，操作讀取、更新或刪除的語法更簡單，且完全不用考慮該死的SQL語句。
- 4 因為無法透過SQL語法對資料庫進行直接連結，可以防止SQL的注入攻擊(SQL-Injection)
- 5 提高開發效率
- 6 方便轉移資料庫

## 缺點
- 1 自動化意味著映射和關聯管理，代價是犧牲性能

在專案中加入「ADO.NET實體資料模型」時，提供了四種不同的開發模式
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808jB2uQFuoTj.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808jB2uQFuoTj.png)

![http://ithelp.ithome.com.tw/upload/images/20161218/20103808YFIxqDkKaE.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808YFIxqDkKaE.png)
- CodeFirst這種方式需要先寫一些程式，如Table設計和關係等，然後根據程式描述，自動建立Table的關聯。

- ModelFirst先利用VS提供的圖形設計方式出可視化的實體模型，再根據這些實體、關係去生成資料庫對象及相關檔案。

## 以A方案進行測試
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808AYbYLcdWQM.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808AYbYLcdWQM.png)
選擇預先建好的local資料庫，精靈會自動幫你建立db.connect的動作，不需要自己選擇，只需要點下一步就好。
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808WcvVpfmvbJ.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808WcvVpfmvbJ.png)
選擇要加入的Table
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808wKXdpgUsvT.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808wKXdpgUsvT.png)
系統產生Edmx檔案



接著透過Model資料夾右鍵「加入」->「類別」，方式建立一個Model。
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808xSwsYJqX49.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808xSwsYJqX49.png)

產生Model後，就開始打些Code吧，建立一個對應資料庫的Class!
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808sABni5Fm6o.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808sABni5Fm6o.png)

接著即可撈出資料
![http://ithelp.ithome.com.tw/upload/images/20161218/20103808Fd658gQbPJ.png](http://ithelp.ithome.com.tw/upload/images/20161218/20103808Fd658gQbPJ.png)


### 文末
當知道關係後，就可以開始建立你的Model的商業邏輯了~
各個觀念參考資料:
> wiki:https://zh.wikipedia.org/wiki/Entity_Framework
> msdn:https://msdn.microsoft.com/en-us/library/jj652027(v=vs.113).aspx
> ORM :http://www.jianshu.com/p/ce8026992275
