![](doc/cover.PNG)

Create new canvas, set it Render Mode: Screen Space - Camera, UI Scale Mode: Scale With Screen Size, Now Create Panel, Game Object Image and others as you need from GameObject->UI element.

Add the following line of code to Shop.cs file attach it to the canvas, initialized canvas to the Serialized variable. Don't forget to Add New -> Content Size Fitter to content to scroll, Set it Vertical/Horizontal Fit to Preferred Size

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Transform ScrolViewTransform;
    private GameObject cardTemplate;
    private GameObject items;
    void Start()
    {
        cardTemplate = ScrolViewTransform.GetChild(0).gameObject;
        for (int i = 0; i < 10; i++)
        {
            items = Instantiate(cardTemplate, ScrolViewTransform);
        }

        Destroy(cardTemplate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

```

