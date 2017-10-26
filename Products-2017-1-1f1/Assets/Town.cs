using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Town : MonoBehaviour {

    //List all the columns of your table here in the same format as below.
    public string ID { get; set; }
    public string TownId { get; set; }
    public string TownName { get; set; }
    public float Latitude { get; set; }
    public float Altitude { get; set; }
    public float Longitude { get; set; }
    public float Size { get; set; }
    public string Symbol { get; set; }

}
