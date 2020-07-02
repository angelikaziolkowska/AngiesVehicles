using AngiesVehicles.Models;
using AngiesVehicles.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngiesVehicles.Helpers
{
    public class InventoryHelper : IInventoryHelper
    {
        private readonly IInventoryService _inventoryService;

        public InventoryHelper(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public InventoryViewModel GetInventoryViewModel()
        {
            var inventory = _inventoryService.GetInventoryResults();

            return new InventoryViewModel()
            {
                InventoryContents = inventory.Select(x => new InventoryItemViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Passengers = x.Passengers,
                    Stock = x.Stock,
                    ImageName = x.ImageName,
                    ManufacturerRefId = x.ManufacturerRefId,
                    ColourRefId = x.ColourRefId,
                    VehicleTypeRefId = x.VehicleTypeRefId,
                    TypeTypeRefId = x.TypeTypeRefId,
                    ManufacturerName = x.Manufacturer.Name,
                    ColourName = x.Colour.Name,
                    VehicleTypeName = x.VehicleType.Name,
                    TypeTypeName = x.TypeType.Name
                }).ToList(),
            };
        }
    }
}