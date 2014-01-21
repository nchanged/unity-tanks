using UnityEngine;
using System.Collections;


public class MainCamera : MonoBehaviour {
	
	public float dragSpeed = 50;
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
		
		
		Vector3 currentPosition = Input.mousePosition;
		float destinationX =  (dragOrigin.x - currentPosition.x);
		float destinationY =  (dragOrigin.y - currentPosition.y);
		
		dragOrigin = currentPosition;
		
		
		
		
        Vector3 move = new Vector3(destinationX, 0, destinationY);
        transform.Translate(move, Space.World);
		
		
			
		
		//Camera.main.transform.position.z = a;
    }
}
