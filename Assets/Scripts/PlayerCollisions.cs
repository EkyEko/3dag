using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnControllerColliderHit(ControllerColliderHit hit)
    {
    // Check if the player hits an object with the Axe tag
    if (hit.gameObject.CompareTag("Axe"))
    {
    print("Hit the axe!");
    }
    if (hit.gameObject.CompareTag("Tree"))
    {
    print("Hit a Tree!");
    }
    }
}
