using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking; // for UnityWebRequest
using System.IO; // SUPPORTS FOR READING AND WRITING OF FILES

public class GameControl : MonoBehaviour
{
    public Image BG;
    public Text Name;
    
    void Awake(){
            BetterStreamingAssets.Initialize();
    }

    void Start()
    {
        string[] allfiles = BetterStreamingAssets.GetFiles("/","*.*");

        foreach(string files in allfiles){
            if(files.Contains("sea")){ // checking of whether name matches or not
                StartCoroutine("Process",files);
            }
        }
        
    }

    void Update()
    {
        
    }

    IEnumerator Process(string file){
    
        if(file.Contains("meta")){  // if file contains meta it means it is UnityBuilt-in file
            yield break;
        }
        else{
            string namewithoutextention = Path.GetFileNameWithoutExtension(file.ToString()); //to get the filename without any extention
            string[] individualwords = namewithoutextention.Split(' '); // split individual words with space
            string tempname = "";
            int i = 0;
            foreach(string a in individualwords){
                if(i!=0){ // to exclude first part in filename and get only the original name from it which is to be printed
                    tempname = tempname + a + " "; // concatenate the name to be displayed only 
                }
                i++;
            }

            //get url to the file
            string url = "jar:file://"+Application.dataPath +"!/assets/"+file;
            UnityWebRequest www = UnityWebRequest.Get(url);
            DownloadHandlerTexture dht = new DownloadHandlerTexture ();
            www.downloadHandler = dht;
            yield return www.SendWebRequest();
            while (!www.isDone)
            {
                yield return www;
            }
            BG.sprite = Sprite.Create (((DownloadHandlerTexture)www.downloadHandler).texture , new Rect (0,0, ((DownloadHandlerTexture)www.downloadHandler).texture.width, ((DownloadHandlerTexture)www.downloadHandler).texture.height), new Vector2(0.5f, 0.5f));
            Name.text = tempname;
            
        }
    }
}
