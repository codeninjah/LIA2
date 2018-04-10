﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIA2Version3.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LIA.Admin.Pages.ListItems
{
	public class CreateModel : PageModel
	{
		public IActionResult OnGet()
		{
			return Page();
		}

		private readonly LIA.Data.Services.IDbWriter _db;

		public CreateModel(LIA.Data.Services.IDbWriter db)
		{
			_db = db;
		}

		[BindProperty]
		public ListItem ListItem { get; set; }

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			await _db.AddAsync(ListItem); //LÄGG TILL I SERVICEN
			return RedirectToPage("./Index");
		}

	}
}