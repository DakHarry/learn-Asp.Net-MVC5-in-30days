# 前言
各位好，我是逸宣(Harry)接續的30天主要是探索以Asp.net MVC5開發一個前後台網站所會接觸到的領域，以及Asp.net MVC5的開發觀念，並了解整個開發架構幾組合上的思維，開發環境是以Visual Studio 2015進行。

開發工具官網下載:https://www.visualstudio.com/zh-hans/vs/

# 何謂:MVC 
### *MVC是一種觀念，而不是一種技術*
![http://ithelp.ithome.com.tw/upload/images/20161216/20103808V5v8sat5Fk.png](http://ithelp.ithome.com.tw/upload/images/20161216/20103808V5v8sat5Fk.png)
> 圖片來源:維基百科

MVC 是「Model-View-Controller」三個單字字首的縮寫，這個設計樣式的主要精神，在於依 Web 應用程式特性，區分為三大類功能區塊
* -Model : 資料、商業邏輯的處理。
* -View : 使用者體驗的畫面，包含畫面、顯示的邏輯。
* -Controller : 控制整個運作的流程。
使用者在瀏覽首頁時，會丟需求給Controller，Controller收到使用者想要瀏覽首頁時，會將首頁要load的資料拿去跟Model要，Model處理完所有判斷邏輯後，會將要顯示的資料拿給Controller，再由Controller丟給View來顯示。
這就是整個MVC流程概述的走向，各司其職的概念!!

## 那這能帶來什麼好處呢?

### 關注點分離(Separate of Concerns)
簡單來說，彼此可以獨立開發，並不互相影響，我們可以將網站所需要的商業邏輯都(Model)都建立好，在處理Controller和View而不用同步進行開發，這點在WebForm開發上就行不通。
這樣的好處在於可以**簡化複雜度**，將複雜的問題拆解成數個簡單的單元進行建置，也能提升**可維護性**，例如:當我進行單元測試時，顯示出來的欄位資料跟預期的不一樣，那可能就是Model邏輯有問題、畫面顯示不出來可能Controller沒有對應到或是對應的接口有問題、畫面樣式跑掉則專注在View的調整上。

在這30天的過程，我們會漸漸的接觸整個網頁所會碰觸的技術與邏輯，在這段旅程，我們會學到每個技術所需要了解的概念與他們各自使用的時機，而不只是為了達到結果卻違背了該技術原本的用途，就像是魔法師拿著權杖，卻只會揮棍，不會魔法一樣，在這之後，不會是終點，而是讓你看到下一個技術時，學習及使用上的看法，有更遼闊的思維。
Model: Entity Framework、 LINQ 、ORM
View:Html5、Razor語法、Css、JavaScript、AJAX、jQuery、bootstrap3 
