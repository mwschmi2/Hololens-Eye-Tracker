using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalibrationSphere : MonoBehaviour {

    static float scalar = 1.5f;

    public Vector3[] positions = {
        new Vector3(0, scalar, 0),
        new Vector3(scalar, scalar, 0),
        new Vector3(scalar, 0, 0),
        new Vector3(scalar, -scalar, 0),
        new Vector3(0, -scalar, 0),
        new Vector3(-scalar, -scalar, 0),
        new Vector3(-scalar, 0, 0),
        new Vector3(-scalar, scalar, 0),
        new Vector3(0, 0, 0)
    };

    int state = 0;

	// Use this for initialization
	void Start () {
        this.transform.position = positions[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Called when sphere is selected
    void OnSelect()
    {
        state += 1;
        //TODO: Send calibration signal!
        if(state >= 4)
        {
            // TODO: Transition out of calibration
        } else
        {
            this.transform.position = Vector3.Lerp(this.transform.position, positions[state], Time.deltaTime * 0.2f);
        }
    }
}
