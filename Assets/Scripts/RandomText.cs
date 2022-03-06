using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
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
        Debug.Log("！！");
        recipetext = GameObject.Find("RecipeText").GetComponent<Text>();
    }

    //イベントトリガーでボタン押した時に処理実行
    public void ButtonClick()
    {
        recipetext.text = RecipeList[Random.Range(0,4)].ToString();
    }

}
