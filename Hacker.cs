
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game config data 

    string[] level1Passwords = {"flash", "wally", "grod", "heatwave", "godspeed" };
    string[] level2Passwords = {"oracle", "scarecrow", "selina", "firefly", "grayson"};
    string[] level3Passwords = {"firestorm", "blacklightning", "bluebeetle", "nightwing", "stargirl"};

    // GameState

    int level;

    string password;

    enum Screen {MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
        
    }

    void ShowMainMenu() {

        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("Press 1 to hack S.T.A.R Labs");
        Terminal.WriteLine("Press 2 to hack the Batcave");
        Terminal.WriteLine("Press 3 to hack the Hall of Justice");
        Terminal.WriteLine("Enter selection: ");
    }

    
    

    void OnUserInput(string input)
	{
        if (input.ToLower() == "menu") {   
            ShowMainMenu();
        } else if (currentScreen == Screen.MainMenu) {
            HandleMainMenu(input);
        } else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
	}
    
    void HandleMainMenu(string input) {
        if (input == "1") {
            int index = Random.Range(0, level1Passwords.Length);
           level = 1;
           password = level1Passwords[index];
           StartGame();
       } else if (input == "2") {
           int index = Random.Range(0, level2Passwords.Length);
           level = 2;
           password = level2Passwords[index];
           StartGame();
       } else if (input == "3") {
           int index = Random.Range(0, level3Passwords.Length);
           level = 3;
           password = level3Passwords[index];
           StartGame();
       } else {
           Terminal.WriteLine("Please choose a vaild level");
       }
    }


    void StartGame() {
            currentScreen = Screen.Password;
            Terminal.WriteLine("You have chosen level " + level) ;
            Terminal.WriteLine("Please enter password ") ;
           
    }

    void CheckPassword(string input) {
        if (input.ToLower() == password) {
            Terminal.WriteLine("You Have beaten level " + level);
            Terminal.WriteLine("Type menu and choose new level");
        } else {
            Terminal.WriteLine("Try Again");
            currentScreen = Screen.Password;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
