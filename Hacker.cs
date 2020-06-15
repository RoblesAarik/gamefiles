using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
        
    }

    void ShowMainMenu() {
        Terminal.ClearScreen();
        
        
        Terminal.WriteLine("What would you like to hack?");

        Terminal.WriteLine("Press 1 to hack S.T.A.R Labs");
        Terminal.WriteLine("Press 2 to hack the Batcave");
        Terminal.WriteLine("Press 3 to hack the Hall of Justice");

        Terminal.WriteLine("Enter selection: ");
    }

    
    int level;

    void OnUserInput(string input)
	{
       if (input == "1") {
           level = 1;
           StartGame();
       } else if (input == "2") {
           level = 2;
           StartGame();
       } else if (input == "3") {
           level = 3;
           StartGame();
       } else if (input == "menu"){
          ShowMainMenu();
       } else {
           Terminal.WriteLine("Please choose a vaild level");
       }
        
	}

    void StartGame() {
    
            Terminal.WriteLine("You have chosen level " + level) ;
            Terminal.WriteLine("Please enter password ") ;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
