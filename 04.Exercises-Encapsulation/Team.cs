using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    private string name;
    private double rating;
    private List<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ApplicationException($"A name should not be empty.");
            }
            this.name = value;
        }
    }

    public double Rating
    {
        get
        {
            double rating = players.Sum(x => x.Stats);
            return Math.Round(rating);
        }
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    public void RemovePlayer(string playerName)
    {
        if (players.Any(x => x.Name == playerName))
        {
            Player currentPlayer = players.First(x => x.Name == playerName);
            players.Remove(currentPlayer);
        }
        else
        {
            throw new ApplicationException($"Player {playerName} is not in {this.name} team.");
        }
    }

}