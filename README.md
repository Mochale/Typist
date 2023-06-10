# Typist ⌨️

You can test your typing speed using this program. 


## How to use 🛠️

1. download and install [file](https://github.com/Mochale/Typist/blob/main/Setup.msi) 
2. Chose the [language](https://github.com/Mochale/Typist/assets/74505328/92385220-4cb3-4040-b093-2a04e88a0e97)
3. Read the [Rules](https://github.com/Mochale/Typist/assets/74505328/010462c3-4635-43f5-bf72-59f36fb58181)
4. Injoy and try to be faster !


## How to add a language ❓

- There is two option for this solution 

1. Make an issue and send Word.txt file of your language, in this solution we will add your file to project.
2. Add by your own self [localy](/#add-localy-word-to-app-%EF%B8%8F).


### Add localy word to app ⚙️

1. Go to `Install directory\Resources`
2. Make a copy from En and rename the file to what you want
3. Replace your Words.txt file 
4. Open MessageBixes.json with notepad or other editors and change your messages
5. Go to `Install directory\Resources\[YourFile]\Forms` like above section change Game.json and Main.json
6. Then register your language 
7. Go to `Install directory\Resources\Register.json` and add a json to languages section
```json
{ "Name": "your lang", "Directory": "YourFile" }
``` 

9. Run the program and injoy 🔥
