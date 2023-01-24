using Lab15._1ConsumingAnApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Lab15._1ConsumingAnApi.Controllers
{
    public class CardGame : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1"); // Put the rest of the URL in here
            Deck cards = await response.Content.ReadAsAsync<Deck>();

            response = await client.GetAsync($"/api/deck/{cards.deck_id}/draw/?count=5");
            CardSet cset = await response.Content.ReadAsAsync<CardSet>();
            return View(cset);
        }


        public async Task<IActionResult> CardResult(string deck_id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync($"/api/deck/{deck_id}/draw/?count=5");
           
            CardSet cset = await response.Content.ReadAsAsync<CardSet>();

            return View(cset);
        }
    }
}
