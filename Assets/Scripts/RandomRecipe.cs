using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomRecipe : MonoBehaviour
{
    List<string> RecipeList = new List<string>();
    public static Text recipetext;
    public static Text recipetext1;
    public static Text recipetext2;
    int a;
    int b;
    int c;

    void Start()
    {
        //RecipeListに材料を追加
        RecipeList.Add("スパイス");
        RecipeList.Add("にんじん");
        RecipeList.Add("ジャガイモ");
        RecipeList.Add("玉ねぎ");
        RecipeList.Add("牛肉");
        Debug.Log("リストに追加");

        //ヒエラルキーのRecipeTextを参照し、そのTextをrecipetextとする
        recipetext = GameObject.Find("RecipeText").GetComponent<Text>();
        recipetext1 = GameObject.Find("RecipeText1").GetComponent<Text>();
        recipetext2 = GameObject.Find("RecipeText2").GetComponent<Text>();

        //変数a～cに0～4の値をランダムで代入
        a = Random.Range(0,4);
        b = Random.Range(0,3);
        c = Random.Range(0,2);

        //recipetextにリストからランダムで取得した材料を代入。代入したものをリストから削除
        recipetext.text = RecipeList[a].ToString();
        RecipeList.RemoveAt(a);
        recipetext1.text = RecipeList[b].ToString();
        RecipeList.RemoveAt(b);
        recipetext2.text = RecipeList[c].ToString();
        RecipeList.RemoveAt(c);

    }

    void Update()
    {
        
    }
}
