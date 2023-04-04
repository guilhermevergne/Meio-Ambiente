using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    public static bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
		
		updateButtonIco();
        if (PlayerPrefs.HasKey("muted"))
        {
            Load();
        }
        print("muted:" + muted);
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        muted = !muted;
        AudioListener.pause = muted;

        updateButtonIco();
        Save();
    }

    private void updateButtonIco()
    {
		soundOnIcon.enabled = !muted;
		soundOffIcon.enabled = muted;
	}

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
    
}
