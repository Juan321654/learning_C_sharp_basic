using System;
using System.Collections.Generic;

namespace Giraffe
{
  static void example()
  {
    List<Player> players = new List<Player>();

    Player player1 = new Player("Chad");
    Player player2 = new Player("Steve");
    Player player3 = new Player("Lauren");

    players.Add(player1);
    players.Add(player2);
    players.Add(player3);

    // or you can do this:
    players.Add(new Player("Chad"));
    players.Add(new Player("Steve"));
    players.Add(new Player("Lauren"));

  }
}

class Player
{
  public string username;

  public Player(string name)
  {
    username = name;
  }
}