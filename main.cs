using System;

 class Program
 {
    static void Main()
     {
       Console.WriteLine("Witaj w mojej grze!");
       GameLoop gameLoop = new GameLoop();
       gameLoop.startGame();
       
       Console.WriteLine("Dzięki za grę!");
     }
 }

 class GameLoop
 {
    public Player player1;
    public Player player2;

    public void startGame()
    {
      bool stopWholeGame = true;
      while(stopWholeGame){
        Console.WriteLine("Podaj limit wygranych:");
        int limitWygranych = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj imie pierwszego gracza");
        player1 = new Player();
        player1.score = 0;
        player1.name = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Podaj imie drugiego gracza");
        player2 = new Player();
        player2.score = 0;
        player2.name = Console.ReadLine();
        Console.Clear();

        Weapon kamien = new Weapon();
        kamien.id = 0;
        kamien.weakness = 2;
        kamien.name = "kamien";
        Weapon nozyce = new Weapon();
        nozyce.id = 1;
        nozyce.weakness = 0;
        nozyce.name = "nozyce";
        Weapon papier = new Weapon();
        papier.id = 2;
        papier.weakness = 1;
        papier.name = "papier";

        while(limitWygranych != player1.score && limitWygranych != player2.score){
          Console.WriteLine("Gracz " + player1.name + "! Wybierz swoją broń!");
          Console.WriteLine("0 - Kamień");
          Console.WriteLine("1 - Nożyce");
          Console.WriteLine("2 - Papier");
          int nrBroni1 = Convert.ToInt32(Console.ReadLine());
          switch(nrBroni1){
            case 0:
              player1.weapon = kamien;
              break;
            case 1:
              player1.weapon = nozyce;
              break;
            case 2:
              player1.weapon = papier;
              break;
          }
          Console.Clear();

          Console.WriteLine("Gracz " + player2.name + "! Wybierz swoją broń!");
          Console.WriteLine("0 - Kamień");
          Console.WriteLine("1 - Nożyce");
          Console.WriteLine("2 - Papier");
          int nrBroni2 = Convert.ToInt32(Console.ReadLine());
          switch(nrBroni2){
            case 0:
              player2.weapon = kamien;
              break;
            case 1:
              player2.weapon = nozyce;
              break;
            case 2:
              player2.weapon = papier;
              break;
          }
          Console.Clear();

          if(player1.weapon.weakness == player2.weapon.id){
            player2.score += 1;
            Console.WriteLine("Wygral gracz " + player2.name + "!");
          } else if(player2.weapon.weakness == player1.weapon.id){
            player1.score += 1;
            Console.WriteLine("Wygral gracz " + player1.name + "!");
          } else {
            Console.WriteLine("Remis!");
          }
          
          Console.WriteLine("Wynik: ");
          Console.WriteLine("Gracz " + player1.name + " " + player1.score + ":" + player2.score + " Gracz " + player2.name);
          if(player2.score == limitWygranych){
            Console.WriteLine("=======================");
            Console.WriteLine("Całą grę wygrał gracz " + player2.name);
            Console.WriteLine("=======================");            
          } else if(player1.score == limitWygranych){
            Console.WriteLine("=======================");
            Console.WriteLine("Całą grę wygrał gracz " + player1.name);
            Console.WriteLine("=======================");
          }
          Console.WriteLine("");
          Console.WriteLine("Kliknij dowolny klawisz aby kontynuowac!");
          Console.ReadLine();
          Console.Clear();
        }
        Console.WriteLine("Gra zakonczona! Kliknij dowolny klawisz aby kontynuowac!");
      }
    }
 }

 class Player
 {
    public String name;
    public int score = 0;
    public Weapon weapon = new Weapon();
 }

 class Weapon
 {
    public String name;
    public int id = 0;
    public int weakness;
 }