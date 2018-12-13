using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class ParkingException : Exception
    {
    }

    public class VehicleAlreadyParkedException : ParkingException
    {
    }

    public class VehicleNotParkedException : ParkingException
    {
    }

    public class NoVacancyException : ParkingException
    {
    }

    public class ValetAlreadyHiredException : ParkingException
    {
    }

    public class ValetNotHiredException : ParkingException
    {
    }

    public class NoValetsAvailableException : ParkingException
    {
    }

    public class BusyValetException : ParkingException
    {
    }
}
