using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : MonoBehaviour
{
    public string myName = "Alexander the Warlock";
    public int myNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        FindPartyMembers(myName, myNumber);
    }

    public void FindPartyMembers(string addedName, int posNumber)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight",
        };
        QuestPartyMembers.Insert(posNumber, addedName);

        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
