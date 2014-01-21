using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	public float dragSpeed = 1;
    private Vector3 dragOrigin;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
    {
		if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
		
        if (!Input.GetMouseButton(0)) 
			return;
		
		Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x, 0, pos.y);
        transform.Translate(move, Space.World);
    }
}
