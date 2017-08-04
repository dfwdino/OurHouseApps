
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Reminders
	{

		public Reminders()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Deleted")]
		public bool Deleted { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

				[Required]
		[DisplayName("Start Date")]
		public DateTime StartDate { get; set; }

		[DisplayName("End Date")]
		public DateTime EndDate { get; set; }

				[Required]
		[DisplayName("Action ID")]
		public int ActionID { get; set; }

				[Required]
		[DisplayName("Remeber Type")]
		public int RemeberType { get; set; }

				[Required]
		[DisplayName("Every")]
		public int Every { get; set; }

		}}


