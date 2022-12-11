﻿using KCK_WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCK_WinForms
{
    public class Team
    {
        public List<Player> PlayerList = new List<Player>();
        public TeamData teamData = new TeamData();
        public Formation formation { get; set; }
        public string Nationality { get; set; }
        public int points { get; set; }
        public int goalsScored { get; set; }
        public int goalsLost { get; set; }
        public int goalsDiff { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int loses { get; set; }

        public void initTeamData()
        {
            for(int i = 0; i<11; i++)
            {
                teamData.comboBoxIndexes.Add(-1);
            }
        }
        public Team(Formation formation,string Nationality)
        {
            this.formation = formation;
            this.Nationality = Nationality;
            initTeamData();
        }
        public Team()
        {
            initTeamData();
        }


        public void addPlayer(Player p)
        {
            PlayerList.Add(p);
        }

        public void removePlayer(Player p)
        {
            PlayerList.Remove(p);
        }

    }
}
