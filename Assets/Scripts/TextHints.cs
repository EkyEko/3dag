using UnityEngine;
using UnityEngine.UI;

public class TextHints : MonoBehaviour
{
    // Text hint logic
    public static string message; // message content

    static Text TextHint; // Onscreen text object

    public static bool TextOn;

    private float timer = 0.0f;

    [SerializeField] float TextOnTime = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextHint = GetComponent<Text>();

        timer = 0.0f;

        TextOn = false;

        TextHint.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(TextOn)
        {
            TextHint.enabled = true;

            TextHint.text = message;

            timer += Time.deltaTime;
        }

        if(timer >= TextOnTime)
        {
            TextOn = false;

            TextHint.enabled = false;

            timer = 0.0f;
        }
    }
}
