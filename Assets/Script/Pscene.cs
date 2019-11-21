using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pscene : MonoBehaviour {

    public string Bname;
    public void TButtonboy(Button btn)
    {
        Debug.Log(btn.name);
        Bname = btn.name;
    }
    public void Cscene()
    {
        Scene cekcoy = SceneManager.GetActiveScene();
        if(cekcoy.name == "MainMenu")
        {
            if(Bname == "BPlay")
            {
                SceneManager.LoadScene("Play");
            }
            else if(Bname == "BAbout")
            {
                SceneManager.LoadScene("About");
            }
            else if (Bname == "BExit")
            {
                Application.Quit();
            }
        }
        if(cekcoy.name == "About" && Bname == "ABKembali")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if(cekcoy.name == "Play")
        {
            if(Bname == "ToMainMenu")
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
