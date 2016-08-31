

##what's Cotra？
Cotra a Fiddler plug-in, which from the login state of the request to intercept the login state, synchronized to the development and debugging of the page.

* A fiddler plug-in
* Rules can be configured
* Show the interception to the cookie
* Automatic synchronization of logged cookies
* Through the configuration, to achieve at the same time on the chrome to carry out a number of environments development and debugging
* Through the configuration, repair experience and development of the conflict


##Download and install
Download and install the package([Cotra-4-Fiddler.rar](https://github.com/lukezhang001/Cotra/blob/master/Cotra-4-Fiddler.rar)), after decompression, run CotraInstall.exe installation



##Usage
* Open Fiddler,switch to Cotra Tab

![](https://github.com/lukezhang001/Cotra/blob/master/pic/1.png "")

* If there is no default configuration(or skip step 2th,3th,4th),click "Add"button to add one

![](https://github.com/lukezhang001/Cotra/blob/master/pic/2.png "")

* Add configuration

![](https://github.com/lukezhang001/Cotra/blob/master/pic/3.png "")

　　－Name:Name of configuration

　　－UserAgent:Input UA matching, support for string matching and regular matching

　　－RequestURL:Input URL matching, support for string matching and regular matching

　　－RequestCookies:cookie names to intercept,split by ';'

　　－When Contents:A unique flag that is configured to intercept a request that includes a specified cookie.<br>
　　　This avoid to affect the development when other user test the page.

　　－AttackedCookie:The cookies needs to be manually embedded in the output,split by ';'

　　－CookieHost:Host attributes of the output end cookie

　　－ResponseURl:Onput URL matching, support for string matching and regular matching

* Confirm check the corresponding configuration

![](https://github.com/lukezhang001/Cotra/blob/master/pic/4.png "")

* By phone connected to the fiddler, access the corresponding request link, when the fiddler to intercept the corresponding cookie, will show the red information

![](https://github.com/lukezhang001/Cotra/blob/master/pic/5.png "")

* Open the corresponding link to obtain the login state

![](https://github.com/lukezhang001/Cotra/blob/master/pic/6.png "")