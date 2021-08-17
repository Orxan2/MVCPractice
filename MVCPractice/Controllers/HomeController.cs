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
                    Club="Lille",
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
                    Club="Manchester City",
                    Country="England",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=4,
                    Club="Inter Milan",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=5,
                    Club="Chelsea",
                    Country="England",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=6,
                    Club="Villareal",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=7,
                    Club="Sporting Lisbon",
                    Country="Portugal",
                    IsSelected=false
                },
                new Pot1
                {
                    ID=8,
                    Club="Atletico Madrid",
                    Country="Spain",
                    IsSelected=false
                }
            };
            List<Pot2> pot2 = new List<Pot2>
            {
                new Pot2
                {
                    ID=1,
                    Club="Real Madrid",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=2,
                    Club="Juventus",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=3,
                    Club="PSG",
                    Country="France",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=4,
                    Club="Sevilla",
                    Country="Spain",
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
                    Club="Leipzig",
                    Country="Germany",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=7,
                    Club="Barcelona",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot2
                {
                    ID=8,
                    Club="Liverpool",
                    Country="England",
                    IsSelected=false
                }
            };
            List<Pot3> pot3 = new List<Pot3>
            {
                new Pot3
                {
                    ID=1,
                    Club="Porto",
                    Country="Portugal",
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
                    Club="Ajax",
                    Country="Niderland",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=4,
                    Club="Benfica",
                    Country="Portugal",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=5,
                    Club="Shakthar Donetsk",
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
                    Club="Barcelona",
                    Country="Spain",
                    IsSelected=false
                },
                new Pot3
                {
                    ID=8,
                    Club="Wolfsburg",
                    Country="Germany",
                    IsSelected=false
                }
            };
            List<Pot4> pot4 = new List<Pot4>
            {
                new Pot4
                {
                    ID=1,
                    Club="Milan",
                    Country="Italy",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=2,
                    Club="Young Boys",
                    Country="Switzerland",
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
                    Club="Dinamo Kiev",
                    Country="Ukraine",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=6,
                    Club="Zenit",
                    Country="Russia",
                    IsSelected=false
                },
                new Pot4
                {
                    ID=7,
                    Club="Dinamo Zagreb",
                    Country="Croatia",
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
