using System.Collections;
using Facebook.Unity;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class FacebookManger : MonoBehaviour {

    public Text userIDText;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {

        }
        else
        {
            FB.ActivateApp();
        }
    }
    


    public void LogIn()
    {
        FB.LogInWithReadPermissions();
    }

    private void OnLogin(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            AccessToken token = AccessToken.CurrentAccessToken;
            userIDText.text = token.UserId;
        }
    }

    public void Share()
    {
        /* Will pop up share */
        FB.ShareLink(callback:OnShare
            );
    }

    private void OnShare(IShareResult result)
    {
        if (result.Cancelled || !string.IsNullOrEmpty(result.Error))
        {
            Debug.Log("ShareLink error: " + result.Error);
        }
        else if (!string.IsNullOrEmpty(result.PostId))
        {
            Debug.Log(result.PostId);
        }
        else
            Debug.Log("Share succeeded");

    }
}
