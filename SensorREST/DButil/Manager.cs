using ModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SensorREST.DButil
{
    public class Manager
    {
        //List<SensorData> liste = new List<SensorData>();
        public IEnumerable<SensorData> Get()
        {
            //return liste;
            return null;
        }

        public IActionResult Get(int id)
        {
            return null;

        }
    }
}
