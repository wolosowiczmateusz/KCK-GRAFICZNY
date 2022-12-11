using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCK_WinForms
{
    public class Match
    {
        // true grupa, false turniej
        public bool group;
        public bool PlayedInGroup = false;
        public bool PlayedInPlayoff = false;
        public Team teamA { get; set; }
        public Team teamB { get; set; }

        public Formation formationA, formationB;

        public double teamA_OVR, teamB_OVR;
                                       
        public double teamAgoalChance = 0.017;
        public double teamBgoalChance = 0.017;

        public double teamA_GK_OVR, teamB_GK_OVR = 0;
        public double teamA_DEF_OVR, teamB_DEF_OVR = 0;
        public double teamA_MID_OVR, teamB_MID_OVR = 0;
        public double teamA_ST_OVR, teamB_ST_OVR = 0;
        public int teamAPlayerHighestOVR = 0;
        public int teamBPlayerHighestOVR = 0;
        // 1 to teamA, 2 to teamB
        public int scoreA, scoreB = 0;
        public int scoreApen = 0;
        public int scoreBpen = 0;
        public int winner = 0;
        public Label label { get; set; }
        public int speed = 0;

        public Match(Team teamA, Team teamB, bool group, Label label, int speed)
        {
            this.teamA = teamA;
            this.teamB = teamB;
            formationA = this.teamA.formation;
            formationB = this.teamB.formation;
            this.group = group;
            this.label = label;
            this.speed = speed;
        }
        public Match(Team teamA, Team teamB, bool group)
        {
            this.teamA = teamA;
            this.teamB = teamB;
            formationA = this.teamA.formation;
            formationB = this.teamB.formation;
            this.group = group;
            this.label = label;
        }
        public Match() { }

        public void startMatch()
        {
            if (teamA.PlayerList.Count < 11 || teamB.PlayerList.Count < 11)
            {
                MessageBox.Show("Nie można rozegrać meczu, drużyny są niepełne");
            }
            else
            {
                foreach(var p in teamA.PlayerList)
                {
                    p.setLineAndSplit();
                }
                calc_GK_OVR();
                calc_DEF_OVR();
                calc_MID_OVR();
                calc_ST_OVR();
                calc_OVR();

                calcFinalGC();
                if (group == true)
                {
                    RegularMatch();
                }
                else
                {
                    TournamentMatch();
                }


            }
        }

        public void startMatchFast()
        {
            if (teamA.PlayerList.Count < 11 || teamB.PlayerList.Count < 11)
            {
                Console.WriteLine("nie można rozegrać meczu, bo drużyny są niepełne");
            }
            else
            {
                foreach (var p in teamA.PlayerList)
                {
                    p.setLineAndSplit();
                }
                calc_GK_OVR();
                calc_DEF_OVR();
                calc_MID_OVR();
                calc_ST_OVR();
                calc_OVR();

                calcFinalGC();
                if (group == true)
                {
                    RegularMatchFast();
                }
                else
                {
                    TournamentMatchFast();
                }
            }
        }

        public void SetPointsAndWins()
        {
            if (scoreA > scoreB)
            {
                winner = 1;
                teamA.goalsScored += scoreA;
                teamA.goalsLost += scoreB;

                teamB.goalsScored += scoreB;
                teamB.goalsLost += scoreA;

                teamA.points += 3;
                teamB.points += 0;

                teamA.wins++;
                teamB.loses++;
            }
            if (scoreA < scoreB)
            {
                winner = 2;
                teamA.goalsScored += scoreA;
                teamA.goalsLost += scoreB;

                teamB.goalsScored += scoreB;
                teamB.goalsLost += scoreA;

                teamA.points += 0;
                teamB.points += 3;

                teamA.loses++;
                teamB.wins++;
            }
            if (scoreA == scoreB)
            {
                winner = 0;
                teamA.goalsScored += scoreA;
                teamA.goalsLost += scoreB;

                teamB.goalsScored += scoreB;
                teamB.goalsLost += scoreA;
     
                teamA.points += 1;
                teamB.points += 1;
                teamA.draws++;
                teamB.draws++;
            }
        }

        public void RegularMatch()
        {
            for(int i = 1; i < 45; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j<60; j+=speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(3);
                }
                label.Text = ("45" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }

            MessageBox.Show("Koniec pierwszej połowy! Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3) + "\nWciśnij ok aby kontynuować");
            

            for (int i = 45; i < 90; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j < 60; j += speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(1);
                }
                label.Text = ("90" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }
            SetPointsAndWins();
        }
        public void RegularMatchFast()
        {
            for (int i = 1; i < 46; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }
            for (int i = 45; i < 91; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }
            label.Text = ("Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            SetPointsAndWins();
        }
        
        public void TournamentMatch()
        {
            for (int i = 1; i < 45; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j < 60; j += speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(1);
                }
                label.Text = ("45" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }

            MessageBox.Show("Koniec pierwszej połowy! Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3) + "\nWciśnij ok aby kontynuować");


            for (int i = 45; i < 90; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j < 60; j += speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(1);
                }
                label.Text = ("90" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }
            SetPointsAndWins();
            if (winner == 0)
            {
                MessageBox.Show("Koniec meczu\nNaciśnij OK aby zacząć dogrywkę");
                Overtime();
            }
        }
        public void TournamentMatchFast()
        {
            for (int i = 1; i < 46; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }
            for (int i = 45; i < 91; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }
            label.Text = ("Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            SetPointsAndWins();
            if(winner == 0)
            {
                OvertimeFast();
            }
            else {}
        }

        public void Overtime()
        {
            for (int i = 90; i < 105; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j < 60; j += speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(1);
                }
                label.Text = ("105" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }
            MessageBox.Show("Koniec pierwszej połowy dogrywki! Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3) + "\nWciśnij ok aby kontynuować");

            for (int i = 105; i < 120; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
                for (int j = 0; j < 60; j += speed)
                {
                    string second = j.ToString();
                    if (j < 10)
                    {
                        second = "0";
                        second += j;
                    }
                    label.Text = (i + ":" + second + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
                    Wait(1);
                }
                label.Text = ("120" + ":" + "00" + "  " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3));
            }

            if(scoreA == scoreB)
            {
                MessageBox.Show("Koniec dogrywki. Naciśnij OK aby rozpocząć karne");
                Penalties();
            }

            else
            {
                SetPointsAndWins();
            }
        }
        public void OvertimeFast()
        {
            for (int i = 90; i < 106; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 10000);
                rnd = rnd / 10000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 10000);
                rnd = rnd / 10000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }

            for (int i = 105; i < 121; i++)
            {
                Random rand = new Random();
                float rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamAgoalChance)
                {
                    scoreA++;
                }
                rnd = rand.Next(1, 100000);
                rnd = rnd / 100000;
                if (rnd < teamBgoalChance)
                {
                    scoreB++;
                }
            }
            
            if (scoreA == scoreB)
            {
                PenaltiesFast();
            }
            else
            {
                
                label.Text = ("Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB + " " + teamB.Nationality.Substring(0, 3)+" po dogrywce");
                SetPointsAndWins();
            }
        }

        public void Penalties()
        {

            Random rand = new Random();
            float rnd;
            for (int i = 0; i<5; i++)
            {
                rnd = rand.Next(1, 100);
                if(rnd < 77)
                {
                    scoreApen++;
                    label.Text = (teamA.Nationality.Substring(0, 3) + " " + scoreApen + " : " + scoreBpen + " " + teamB.Nationality.Substring(0, 3));
                    Wait(750);
                }
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreBpen++;
                    label.Text = (teamA.Nationality.Substring(0, 3) + " " + scoreApen + " : " + scoreBpen + " " + teamB.Nationality.Substring(0, 3));
                    Wait(750);
                }

                if (scoreApen > scoreBpen + 5 - i)
                {
                    break;
                }
                else if (scoreBpen > scoreApen + 5 - i)
                {
                    break;
                }
                else
                {
                    label.Text = (teamA.Nationality.Substring(0, 3) + " " + scoreApen + " : " + scoreBpen + " " + teamB.Nationality.Substring(0, 3));
                    Wait(750);
                }
            }
            int tmp = 5;
            while (scoreApen == scoreBpen)
            {
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreApen++;
                }
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreBpen++;
                }
                tmp++;
                label.Text = (teamA.Nationality.Substring(0, 3) + " " + scoreApen + " : " + scoreBpen + " " + teamB.Nationality.Substring(0, 3));
                Wait(750);
            }
            MessageBox.Show("Wynik karnych to: " + scoreApen + " : " + scoreBpen + "\nCałkowity Wynik to: " + (scoreA + scoreApen) + " : " + (scoreB + scoreBpen));
            if (scoreApen > scoreBpen)
            {
                winner = 1;
            }
            else {
                winner = 2; 
            }
        }
        public void PenaltiesFast()
        {
            Random rand = new Random();
            float rnd;
            for (int i = 0; i < 5; i++)
            {
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreApen++;
                }
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreBpen++;
                }

                if (scoreApen > scoreBpen + 5 - i)
                {
                    break;
                }
                else if (scoreBpen > scoreApen + 5 - i)
                {
                    break;
                }
            }
            int tmp = 5;
            while (scoreApen == scoreBpen)
            {
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreApen++;
                }
                rnd = rand.Next(1, 100);
                if (rnd < 77)
                {
                    scoreBpen++;
                }
                tmp++;
            }

            label.Text = ("Wynik: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + " : " + scoreB +" " + teamB.Nationality.Substring(0, 3) + "(" + (scoreA + scoreApen) + ":" + (scoreB + scoreBpen) + ")");

            if (scoreApen > scoreBpen)
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
        }

        //Konćowy opis meczu i wynik
        public void Sumarize()
        {
            if (winner == 0)
            {
                Console.WriteLine("Remis!");
                Console.WriteLine("Wynik to: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + "  " + scoreB + "  " + teamB.Nationality.Substring(0, 3));
            }
            if (winner == 1)
            {
                Console.WriteLine("Wygrała drużyna " + teamA.Nationality);
                Console.WriteLine("Wynik to: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + "  " + scoreB + "  " + teamB.Nationality.Substring(0, 3));

            }
            if (winner == 2)
            {
                Console.WriteLine("Wygrała drużyna " + teamB.Nationality);
                Console.WriteLine("Wynik to: " + teamA.Nationality.Substring(0, 3) + " " + scoreA + "  " + scoreB + "  " + teamB.Nationality.Substring(0, 3));

            }
        }
        public void calcFinalGC() {
            //ustawianie jeżeli najlepszy piłkarz ma więcej ovr niz bramkarz i na odwrót
            int diffBetweenAHighAndBGK = teamAPlayerHighestOVR - Convert.ToInt32(teamB_GK_OVR);
            int diffBetweenBHighAndAGK = teamBPlayerHighestOVR - Convert.ToInt32(teamA_GK_OVR);
            int diffBetweenA_OVR_B_OVR = Convert.ToInt32(teamA_OVR) - Convert.ToInt32(teamB_OVR);

            teamAgoalChance += (diffBetweenAHighAndBGK * 0.0006);
            teamBgoalChance += (diffBetweenBHighAndAGK * 0.0006);

            if(diffBetweenA_OVR_B_OVR > 0)
            {
                teamAgoalChance += (Math.Abs(diffBetweenA_OVR_B_OVR) * 0.00011);
                teamBgoalChance -= (Math.Abs(diffBetweenA_OVR_B_OVR) * 0.00003);
            }
            else
            {
                teamBgoalChance += (Math.Abs(diffBetweenA_OVR_B_OVR) * 0.00011);
                teamAgoalChance -= (Math.Abs(diffBetweenA_OVR_B_OVR) * 0.00003);
            }

        }

        public void calc_GK_OVR()
        {
            foreach (var p in teamA.PlayerList)
            {
                if (p.PosNr == 1)
                {
                    if (p.line == "Goalkeeper")
                    {
                        teamA_GK_OVR = p.Overall;
                    }
                    else
                    {
                        teamA_GK_OVR = p.Overall - 40;
                    }
                }
            }
            foreach (var p in teamB.PlayerList)
            {
                if (p.PosNr == 1)
                {
                    if (p.line == "Goalkeeper")
                    {
                        teamB_GK_OVR = p.Overall;
                    }
                    else
                    {
                        teamB_GK_OVR = p.Overall - 40;
                    }
                }
            }

        }
        public void calc_DEF_OVR()
        {
            for (int i = 2; i < 2 + formationA.DEFCount; i++)
            {
                foreach (var player in teamA.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationA.Positions[i - 1])
                        {
                            teamA_DEF_OVR += player.Overall;
                        }
                        else if (player.BestPosition != formationA.Positions[i - 1] && player.PositionsSplit.Contains(formationA.Positions[i - 1]))
                        {
                            teamA_DEF_OVR += player.Overall-1;
                        }
                        else
                        {
                            if(player.line == "Defender")
                            {
                                teamA_DEF_OVR += player.Overall - 3;
                            }
                            if (player.line == "Midfielder")
                            {
                                teamA_DEF_OVR += player.Overall - 5;
                            }
                            if (player.line == "Striker")
                            {
                                teamA_DEF_OVR += player.Overall - 15;
                            }
                        }
                    }
                }
            }
            if (formationA.Positions.Contains("CDM"))
            {
                teamA_DEF_OVR += 10;
            }

            for (int i = 2; i < 2 + formationB.DEFCount; i++)
            {
                foreach (var player in teamB.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationB.Positions[i - 1])
                        {
                            teamB_DEF_OVR += player.Overall;
                        }
                        else if (player.BestPosition != formationB.Positions[i - 1] && player.PositionsSplit.Contains(formationB.Positions[i - 1]))
                        {
                            teamB_DEF_OVR += player.Overall - 1;
                        }
                        else
                        {
                            if (player.line == "Defender")
                            {
                                teamB_DEF_OVR += player.Overall - 3;
                            }
                            if (player.line == "Midfielder")
                            {
                                teamB_DEF_OVR += player.Overall - 5;
                            }
                            if (player.line == "Striker")
                            {
                                teamB_DEF_OVR += player.Overall - 15;
                            }
                        }
                    }
                }
            }
            if (formationB.Positions.Contains("CDM"))
            {
                teamA_DEF_OVR += 10;
            }

        }
        public void calc_MID_OVR()
        {
            for (int i = 2 + formationA.DEFCount; i < 2 + formationA.DEFCount + formationA.MIDCount; i++)
            {
                foreach (var player in teamA.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationA.Positions[i - 1])
                        {
                            teamA_MID_OVR += player.Overall;
                            if (teamAPlayerHighestOVR < player.Overall)
                            {
                                teamAPlayerHighestOVR = player.Overall;
                            }

                        }
                        else if (player.BestPosition != formationA.Positions[i - 1] && player.PositionsSplit.Contains(formationA.Positions[i - 1]))
                        {
                            teamA_MID_OVR += player.Overall - 1;
                            if (teamAPlayerHighestOVR < player.Overall-1)
                            {
                                teamAPlayerHighestOVR = player.Overall-1;
                            }
                        }
                        else
                        {
                            if (player.line == "Defender")
                            {
                                teamA_MID_OVR += player.Overall - 5;
                                if (teamAPlayerHighestOVR < player.Overall-5)
                                {
                                    teamAPlayerHighestOVR = player.Overall-5;
                                }
                            }
                            if (player.line == "Midfielder")
                            {
                                teamA_MID_OVR += player.Overall - 3;
                                if (teamAPlayerHighestOVR < player.Overall-3)
                                {
                                    teamAPlayerHighestOVR = player.Overall-3;
                                }
                            }
                            if (player.line == "Striker")
                            {
                                teamA_MID_OVR += player.Overall - 5;
                                if (teamAPlayerHighestOVR < player.Overall-5)
                                {
                                    teamAPlayerHighestOVR = player.Overall-5;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 2 + formationB.DEFCount; i < 2 + formationB.DEFCount + formationB.MIDCount; i++)
            {
                foreach (var player in teamB.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationB.Positions[i - 1])
                        {
                            teamB_MID_OVR += player.Overall;
                            if (teamBPlayerHighestOVR < player.Overall)
                            {
                                teamBPlayerHighestOVR = player.Overall;
                            }
                        }
                        else if (player.BestPosition != formationB.Positions[i - 1] && player.PositionsSplit.Contains(formationB.Positions[i - 1]))
                        {
                            teamB_MID_OVR += player.Overall - 1;
                            if (teamBPlayerHighestOVR < player.Overall-1)
                            {
                                teamBPlayerHighestOVR = player.Overall-1;
                            }
                        }
                        else
                        {
                            if (player.line == "Defender")
                            {
                                teamB_MID_OVR += player.Overall - 5;
                                if (teamBPlayerHighestOVR < player.Overall-5)
                                {
                                    teamBPlayerHighestOVR = player.Overall-5;
                                }
                            }
                            if (player.line == "Midfielder")
                            {
                                teamB_MID_OVR += player.Overall - 3;
                                if (teamBPlayerHighestOVR < player.Overall-3)
                                {
                                    teamBPlayerHighestOVR = player.Overall-3;
                                }
                            }
                            if (player.line == "Striker")
                            {
                                teamB_MID_OVR += player.Overall - 5;
                                if (teamBPlayerHighestOVR < player.Overall-5)
                                {
                                    teamBPlayerHighestOVR = player.Overall-5;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void calc_ST_OVR()
        {
            for (int i = 2 + formationA.DEFCount + formationA.MIDCount; i < 12; i++)
            {
                foreach (var player in teamA.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationA.Positions[i - 1])
                        {
                            teamA_ST_OVR += player.Overall;
                            if (teamAPlayerHighestOVR < player.Overall)
                            {
                                teamAPlayerHighestOVR = player.Overall;
                            }
                        }
                        else if (player.BestPosition != formationA.Positions[i - 1] && player.PositionsSplit.Contains(formationA.Positions[i - 1]))
                        {
                            teamA_ST_OVR += player.Overall - 1;
                            if (teamAPlayerHighestOVR < player.Overall - 1)
                            {
                                teamAPlayerHighestOVR = player.Overall - 1;
                            }
                        }
                        else
                        {
                            if (player.line == "Defender")
                            {
                                teamA_ST_OVR += player.Overall - 15;
                                if(teamAPlayerHighestOVR < player.Overall - 15)
                                {
                                    teamAPlayerHighestOVR = player.Overall - 15;
                                }
                            }
                            if (player.line == "Midfielder")
                            {
                                teamA_ST_OVR += player.Overall - 5;
                                if (teamAPlayerHighestOVR < player.Overall - 5)
                                {
                                    teamAPlayerHighestOVR = player.Overall - 5;
                                }
                            }
                            if (player.line == "Striker")
                            {
                                teamA_ST_OVR += player.Overall - 3;
                                if(teamAPlayerHighestOVR < player.Overall - 3)
                                {
                                    teamAPlayerHighestOVR = player.Overall - 3;
                                }

                            }
                        }
                    }
                }
            }

            if (formationA.Positions.Contains("CAM"))
            {
                teamA_ST_OVR += 10;
            }

            for (int i = 2 + formationB.DEFCount + formationB.MIDCount; i < 12; i++)
            {
                foreach (var player in teamB.PlayerList)
                {
                    if (player.PosNr == i)
                    {
                        if (player.BestPosition == formationB.Positions[i - 1])
                        {
                            teamB_ST_OVR += player.Overall;
                            if (teamBPlayerHighestOVR < player.Overall)
                            {
                                teamBPlayerHighestOVR = player.Overall;
                            }
                        }
                        else if (player.BestPosition != formationB.Positions[i - 1] && player.PositionsSplit.Contains(formationB.Positions[i - 1]))
                        {
                            teamB_ST_OVR += player.Overall - 1;
                            if (teamBPlayerHighestOVR < player.Overall-1)
                            {
                                teamBPlayerHighestOVR = player.Overall-1;
                            }
                        }
                        else
                        {
                            if (player.line == "Defender")
                            {
                                teamB_ST_OVR += player.Overall - 15;
                                if (teamBPlayerHighestOVR < player.Overall-15)
                                {
                                    teamBPlayerHighestOVR = player.Overall-15;
                                }
                            }
                            if (player.line == "Midfielder")
                            {
                                teamB_ST_OVR += player.Overall - 5;
                                if (teamBPlayerHighestOVR < player.Overall-5)
                                {
                                    teamBPlayerHighestOVR = player.Overall-5;
                                }
                            }
                            if (player.line == "Striker")
                            {
                                teamB_ST_OVR += player.Overall - 3;
                                if (teamBPlayerHighestOVR < player.Overall-3)
                                {
                                    teamBPlayerHighestOVR = player.Overall-3;
                                }
                            }
                        }
                    }
                }
            }
            if (formationB.Positions.Contains("CAM"))
            {
                teamB_ST_OVR += 10;
            }

        }

        public void calc_OVR()
        {
            teamA_OVR = teamA_DEF_OVR + teamA_MID_OVR + teamA_ST_OVR + teamA_GK_OVR;
            teamB_OVR = teamB_DEF_OVR + teamB_MID_OVR + teamB_ST_OVR + teamB_GK_OVR;
        }

        public string get_GK_OVR()
        {
            string ret = teamA.Nationality + ": " + teamA_GK_OVR + "  " + teamB.Nationality + ": " + teamB_GK_OVR;
            return ret;
        }

        public string get_DEF_OVR()
        {
            string ret = teamA.Nationality + ": " + teamA_DEF_OVR + "  " + teamB.Nationality + ": " + teamB_DEF_OVR;
            return ret;
        }

        public string get_MID_OVR()
        {
            string ret = teamA.Nationality + ": " + teamA_MID_OVR + "  " + teamB.Nationality + ": " + teamB_MID_OVR;
            return ret;
        }

        public string get_ST_OVR()
        {
            string ret = teamA.Nationality + ": " + teamA_ST_OVR + "  " + teamB.Nationality + ": " + teamB_ST_OVR;
            return ret;
        }

        public string get_OVR()
        {
            string ret = teamA.Nationality + ": " + teamA_OVR + "  " + teamB.Nationality + ": " + teamB_OVR;
            return ret;
        }
        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

    }
}
