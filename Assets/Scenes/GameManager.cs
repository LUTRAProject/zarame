using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RandomRecipe.recipetext.text);
        Debug.Log(RandomRecipe.recipetext1.text);
        Debug.Log(RandomRecipe.recipetext2.text);
        Debug.Log(RandomRecipe.a);
        Debug.Log(RandomRecipe.b);
        Debug.Log(RandomRecipe.c);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
