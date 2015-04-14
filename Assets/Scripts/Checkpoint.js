#pragma strict

var SpawnPoint : Transform;

function OnTriggerEnter(col : Collider)
{
	if(col.tag =="Boat")
	{
		SpawnPoint.position = Vector3(transform.position.x, transform.position.y, transform.position.z);
	
	}

}