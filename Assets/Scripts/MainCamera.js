#pragma strict

function Start () {

}

function Update () {
	transform.Translate(Vector3.right * Time.deltaTime * 100, Camera.main.transform);
}