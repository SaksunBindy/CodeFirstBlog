using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Views.Game
{
    public class SpotController : Controller
    {
        public SpotService SpotService { get; set; }
        public SpotController(SpotService spotService)
        {
            SpotService = spotService;
        }
        public IActionResult Index()
        {
            List<Spot> allSpots = SpotService.GetAllSpots();
            return View(allSpots);
        }


        public IActionResult AddSpot()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSpot(Spot spot)
        {
            SpotService.AddSpot(spot);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(Guid Id)
        {
            Spot spotToBeEdited = SpotService.GetSpotFromId(Id);
            return View(spotToBeEdited);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed(Spot newSpot)
        {
            SpotService.DeleteSpot(newSpot.Id);
            AddSpot(newSpot);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(Guid Id)
        {
            Spot spotToBeDeleted = SpotService.GetSpotFromId(Id);
            return View(spotToBeDeleted);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid Id)
        {
            Spot spotToBeDeleted = SpotService.GetSpotFromId(Id);
            SpotService.DeleteSpot(Id);
            return RedirectToAction(nameof(Index));
        }



    }
}
