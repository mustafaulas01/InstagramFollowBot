# Instagram Follow Bot
> This Project was developed in C# . Selenium library was used.

The aim here is to automatically follow certain people or pages thanks to the bot.In this project, we will use the Selenium library to create a virtual browser. First of all, you must understand that we must have an Instagram account that we will use for the bot. Here you can use your existing instagram account or create a new account.Later, when you examine the code, you will see that I added the people or pages I want to follow to a list, the bot will automatically pull the people or pages from this list in order and go to their pages and click the follow button.


![bot](https://github.com/user-attachments/assets/3ce3705c-e2fa-47ea-a091-ab934572f7e2)

 ## The bot performs the following operations automatically:
* The bot goes to the Instagram page
* Fill in the username and password inputs and click on the login button
* Clicks the Not Now button that appears on the save information screen
* Clicks the Not now button on the Get Notifications screen
* After the bot account is opened, it goes to the first account to be followed in the list
* After reaching the relevant person's account, the bot clicks on the Follow Button and moves on to the next account to follow
* After following all the people in the list, it closes the virtual browser
