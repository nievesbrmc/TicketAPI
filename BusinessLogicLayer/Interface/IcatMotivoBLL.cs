using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IcatMotivoBLL
    {
        /// <summary>
        /// obtiene una lista de cat motivos hola
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<catMotivos> Select(int? Id);
    }
}
