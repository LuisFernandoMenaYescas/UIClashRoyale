using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;


public class Level_Manager : MonoBehaviour
{
    public List<CR_Character> characterz;
    public GameObject soul,soul2,soul3,soul4,soul5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20,s21,s22,s23,s24,s25,s26,s27,s28,s29,s30,s31,s32,s33,
        s34,s35,s36,s37,s38,s39,s40,s41,s42,s43,s44,s45,s46,s47,s48,s49,s50,s51,s52,s53,s54;
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
        soul.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[0].id.ToString(); 
        soul2.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[1].name;
        soul2.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[1].id.ToString();
        soul3.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[2].name;
        soul3.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[2].id.ToString(); 
        soul4.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[3].name;
        soul4.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[3].id.ToString();
        soul5.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[4].name;
        soul5.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[4].id.ToString();
        s6.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[5].name;
        s6.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[5].id.ToString();
        s7.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[6].name;
        s7.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[6].id.ToString();
        s8.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[7].name;
        s8.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[7].id.ToString();
        s9.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[8].name;
        s9.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[8].id.ToString();
        s10.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[9].name;
        s10.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[9].id.ToString();
        s11.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[10].name;
        s11.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[10].id.ToString();
        s12.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[11].name;
        s12.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[11].id.ToString();
        s13.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[12].name;
        s13.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[12].id.ToString();
        s14.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[13].name;
        s14.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[13].id.ToString();
        s15.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[14].name;
        s15.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[14].id.ToString();
        s16.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[15].name;
        s16.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[15].id.ToString();
        s17.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[16].name;
        s17.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[16].id.ToString();
        s18.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[17].name;
        s18.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[17].id.ToString();
        s19.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[18].name;
        s19.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[18].id.ToString();
        s20.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[19].name;
        s20.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[19].id.ToString();
        s21.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[20].name;
        s21.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[20].id.ToString();
        s22.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[21].name;
        s22.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[21].id.ToString();
        s23.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[22].name;
        s23.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[22].id.ToString();
        s24.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[23].name;
        s24.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[23].id.ToString();
        s25.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[24].name;
        s25.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[24].id.ToString();
        s26.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[25].name;
        s26.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[25].id.ToString();
        s27.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[26].name;
        s27.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[26].id.ToString();
        s28.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[27].name;
        s28.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[27].id.ToString();
        s29.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[28].name;
        s29.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[28].id.ToString();
        s30.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[29].name;
        s30.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[29].id.ToString();
        s31.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[30].name;
        s31.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[30].id.ToString();
        s32.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[31].name;
        s32.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[31].id.ToString();
        s33.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[32].name;
        s33.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[32].id.ToString();
        s34.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[33].name;
        s34.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[33].id.ToString();
        s35.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[34].name;
        s35.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[34].id.ToString();
        s36.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[35].name;
        s36.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[35].id.ToString();
        s37.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[36].name;
        s37.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[36].id.ToString();
        s38.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[37].name;
        s38.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[37].id.ToString();
        s39.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[38].name;
        s39.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[38].id.ToString();
        s40.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[39].name;
        s40.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[39].id.ToString();
        s41.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[40].name;
        s41.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[40].id.ToString();
        s42.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[41].name;
        s42.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[41].id.ToString();
        s43.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[42].name;
        s43.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[42].id.ToString();
        s44.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[43].name;
        s44.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[43].id.ToString();
        s45.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[44].name;
        s45.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[44].id.ToString();
        s46.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[45].name;
        s46.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[45].id.ToString();
        s47.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[46].name;
        s47.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[46].id.ToString();
        s48.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[47].name;
        s48.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[47].id.ToString();
        s49.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[48].name;
        s49.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[48].id.ToString();
        s50.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[49].name;
        s50.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[49].id.ToString();
        s51.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[50].name;
        s51.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[50].id.ToString();
        s52.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[51].name;
        s52.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[51].id.ToString();
        s53.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[52].name;
        s53.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[52].id.ToString();
        s54.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characterz[53].name;
        s54.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characterz[53].id.ToString();


































        //FileSystem.instance.LoadCharacter("characters");
        //CR_Character CharData = FileSystem.instance.LoadFromJSON<CR_Character>("characters");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
