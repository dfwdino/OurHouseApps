
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Weight
	{

		public Weight()
		{
			
		}


		[Required]
		[DisplayName("Weight ID")]
		public int WeightID { get; set; }

		[DisplayName("Size ID")]
		public int SizeID { get; set; }

		[DisplayName("Pound")]
		public int Pound { get; set; }

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


