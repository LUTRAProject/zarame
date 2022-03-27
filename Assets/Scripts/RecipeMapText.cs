using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeMapText : MonoBehaviour
{
    public Text maprecipetext;
    public Text maprecipetext1;
    public Text maprecipetext2;

    void Start()
    {
        maprecipetext = GameObject.Find("MapRecipeText").GetComponent<Text>();
        maprecipetext1 = GameObject.Find("MapRecipeText1").GetComponent<Text>();
        maprecipetext2 = GameObject.Find("MapRecipeText2").GetComponent<Text>();

        Debug.Log(maprecipetext);
        Debug.Log(maprecipetext1);
        Debug.Log(maprecipetext2);

        maprecipetext.text = RandomRecipe.recipetext.text;
        maprecipetext1.text = RandomRecipe.recipetext1.text;
        maprecipetext2.text = RandomRecipe.recipetext2.text;

    }

    void Update()
    {
        
    }
}
