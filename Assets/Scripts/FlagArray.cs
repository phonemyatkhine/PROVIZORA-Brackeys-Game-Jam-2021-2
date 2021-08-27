using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagArray : MonoBehaviour
{
    private string[] africa_countries = {"NIG", "ETH", "EGY", "RSA", "TAN", "KEN", "UGA", "SUD", "MOR", "GHA"};
    private string[] americas_countries = {"USA", "CAN", "MEX", "BRA", "ARG", "CUB", "COL", "GUA", "PER", "HON"};
    private string[] asia_countries = {"CHI", "IND", "JAP", "PAK", "ROK", "THA", "PH","MYA", "UZB", "BAN"};
    private string[] europe_countries = {"RUS", "ENG", "GER", "FRA", "SPA", "ITA", "POL", "GRE", "ROM", "FIN"};
    private string[] oceania_countries = {"AUS", "NZL", "PGW", "FIJ", "SOL", "VAN", "TON", "KIR","SAM","MIC"};

    private string[] continents = {"africa","americas","asia","europe","oceania"};
    private string[] game_modes = {"Easy","Moderate","Hard"};
    
    public GameObject[] africa_flags;
    public GameObject[] americas_flags;
    public GameObject[] asia_flags;
    public GameObject[] europe_flags;
    public GameObject[] oceania_flags;

    private int[] country_limits = {5,8,10};
    private int rand;
    public Transform flag_display;
    
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(flagArray[rand], flagPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getContinent() {
        string rand_continent;
        rand = Random.Range(0,continents.Length);
        rand_continent = continents[rand];
        return rand_continent;
    }

    public int getCountryPosition(string current_game_mode) {
        int i = 0;
        int country_limit = 5;
        foreach (var game_mode in game_modes) {
            if (game_mode == current_game_mode) {
                country_limit = country_limits[i];
            }
            i++;
        }
        rand = Random.Range(0, country_limit -1);
        return rand;
    }

    public string getCountry(string current_continent, int rand) {
        string country = "default";
        switch (current_continent)
        {
            case "africa":
                country = africa_countries[rand];
                break;
            case "americas" :
                country = americas_countries[rand];
                break;
            case "asia" :
                country = asia_countries[rand];
                break;
            case "europe" :
                country = europe_countries[rand];
                break;
            case "oceania" :
                country = oceania_countries[rand];
                break;
            default:
                break;
        }
        return country;
    }

    public GameObject spawnNewFlag(int flag_position, string flag_continent){
        GameObject flag = new GameObject();
        switch (flag_continent)
        {
            case "africa":
                return flag = Instantiate(africa_flags[rand], flag_display.position, Quaternion.identity);
            case "americas" :
                return flag =Instantiate(americas_flags[rand], flag_display.position, Quaternion.identity);
            case "asia" :
                return flag = Instantiate(asia_flags[rand], flag_display.position, Quaternion.identity);
            case "europe" :
                return flag = Instantiate(europe_flags[rand], flag_display.position, Quaternion.identity);
            case "oceania" :
                return flag = Instantiate(oceania_flags[rand], flag_display.position, Quaternion.identity);
            default:
                break;
        }
        return flag;
    }

}
