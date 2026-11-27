using UnityEngine;
using UnityEngine.UI;

public class PickupCollect : MonoBehaviour
{
    public static int pickupAmount = 0;

    public static Image hud;

    [SerializeField] Sprite Pickup1Tex;
    [SerializeField] Sprite Pickup2Tex;
    [SerializeField] Sprite Pickup3Tex;
    [SerializeField] GameObject Fire;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hud = gameObject.GetComponentInChildren<Image>();

        hud.enabled = false;

        pickupAmount = 0;

        Fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(pickupAmount == 1)
        {
            hud.sprite = Pickup1Tex;
            hud.enabled = true;
        }
        else if(pickupAmount == 2)
        {
            hud.sprite = Pickup2Tex;
            hud.enabled = true;
        }
        else if (pickupAmount == 3)
        {
            hud.sprite = Pickup3Tex;
            hud.enabled = true;
            Fire.SetActive(true);
        }
        else
        {
            hud.enabled = false;
            Fire.SetActive(false);
        }
    }
}
