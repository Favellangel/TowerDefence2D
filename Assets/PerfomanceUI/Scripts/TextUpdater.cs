using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    [SerializeField] private int val;

    private TextMeshProUGUI textComponent;

    private void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textComponent.text = val.ToString();
    }
}
