﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"sincere",
"tangible",
"soda",
"feigned",
"quiet",
"defective",
"coach",
"filthy",
"boil",
"zip",
"amusement",
"spoil",
"control",
"perform",
"pies",
"slip",
"stingy",
"windy",
"ear",
"incredible",
"anxious",
"back",
"advertisement",
"protect",
"handle",
"hat",
"note",
"skirt",
"possible",
"vague",
"lying",
"strange",
"cup",
"average",
"property",
"spiritual",
"muscle",
"juice",
"look",
"inquisitive",
"easy",
"accessible",
"cent",
"pizzas",
"harm",
"closed",
"queue",
"boorish",
"lazy",
"cobweb",
"beneficial",
"plucky",
"snotty",
"crow",
"babies",
"coach",
"unbecoming",
"voice",
"jaded",
"cable",
"dapper",
"name",
"ugliest",
"smile",
"spade",
"wing",
"toe",
"fierce",
"pan",
"illustrious",
"page",
"peaceful",
"groovy",
"pushy",
"rose",
"fixed",
"love",
"abortive",
"fire",
"squirrel",
"floor",
"late",
"elderly",
"didactic",
"futuristic",
"animal",
"cluttered",
"uptight",
"unsuitable",
"ill",
"cold",
"activity",
"wasteful",
"nut",
"sparkle",
"ill-fated",
"label",
"sticks",
"scream",
"fertile" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
