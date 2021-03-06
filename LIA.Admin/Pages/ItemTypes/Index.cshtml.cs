﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIA.Data.Services;
using LIA2Version3.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LIA.Admin.Pages.ItemTypes
{
    public class IndexModel : PageModel
    {
		//public string text;
		IDbReader _db;
		public IList<ItemType> ItemType { get; set; }


		public IndexModel(IDbReader db)
		{
			//text = "Hello WOrld";
			_db = db;
		}

		public void OnGet()
		{
			ItemType = _db.Get<ItemType>().ToList();
		}
	}
}