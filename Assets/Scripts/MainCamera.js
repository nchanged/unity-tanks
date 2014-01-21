#pragma strict

function Start () {

}
	var dragSpeed = 10;

    var dragOrigin = new Vector3();

function Update () {
	//transform.Translate(Vector3.right * Time.deltaTime * 100, Camera.main.transform);


	if (Input.GetMouseButtonDown(0))

        {

            dragOrigin = Input.mousePosition;

            return;

        }
	
 	

        if (!Input.GetMouseButton(0)) { return; }
	
 		var a = Input.mousePosition -  dragOrigin;
 		

        var pos = Camera.main.ScreenToViewportPoint( a);
	
	
		
        var move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);
        
        transform.Translate(move, Space.World);  
}