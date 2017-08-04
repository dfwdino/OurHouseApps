
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace OurHouseApps.Models
{
	public class Items
	{

		public Items()
		{
			
		}


		[Required]
		[DisplayName("ID")]
		public int ID { get; set; }

		[DisplayName("Store ID")]
		public int StoreID { get; set; }

				[Required]
		[DisplayName("Name")]
		public string Name { get; set; }

		[DisplayName("Price")]
		public decimal Price { get; set; }

				[Required]
		[DisplayName("Have")]
		public bool Have { get; set; }

		[DisplayName("Image")]
		public byte[] Image { get; set; }

		[DisplayName("Amount")]
		public string Amount { get; set; }

		[DisplayName("Last Gotten")]
		public DateTime LastGotten { get; set; }

		[DisplayName("Image Location")]
		public string ImageLocation { get; set; }

		[DisplayName("IPAddress")]
		public string IPAddress { get; set; }

		[DisplayName("Longitude")]
		public string Longitude { get; set; }

		[DisplayName("Latitude")]
		public string Latitude { get; set; }

		[DisplayName("Item Size ID")]
		public int ItemSizeID { get; set; }

		}}


