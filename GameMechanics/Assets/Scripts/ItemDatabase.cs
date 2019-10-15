using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Items> items = new List<Items>();

    public void BuildDatabase()
    {
        //items = new List<Items>()
        //{
        //    new Items(0, "Pink Flower", "A pink flower you found in the bushes.",
        //    new Dictionary<string, int>
        //    {
        //        { "Power", 5 },
        //        { "Beauty", 10 }
        //    }),

        //    new Items(1, "Blue Flower", "A blue flower you picked from the ground.", new Dictionary<string,int>)
        //};
    }

}