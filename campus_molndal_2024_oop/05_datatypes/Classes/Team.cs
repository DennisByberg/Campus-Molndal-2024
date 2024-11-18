using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public class Team
    {
        private Player[] _players;
        private int _playerCount;

        public Team(int teamSize)
        {
            _players = new Player[teamSize];
            _playerCount = 0;

        }

        public void AddPlayer(Player player)
        {
            if (_playerCount < _players.Length)
            {
                _players[_playerCount] = player;
                _playerCount++;
            }
        }
        public void ListPlayers()
        {
            for (int i = 0; i < _playerCount; i++)
            {
                Console.WriteLine(_players[i].GetName());
            }
        }
    }
}
