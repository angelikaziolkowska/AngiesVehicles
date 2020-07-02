using System.Collections.Generic;

namespace AngiesVehicles.Models
{
    public class InventoryViewModel
    {
        public List<InventoryItemViewModel> InventoryContents { get; set; }
    }

    public class InventoryItemViewModel
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Quantity of the product in cart
        /// </summary>
        public int Passengers { get; set; }

        /// <summary>
        /// Quantity of the product in cart
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Name of the image as it is saved
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Foreign key for the manufacturer
        /// </summary>     
        public int? ManufacturerRefId { get; set; }

        /// <summary>
        /// Foreign key for the colour
        /// </summary>     
        public int? ColourRefId { get; set; }

        /// <summary>
        /// Foreign key for the manufacturer
        /// </summary>     
        public int? VehicleTypeRefId { get; set; }

        /// <summary>
        /// Foreign key for the manufacturer
        /// </summary>     
        public int? TypeTypeRefId { get; set; }

        /// <summary>
        /// Name of the manufacturer
        /// </summary>
        public string ManufacturerName { get; internal set; }

        /// <summary>
        /// The name of the colour
        /// </summary>
        public string ColourName { get; internal set; }

        /// <summary>
        /// The vehicle type name
        /// </summary>
        public string VehicleTypeName { get; internal set; }

        /// <summary>
        /// The name of the type type
        /// </summary>
        public string TypeTypeName { get; internal set; }
    }
}