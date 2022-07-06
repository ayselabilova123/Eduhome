using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using DAL.Models;
using Exceptions.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Utilities.Helpers;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
               
                var data = await _sliderService.GetAll();
                return View(data);
            }
            catch (EntityIsNullException ex)
            {
                return Json(new
                {
                   status = (int)Enums.Statuses.DataIsNull,
                   message = ex.Message
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    status = (int)Enums.Statuses.GenerelError,
                    message = ex.Message
                });
            }
           
        }



    }
}