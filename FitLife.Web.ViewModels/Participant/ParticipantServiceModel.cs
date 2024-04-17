using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitLife.Web.ViewModels.Participant
{
	public class ParticipantServiceModel
	{
		[Required]
		public string Id { get; set; } = null!;

        [Required]
		public string FirstName { get; set; } = null!;

		[Required]
		public string LastName { get; set; } = null!;

		[Required]
		public string Email { get; set; } = null!;

       
	}
}
