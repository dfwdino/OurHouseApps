
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class People
	{

		public People()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

				[Required]
		[DisplayName("Person Name")]
		public string PersonName { get; set; }

		[DisplayName("Username")]
		public string Username { get; set; }

		[DisplayName("Password")]
		public string Password { get; set; }

		[DisplayName("Salt Hash")]
		public string SaltHash { get; set; }

		[DisplayName("Delete")]
		public bool Delete { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		}}


