using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public string keyUp, keyDown, keyLeft, keyRight;
    public float dirUp, dirRight;
    private float velocityUp, velocityRight;
    public bool inputEnabled;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float dirUpTarget = (Input.GetKey(keyUp)?1.0f:0) - (Input.GetKey(keyDown)?1.0f:0);
        float dirRightTarget = (Input.GetKey(keyRight)?1.0f:0) - (Input.GetKey(keyRight)?1.0f:0);
        print(inputEnabled.ToString());
        if (inputEnabled == false) {
            dirUpTarget = dirRightTarget = 0;
        }

        //平滑插值
        dirUp = Mathf.SmoothDamp(dirUp, dirUpTarget, ref velocityUp, 0.1f);
        dirRight = Mathf.SmoothDamp(dirRight, dirRightTarget, ref velocityRight, 0.1f);
	}
}
