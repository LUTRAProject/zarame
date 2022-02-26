using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{

    public Text RecipeText;

    void start()
    {

        List<string> recipeList = new List<string>();
        recipeList.Add("ハンバーグ");
        recipeList.Add("カレー");
        recipeList.Add("ラーメン");
        recipeList.Add("パスタ");
        recipeList.Add("ゆずる");

        Debug.Log(recipeList);

        //int rnd = Random.Range(1, 5);
 
        //string str1 = recipeList[rnd];

        //RecipeText.text = "str1";    
    }

}
