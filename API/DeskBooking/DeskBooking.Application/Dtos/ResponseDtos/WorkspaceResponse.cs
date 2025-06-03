using System;
using System.Collections.Generic;

namespace DeskBooking.Application.Dtos.ResponseDtos
{
    public class WorkspaceResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string PlaceType { get; set; }
        public bool IsAirConditioner { get; set; }
        public bool IsGameRoom { get; set; }
        public bool IsWiFi { get; set; }
        public bool IsCoffee { get; set; }
        public bool IsMicrophones { get; set; }
        public bool IsHeadphones { get; set; }
        public int PlaceTypeId { get; set; }

        public List<string> PictureURLs { get; set; }
        public Dictionary<int,int> Capacities { get; set; }
    }
}
