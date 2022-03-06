using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomRecipe : MonoBehaviour
{
    List<string> RecipeList = new List<string>();
    Text recipetext;

    void Start()
    {
        RecipeList.Add("ハンバーグ");
        RecipeList.Add("ラーメン");
        RecipeList.Add("うどん");
        RecipeList.Add("カレー");
        RecipeList.Add("シチュー");
        Debug.Log("リストに追加");
        recipetext = GameObject.Find("RecipeText").GetComponent<Text>();
        recipetext.text = RecipeList[Random.Range(0,4)].ToString();

    }

    void Update()
    {
        
    }
}
