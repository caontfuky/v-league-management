using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using DataTransferObject;

namespace PresentationLayer.Global
{
    public class FixtureAutoCreates : Singleton<FixtureAutoCreates>
    {
        private int _totalRounds;
        private int _matchsPerRound;
        private Dictionary<int, Dictionary<int, Dictionary<int, int>>> _rounds;
        private List<DTOTeam> _listTeam;

        public FixtureAutoCreates()
        {
            _totalRounds = 0;
            _matchsPerRound = 0;
            _listTeam = null;
            _rounds = new Dictionary<int, Dictionary<int, Dictionary<int, int>>>();
        }

        public void AutoCreateFixture(int teams)
        {
            if (this._rounds.Count != 0)
            {
                this._rounds.Clear();
            }
            Dictionary<int, Dictionary<int, int>> matchOfRounds;
            Dictionary<int, int> matchValue;
            this._totalRounds = teams - 1;
            this._matchsPerRound  = teams / 2;

            for (int round = 0; round < this._totalRounds; round++)
            {
                matchOfRounds = new Dictionary<int, Dictionary<int, int>>();
                for (int match = 0; match < this._matchsPerRound; match++)
                {
                    matchValue = new Dictionary<int, int>();
                    int home = (round + match) % (teams - 1);
                    int away = (teams - 1 - match + round) % (teams - 1);
                    if (match == 0)
                    {
                        away = teams - 1;
                    }

                    matchValue.Add(home, away);
                    matchOfRounds.Add(match, matchValue);
                }
                this._rounds.Add(round + 1, matchOfRounds);
            }
        }

        public ArrayList GetValue(List<DTOTeam> listTeam)
        {
            this.AutoCreateFixture(listTeam.Count);
            NestedRecords fixture = new NestedRecords();
            foreach (KeyValuePair<int, Dictionary<int, Dictionary<int, int>>> round in this._rounds)
            {
                RoundRecord roundRecord = new RoundRecord();
                RoundValueRecord roundValue = new RoundValueRecord();
                roundRecord.Name = "Vòng" + round.Key;
                foreach (KeyValuePair<int, Dictionary<int, int>> matchs in round.Value)
                {
                    foreach (KeyValuePair<int, int> match in matchs.Value)
                    {
                        ChildRecordMatch matchValue = new ChildRecordMatch();
                        DTOTeam homeTeam = listTeam[match.Key];
                        DTOTeam visitingTeam = listTeam[match.Value];
                        if (homeTeam != null)
                        {
                            matchValue.HomeTeam = listTeam[match.Key].name;
                        }
                        if (visitingTeam != null)
                            matchValue.VisitingTeam = listTeam[match.Value].name;
                        roundValue.Add(matchValue);
                    }
                }
                roundRecord.Match = roundValue;
                fixture.Add(roundRecord);
            }
            return fixture;
        }

        void gfixture(int teams)
        {
            int totalRounds = teams - 1;
            int matchesPerRound = teams / 2;
            String[][] rounds = new String[totalRounds][];
            for (int i = 0; i < totalRounds; i++)
            {
                rounds[i] = new String[matchesPerRound];
            }

            for (int round = 0; round < totalRounds; round++)
            {
                for (int match = 0; match < matchesPerRound; match++)
                {
                    int home = (round + match) % (teams - 1);
                    int away = (teams - 1 - match + round) % (teams - 1);
                    if (match == 0)
                    {
                        away = teams - 1;
                    }
                    rounds[round][match] = "Team:" + (home + 1) + " v Team:" + (away + 1);
                }
            }
            // Interleave so that home and away games are fairly evenly dispersed.
            String[][] interleaved = new String[totalRounds][];
            for (int i2 = 0; i2 < totalRounds; i2++)
            {
                interleaved[i2] = new String[matchesPerRound];
            }
            int evn = 0;
            int odd = (teams / 2);
            for (int i = 0; i < rounds.Length; i++)
            {
                if (i % 2 == 0)
                {
                    interleaved[i] = rounds[evn++];
                }
                else
                {
                    interleaved[i] = rounds[odd++];
                }
            }
            rounds = interleaved;
            for (int round = 0; round < rounds.Length; round++)
            {
                if (round % 2 == 1)
                {
                    rounds[round][0] = flip(rounds[round][0]);
                }
            }
            //// Display the fixtures
            //lst.Items.Clear();
            //lst2.Items.Clear();
            //for (int i = 0; i < rounds.Length; i++)
            //{
            //    lst.Items.Add("------");
            //    lst.Items.Add("Match Day:" + (i + 1));
            //    for (int j = 0; j < matchesPerRound; j++)
            //        lst.Items.Add(rounds[i][j]);
            //}
            //try
            //{
            //    if (Convert.ToInt32(textBox2.Text) == 2)
            //    {
            //        for (int round = 0; round < rounds.Length; round++)
            //            for (int j = 0; j < matchesPerRound; j++)
            //                rounds[round][j] = flip(rounds[round][j]);

            //        for (int i = 0; i < rounds.Length; i++)
            //        {
            //            lst2.Items.Add("------");
            //            lst2.Items.Add("Match Day:" + (i + rounds.Length + 1));
            //            for (int j = 0; j < matchesPerRound; j++)
            //                lst2.Items.Add(rounds[i][j]);
            //        }
            //    }
            //}
            //catch { MessageBox.Show("Invalid Input"); }
        }

        private static String flip(String match)
        {
            String[] components = match.Split('v');
            return components[1] + " v " + components[0];
        }
    }
}
