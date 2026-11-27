using UnityEngine;
using System.Collections;

public class PlayerColissions : MonoBehaviour
{

// door animator
[SerializeField] private GameObject door;
private Animator doorAnimator;

// door timer
[Header("door timer")]
private bool startDoorTimer = false;
private float doorTimer = 0.0f;
[SerializeField] private float doorOpenTime = 3.0f;

[SerializeField] private AudioClip DoorOpenSound;
[SerializeField] private AudioClip DoorShutSound;
private new AudioSource audio;

private bool doorIsOpen = false;

[SerializeField] private AudioClip pickupCollectSound;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startDoorTimer)
        {
            doorTimer += Time.deltaTime;
        }

        if(doorTimer >= doorOpenTime)
        {

            doorTimer = 0.0f;
        }
    }

private void onControllerColliderHit(ControllerColliderHit hit)
{
    if(hit.gameObject.CompareTag("Tree") && PickupCollect.pickupAmount >= 1)
    {

        PickupCollect.hud.enabled = false;
    }

    else if (hit.gameObject.CompareTag("Tree") && PickupCollect.pickupAmount <= 0)
    {
        TextHints.message = "Might need an axe for this...";

        TextHints.TextOn = true;
    }
}






//Item Obtainment
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.CompareTag("Pickup"))
        {
            PickupCollect.pickupAmount++;

            audio.PlayOneShot(pickupCollectSound);

           Destroy(coll.gameObject);
        }

        if(coll.gameObject.CompareTag("Tree") && PickupCollect.pickupAmount == 1)
        {
            PickupCollect.pickupAmount++;

            audio.PlayOneShot(pickupCollectSound);

            Destroy(coll.gameObject);
        }
        if(coll.gameObject.CompareTag("Fire") && PickupCollect.pickupAmount == 2)
        {
            PickupCollect.pickupAmount++;

            audio.PlayOneShot(pickupCollectSound);

            Destroy(coll.gameObject);


        }
        if(coll.gameObject.CompareTag("RitualFlame") && PickupCollect.pickupAmount == 3)
        {
            PickupCollect.pickupAmount++;

            audio.PlayOneShot(pickupCollectSound);

            Destroy(coll.gameObject);
            coll.transform.parent.Find("Afterburner").gameObject.SetActive(true);
        }
    }




}
