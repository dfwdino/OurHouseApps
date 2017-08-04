
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Size
	{

		public Size()
		{
			
		}


		[Required]
		[DisplayName("Size ID")]
		public int SizeID { get; set; }

				[Required]
		[DisplayName("People ID")]
		public int PeopleID { get; set; }

		[DisplayName("Wrist")]
		public int Wrist { get; set; }

		[DisplayName("Chest")]
		public int Chest { get; set; }

		[DisplayName("Forearm")]
		public int Forearm { get; set; }

		[DisplayName("Waist")]
		public int Waist { get; set; }

		[DisplayName("Thigh")]
		public int Thigh { get; set; }

		[DisplayName("Hip")]
		public int Hip { get; set; }

		[DisplayName("Calve")]
		public int Calve { get; set; }

		[DisplayName("Bicep")]
		public int Bicep { get; set; }

		[DisplayName("Neck")]
		public int Neck { get; set; }

		[DisplayName("Notes")]
		public string Notes { get; set; }

				[Required]
		[DisplayName("Created On")]
		public DateTime CreatedOn { get; set; }

		[DisplayName("Updated On")]
		public DateTime UpdatedOn { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Broswer")]
		public string Broswer { get; set; }

				[Required]
		[DisplayName("Status Date")]
		public DateTime StatusDate { get; set; }

		}}


