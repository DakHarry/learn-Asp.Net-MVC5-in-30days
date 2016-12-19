Day3建立了ProductModel今天來了解如何建立Controller!
或是你需要CRUD的功能可以選擇「具有讀取/寫入動作的MVC5控制器」，它會自動產生讀取、寫入、更新和刪除的Action方便節省時間。
![http://ithelp.ithome.com.tw/upload/images/20161219/20103808KBDhW72b8z.png](http://ithelp.ithome.com.tw/upload/images/20161219/20103808KBDhW72b8z.png)

為了熟悉開發方式，我們還是從頭到尾自己寫一遍!
-Step1 在Controller資料夾按右鍵「加入」/「控制器」，選空白。
![http://ithelp.ithome.com.tw/upload/images/20161219/201038083y7ItLpTC6.png](http://ithelp.ithome.com.tw/upload/images/20161219/201038083y7ItLpTC6.png)

-Step2 命名規則後面一定要加Controller字樣做結尾(必須繼承內建的Controller類別 或繼承有實IController介面的自訂類別或直接實作 IController介面)
![http://ithelp.ithome.com.tw/upload/images/20161219/201038082nBmTjJrWJ.png](http://ithelp.ithome.com.tw/upload/images/20161219/201038082nBmTjJrWJ.png)

-產生的Controller檔案
![http://ithelp.ithome.com.tw/upload/images/20161219/20103808pVE1fPoMs6.png](http://ithelp.ithome.com.tw/upload/images/20161219/20103808pVE1fPoMs6.png)
### Controller
```
 public class ProductController : Controller
    {
       ....
    }
```
預設會自動繼承Controller類別，在Controller裡面會設計各種Action方法，來迎接通過Routing後，相對應的接口。
### Action
```
 public ActionResult Index()
        {
            return View();
        }
```
ActionResult是MVC回傳的類別，預設回傳的View()被定義在實作的Controller之中。
可以透過F12功能，滑鼠點Controller的位子後，按F12，去追蹤他所實作的類別。
![http://ithelp.ithome.com.tw/upload/images/20161219/20103808TLZi1CtPXE.png](http://ithelp.ithome.com.tw/upload/images/20161219/20103808TLZi1CtPXE.png)

![http://ithelp.ithome.com.tw/upload/images/20161219/20103808uI9FSAruSa.png](http://ithelp.ithome.com.tw/upload/images/20161219/20103808uI9FSAruSa.png)

## Action Method
### 使用限制
- 所有方法必須為公開方法
- Privated/Protected方法都不會被視為Action Method
- Action method 不能被覆寫
- Action method不能是static方法
- 可以帶Null型別的參數

### 回傳類別
他能回傳的類別有:html, file, string, json, javascript 等等
![http://ithelp.ithome.com.tw/upload/images/20161219/20103808MbF0AghqiO.png](http://ithelp.ithome.com.tw/upload/images/20161219/20103808MbF0AghqiO.png)
> 資料來源: http://www.tutorialsteacher.com/mvc/action-method-in-mvc

### 開發小技巧
要新增一個Action時可以直接打「mvca」在按兩下Tab即可產生一個Action Method的框架。
![http://ithelp.ithome.com.tw/upload/images/20161219/2010380825nkyEtFda.png](http://ithelp.ithome.com.tw/upload/images/20161219/2010380825nkyEtFda.png)
第一個是透過mvca產生，第二個多了[HttpPost]是mvcp+TAB+TAB產生。(之後會詳細介紹)


接下去，我們會建置View後，初步開發順序就會有一個清楚的觀念，接著就會更深入於MVC開發所帶來的好處和Model、View、Controller還未提到的一些必要開發的知識，包含強型別的用法，資料驗證的方式，傳資料的方法等等，以及快速開發CRUD(Create、Read、Update、Delete)的基本功能。







