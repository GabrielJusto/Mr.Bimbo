using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsButtons : MonoBehaviour
{

    public Text textOption;
    public Text description;
    private OptionData optionData;

    private Controller gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<Controller>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(OptionData data)
    {
        optionData = data;
        description.text = optionData.description;
        textOption.text = optionData.OptionText;
    }

    public void HandleClick()
    {
        gameController.OptionClicked(optionData.control);
    }
}
