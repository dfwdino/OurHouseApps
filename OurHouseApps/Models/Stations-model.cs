
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Stations
	{

		public Stations()
		{
			
		}


		[Required]
		[DisplayName("Station ID")]
		public int StationID { get; set; }

				[Required]
		[DisplayName("Station Name")]
		public string StationName { get; set; }

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
		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		}}


