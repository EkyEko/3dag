using UnityEngine;

public class PlayerColissions : MonoBehaviour
{

private new AudioSource audio;
[SerializeField] private AudioClip pickupCollectSound;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


//Collision detection


    void OnControllerColliderHit(ControllerColliderHit coll)
    {
        if(coll.gameObject.CompareTag("Pickup"))
        {
            PickupCollect.pickupAmount++;

           audio.PlayOneShot(pickupCollectSound);

           Destroy(coll.gameObject);
        }
    }


}
