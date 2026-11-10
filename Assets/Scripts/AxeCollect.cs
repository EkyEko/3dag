using UnityEngine;
using UnityEngine.UI;

public class AxeCollect : MonoBehaviour
{
    public static int pickupAmount = 0;

    public static Image hud;

    [SerializeField] Sprite Pickup1Tex;
    [SerializeField] Sprite Pickup2Tex;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hud = gameObject.GetComponentInChildren<Image>();

        hud.enabled = false;

        pickupAmount = 0;
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
        }
    }
}
