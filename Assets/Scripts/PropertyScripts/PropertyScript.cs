using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyScript : MonoBehaviour
{
    public GameObject FlagDisplay;
    public FlagArray flag_array;

    public GameObject GameMaster;
    public GameMaster game_master;

    public string flag_continent;
    public string flag_country;
    public int flag_country_position;

    // Start is called before the first frame update
    void Start()
    {
        assignContinent();
        assignCountry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void assignContinent() {
        //assign a random continent to letter //
        GameObject FlagDisplay = GameObject.Find("FlagDisplay");
        flag_array = FlagDisplay.GetComponent<FlagArray>();
        flag_continent = flag_array.getContinent();
        //assign a random continent to letter //
    }

    void assignCountry() {
        //get current game_mode//
        GameObject GameMaster = GameObject.Find("GameMaster");
        game_master = GameMaster.GetComponent<GameMaster>();
        //get current game_mode//
        flag_country_position = flag_array.getCountryPosition(game_master.getGameMode());
        flag_country = flag_array.getCountry(flag_continent, flag_country_position);
    }
}
