# 基本環境架構
首先開啟VS，並建立一個MVC專案，會自動產生MVC所需的檔案，今天我們就來逐步認識類別的功用。
![http://ithelp.ithome.com.tw/upload/images/20161217/20103808NNAIKHQ1J9.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808NNAIKHQ1J9.png)

### 專案資料夾
- App_Data: 放置專案所需的資料檔(資料庫)
   在**此目錄下的檔案只允許用程式碼存取**，禁止使用者以瀏覽器直接讀取，這帶來的好處是別人無法任意去讀取你的重要檔案，但此方法只能阻擋透過URL取回資料的可能性，如有更機密的資料，如信用卡資訊等則必須透過其他方法來提高安全性。
- App_Start: MVC的設定檔，將之前版本寫在Global.aspx內容，獨立出來一個資料夾放。
    AuthConfig — 設定授權相關認證的檔案(如登入功能)
    BundleConfig — 可以透過bundle綁定多個CSS和JS，這樣在寫View時就不需要加入多個引用。 
    ![http://ithelp.ithome.com.tw/upload/images/20161217/20103808JZPqgG2im5.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808JZPqgG2im5.png)
    ↑綁定多個套件後，只要在View打一行即可一次引入所需的所有套件檔案
    ![http://ithelp.ithome.com.tw/upload/images/20161217/20103808pbG3qLQ03d.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808pbG3qLQ03d.png)
    ↑View引入方法
  
    WebApiConfig — 如果需要使用WebAPI所需的設定檔 
    FilterConfig — 適用全站共通的過濾條件，如:網站出錯Error的顯示頁面 
    **RouteConfig — 路由設定**


```
     public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
```
 
 Route設定很重要，因為它影響到你網站能不能正確執行，那他的任務是什麼呢?
    在於**比對透過瀏覽器傳來的HTTP需求，回應適當的網址給瀏覽器**，預設的設定分為兩個部分。
    1. routes.IgnoreRoute("{resource}.axd/{*pathInfo}")     
       (resource和pathInfo單純屬於變數可以更改任意自己習慣的命名)
    
       這語法表示不要透過 Routing 處理的網址，例如:www.xyz.com/Home/Index/asp/mvc
       {resource}代表Home
       {pathInfo}代表/Index/asp/mvc (代表任意字元，後面無論路徑多長皆不處理)   
       
    2. routes.MapRoute 表示Routing的規則
       name:預設值
       url:"{controller}/{action}/{id}" 代表網址Url的顯示規則
![http://ithelp.ithome.com.tw/upload/images/20161217/20103808ymm8uvarN0.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808ymm8uvarN0.png)!
       ↑沒有輸入任何網址卻還是連到首頁，為什麼?
       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
       因為預設在沒指定發什麼Request給Routing時，會自動指派Home Controller 去執行Index Action的路徑
 
 
![http://ithelp.ithome.com.tw/upload/images/20161217/20103808DkqgBczQFV.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808DkqgBczQFV.png)
       ↑直接輸入網址一樣可以對應到Home跟Index回應應有的畫面
  在路由比對上需注意的事項
  「/」和「?」是無法進行比對處理的，但是「.」,「-」, 「_ 」 是可以被比對。
   如: www.test/home/Index-a、www.test/home/Index_asp.net 
   
   環境內建提供，Attribute Routing(屬性路由)讓你可以客製化你想要的路由設定
   (你可能網頁在很深層網址看起來就很長看了不愉快? 
   eg:http://example.com.tw/Products/Clothes/Detail?10186259/draft 
   而你只想顯示http://example.com.tw/Products/Clothes/10186259)。
   
       Step1.只需要在routes.MapRoute前加入routes.MapMvcAttributeRoutes();即可使用，為什麼要加在這裡呢?程式碼通常由上往下讀，邏輯上事先將忽略條件(Ignore)和設計的屬性定義好後，再拿去比對設定的MapRoute是否符合規則。
   
       Step2.在Controller設定Action或整個Controller要套用的規則
   ![http://ithelp.ithome.com.tw/upload/images/20161217/20103808JBt6e63VQR.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808JBt6e63VQR.png)
   
   ### 結果:
   ![http://ithelp.ithome.com.tw/upload/images/20161217/20103808QLiz3uAJLR.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808QLiz3uAJLR.png)
   URL輸入自行定義的字串也可以通過路由對應到所屬的Action
   對路由有興趣的玩家可以自行參考詳細的語法設定
   參考:https://blogs.msdn.microsoft.com/webdev/2013/10/17/attribute-routing-in-asp-net-mvc-5/
   參考:http://kevintsengtw.blogspot.tw/2013/12/aspnet-mvc-attribute-routing_17.html
      
  
- Content:一般存放CSS檔
- **Controllers**
- fonts:慣用字型檔
- **Models**
- Scripts:一班存放Javascript檔
- **Views**
-----
瀏覽完所有資料夾後，你可以選擇重新定義你喜好的檔案存放方式，這並不影響專案執行，但既然專案已有清楚的檔案規劃，我們既然要學習新的架構了，**習慣新的模式代替重新配置的心態**，或許更能了解這樣設定的目的，另外要習慣的就是命名規則。

### 命名規則
將資料夾展開會發現Model-Controller-View的檔案命名是相呼應的
-Model/HomeModel
-Controller/HomeController
-View/Home/Index
名稱必須一致不然在Routing比對時，會發生錯誤找不到相對應的檔案而無法執行。

# 執行流程
![http://ithelp.ithome.com.tw/upload/images/20161217/20103808drJTS3sp7R.png](http://ithelp.ithome.com.tw/upload/images/20161217/20103808drJTS3sp7R.png)
> 圖片來源:http://www.dotnettricks.com/learn/mvc/detailed-aspnet-mvc-pipeline
這張圖清楚地說明了，我們今天所學習到了橘色的過程，從瀏覽器發出Request後，會先經由Routing進行比對通過後再丟給Controller進行對應Action流程最後顯示畫面。

### 文末
有沒有突然覺得，雖然建立一個專案到看到hello World很快，但背後要了解的網頁生命週期與各個流程細節非常多，學不完阿。

