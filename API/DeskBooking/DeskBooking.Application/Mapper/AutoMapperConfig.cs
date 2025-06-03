using System;

namespace DeskBooking.Application.Mapper
{
    public class AutoMapperConfig
    {
        public static Type[] RegisterMappings()
        {
            return new Type[]
            {
                 typeof(DomainToResponseProfile)
            };
        }

    }
}
