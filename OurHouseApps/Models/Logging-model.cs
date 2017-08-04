
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Logging
	{

		public Logging()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Date")]
		public DateTime Date { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Controller Name")]
		public string ControllerName { get; set; }

		[DisplayName("Action Name")]
		public string ActionName { get; set; }

		[DisplayName("Action Parameters")]
		public string ActionParameters { get; set; }

		[DisplayName("Absolute Uri")]
		public string AbsoluteUri { get; set; }

		[DisplayName("Notes")]
		public string Notes { get; set; }

		}}


