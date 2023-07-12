﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Fiorello.Areas.admin.ViewModels.User
{
	public class UserUpdateVM
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Fullname { get; set; }
		[Required]
		public string Country { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string PhoneNumber { get; set; }

		[DataType(DataType.Password)]
		public string? Password { get; set; }

		[Compare(nameof(Password))]
		[DataType(DataType.Password)]
		public string? ConfirmPassword { get; set; }

		public List<SelectListItem>? Roles { get; set; }
		public List<string> RolesIds { get; set; }
	}
}
