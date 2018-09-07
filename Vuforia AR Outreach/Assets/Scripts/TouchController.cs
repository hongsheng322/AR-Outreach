using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour {
    //string btnName;
    public Text object_text;

	// Use this for initialization
	void Start () {
        object_text.text = "HELLO";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                //btnName = Hit.transform.name;
                object_text.text = Hit.collider.name;
            }
        }
	}
}
