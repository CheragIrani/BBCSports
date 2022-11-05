using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace BBCWebsite.POM
{
    public class BbcSportsPage
    {
        public IWebDriver _driver;
        public By element => By.CssSelector("");

        public BbcSportsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToSportsPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public List<string> GetListOfFixtures(int numberOfGames)
        {
            List<string> listOfTeams = new List<string>();
            return listOfTeams;
        }

        public List<string> GetListOfTeamsInBottomHalf()
        {
            List<string> listOfTeamsInBottomTen = new List<string>();
            return listOfTeamsInBottomTen;
        }

        public void HighlightFixturesAgainstTeamsInBottomHalf(List<string> listOfTeams, List<string> listOfTeamsInBottomHalf)
        {
            foreach(var team in listOfTeams)
            {
                foreach (var teamInBottomTen in listOfTeamsInBottomHalf)
                {
                    if(team == teamInBottomTen)
                    {
                        Console.WriteLine(team);
                    }
                }
            }
        }
    }
}
