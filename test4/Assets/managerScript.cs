using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerScript : MonoBehaviour {

    public SpriteRenderer squareSprite;
    public Text errorTxt;

    string WEB_CLIENT_ID = "129044841185-5s9p870updhpblbn4331e9g0reubdp1c.apps.googleusercontent.com";

	void Start () {
		
        var googleSignInScript = AndroidGoogleSignIn.Init(this.gameObject);
        googleSignInScript.SignIn(WEB_CLIENT_ID, GoogleSuccessCallback, GoogleErrorCallback);

	}

    void GoogleSuccessCallback(AndroidGoogleSignInAccount s)
    {
        squareSprite.color = Color.green;

    }

    void GoogleErrorCallback(string e)
    {
        squareSprite.color = Color.red;
        errorTxt.text = e;
    }
}
