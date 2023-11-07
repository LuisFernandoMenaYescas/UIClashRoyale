using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;


public class Level_Manager : MonoBehaviour
{
    public List<CR_Character> characterz;
    public GameObject soul;
    public void LoadCharacter(string _FileName)
    {
        string path = Application.dataPath + "/Resources/" + _FileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(data);

        for (int i = 0; i < resource.Count; i++)
        {
            CR_Character chara = new CR_Character();
            chara.name = resource[i]["name"].Value;
            chara.rarity = resource[i]["rarity"].Value;
            chara.id = int.Parse(resource[i]["id"].Value);
            characterz.Add(chara);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        characterz = new List<CR_Character>();
        LoadCharacter("characters");
        soul.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[0].name;
        soul.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[0].id.ToString();  //FileSystem.instance.LoadCharacter("characters");
        //CR_Character CharData = FileSystem.instance.LoadFromJSON<CR_Character>("characters");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
