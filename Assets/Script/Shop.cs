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
