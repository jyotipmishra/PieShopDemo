using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
	    private readonly IPieRepository _pieRepository;
	    private readonly ICategoryRepository _categoryRepository;
	    
	    public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
	    {
		    _pieRepository = pieRepository;
			_categoryRepository = categoryRepository;
	    }
	    
	    public ViewResult ListOfPie()
        {
            PieListViewModel pieListView = new PieListViewModel();

			pieListView.Pies = _pieRepository.AllPies;
			pieListView.CurrentCategory = "Cheese Cakes";
	        
	        return View(pieListView);
        }
    }
}