using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeMapText : MonoBehaviour
{
    Text maprecipetext;
    Text maprecipetext1;
    Text maprecipetext2;

    void Start()
    {

        maprecipetext = GameObject.Find("MapRecipeText").GetComponent<Text>();
        maprecipetext1 = GameObject.Find("MapRecipeText1").GetComponent<Text>();
        maprecipetext2 = GameObject.Find("MapRecipeText2").GetComponent<Text>();

        maprecipetext.text = RandomRecipe.recipetext.ToString();
        maprecipetext1.text = RandomRecipe.recipetext1.ToString();
        maprecipetext2.text = RandomRecipe.recipetext2.ToString();


    }

    void Update()
    {
        
    }
}
