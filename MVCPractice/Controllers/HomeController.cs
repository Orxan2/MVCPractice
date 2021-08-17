using Microsoft.AspNetCore.Mvc;
using MVCPractice.Models;
using MVCPractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Pot1> pot1 = new List<Pot1>
            {
                new Pot1
                {
                    ID=1,
                    Club="PSG",
                    Country="France",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=2,
                    Club="Bayern Munich",
                    Country="Germany",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=3,
                    Club="Liverpool",
                    Country="England",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=4,
                    Club="Juventus",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=5,
                    Club="Zenit",
                    Country="Russia",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=6,
                    Club="Real Madrid",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=7,
                    Club="Porto",
                    Country="Portugal",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=8,
                    Club="Sevilla",
                    Country="Spain",
                    IsSelected=false
                }
            };
            List<Pot2> pot2 = new List<Pot2>
            {
                new Pot2
                {
                    ID=1,
                    Club="Atletico Madrid",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=2,
                    Club="Barcelona",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=3,
                    Club="Ajax",
                    Country="Niderland",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=4,
                    Club="Chelsea",
                    Country="England",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=5,
                    Club="Manchester United",
                    Country="England",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=6,
                    Club="Borussia Dortmund",
                    Country="Germany",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=7,
                    Club="Shakhtar Donetsk",
                    Country="Ukraine",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=8,
                    Club="Feyenord",
                    Country="Niderland",
                    IsSelected=false
                }
            };
            List<Pot3> pot3 = new List<Pot3>
            {
                new Pot3
                {
                    ID=1,
                    Club="Krasnodar",
                    Country="Russia",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=2,
                    Club="Atalanta",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=3,
                    Club="Olympiacos",
                    Country="Greece",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=4,
                    Club="Lazio",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=5,
                    Club="Dinamo Kiev",
                    Country="Ukraine",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=6,
                    Club="Salzburg",
                    Country="Austria",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=7,
                    Club="Inter Milan",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=8,
                    Club="Leipzig",
                    Country="Germany",
                    IsSelected=false
                }
            };
            List<Pot4> pot4 = new List<Pot4>
            {
                new Pot4
                {
                    ID=1,
                    Club="Marseile",
                    Country="France",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=2,
                    Club="Borussia Monchengladbach",
                    Country="Germany",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=3,
                    Club="Fenerbahce",
                    Country="Turkey",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=4,
                    Club="Club Brugge",
                    Country="Belgium",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=5,
                    Club="Midtylland",
                    Country="Denmark",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=6,
                    Club="Locomative Moskwa",
                    Country="Russia",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=7,
                    Club="Rennes",
                    Country="France",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=8,
                    Club="Qarabagh",
                    Country="Azerbaijan",
                    IsSelected=false
                }
            };

            PotsViewModel pots = new PotsViewModel
            {
                FirstPot = pot1,
                SecondPot = pot2,
                ThirdPot = pot3,
                FourthPot = pot4,
            };


            return View(pots);
        }
    }
}
