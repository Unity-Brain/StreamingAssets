# StreamingAssets
To read Streaming Assets files into Unity Android build

NOTE : Need knowledge about streaming assets before proceeding to this application. Refer  Unity Manual for StreamingAssets.

# About Application
We can read the files saved in our StreamingAssets folder during runtime in Android.In this application images as considered as the files saved in the folder. Image file name should follow the following criteria :
(i) should start with lowercase
(ii) should be of two part seperated by space ( eg : player Tom.jpg) where first part resembles its purpose in our application (with which we find the image from set of files ) and second part is the name to be shown along with the image).
Application will display the image along with the caption to be displayed (from above eg : Tom will be printed along with image of Tom in the application).In this script, I have saved file like sea Sea.jpg where i will find my image using substring 'sea' and displays 'Sea'.

# How to build Application
1. Open Unity Editor and create a new project.
2. Add an Image ( Right click in Hierarchy, UI -> Panel.Then Click Panel,right click, UI -> Image) and adjust it according to your wish and name it BGimage.
3. Add Text ( Right Click in Hierarchy, UI -> Text ) and name it Name.
4. From Asset Store, download and import - Better Streaming AssetS Pligin. (Dont worry, its free of cost 😁😉 )
5. Now create a folder under Assets ( Project Window ) and name it StreamingAssets ( folder name should be given like this )
6. Create another folder Scripts .Then add my StreamingAssetsAndroid script into that folder.
7. Create an empty GameObject ( Right Click in Hierarchy -> Create Empty ) and add  Component - StreamingAssetsAndroid Script or drag and drop this script to empty gameobject.
8. In Inspector Window , drag and drop Image and Text to respective fields of the scripts ( Click empty gameobject to see those fields ).
9. Now Build and Run in your android phone.


