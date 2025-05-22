using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Interfaces;
using BusinessLogicLayer.Interface;
namespace BusinessLogicLayer
{
    public class catMotivoBLL : IcatMotivoBLL
    {
        private readonly ICatMotivosDA data;

        public catMotivoBLL(ICatMotivosDA interfaceData)
        {
            data = interfaceData;
        }

        public List<catMotivos> Select(int? Id)
        {
            return data.Select(Id);
        }
    }
}
