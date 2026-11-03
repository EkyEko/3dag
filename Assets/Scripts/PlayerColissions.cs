using UnityEngine;

public class PlayerColissions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


//Collision detection
private void OnControllerColliderHit()
{
    //check if the player hits an object with the houseDoor tag
    if(hit.gameObject.CompareTag("houseDoor"))
    {
        print("hit the door!");
    }
}

}
