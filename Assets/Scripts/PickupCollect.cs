using UnityEngine;
using UnityEngine.UI;

public class PickupCollect : MonoBehaviour
{
    public static bool AxeCollected = false;
    public static bool TorchCollected = false;
    public static bool FlameCollected = false;


    [SerializeField] GameObject AxeUI;
    [SerializeField] GameObject TorchUI;
    [SerializeField] GameObject FlameUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AxeUI.SetActive(false);
        TorchUI.SetActive(false);
        FlameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(AxeCollected == true)
        {
            AxeUI.SetActive(true);
        }
        if(TorchCollected == true)
        {
            TorchUI.SetActive(true);
        }
        if(FlameCollected == true) 
        {
            FlameUI.SetActive(true);
        }
    }
}
