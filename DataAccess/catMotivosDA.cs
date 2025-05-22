using DataAccess.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class catMotivosDA : ICatMotivosDA
    {

        public List<catMotivos> Select(int? Id)
        {
            List<catMotivos> respone;
            try
            {
                /*
                 * conectar ado .net a sql
                 */
                if (Id.HasValue)
                {
                    /*conecta bd y traer el registro*/
                    respone = new List<catMotivos>
                    {
                        new catMotivos{Id=1, Description="motivo1", Active=true }
                    };
                }
                else
                {
                    /*todos los registros de bd */
                    respone = new List<catMotivos>
                    {
                        new catMotivos{Id=1, Description="motivo1", Active=true },
                        new catMotivos{Id=1, Description="motivo2", Active=false },
                        new catMotivos{Id=1, Description="motivo3", Active=true },
                        new catMotivos{Id=1, Description="motivo4", Active=!true },
                    };
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            return respone;
        }

        /* 
         * SOLID
         * Inyeccion de dependencias
         */

        /// <summary>
        /// crea un objeto del tipo cat motivos en base de datos
        /// </summary>
        /// <param name="motives">objeto a crear</param>
        /// <returns>true si se crea o un false si no se crea</returns>
        public bool Create(catMotivos motives)
        {
            bool respone = false;
            try
            {
                /*
                 * conectar ado .net a sql
                 */
                respone = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            return respone;
        }       

        public bool Delete(catMotivos motives)
        {
            bool respone = false;
            try
            {
                /*
                 * conectar ado .net a sql
                 */
                respone = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            return respone;
        }
        public bool Update(catMotivos motives)
        {
            bool respone = false;
            try
            {
                /*
                 * conectar ado .net a sql
                 */
                respone = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            return respone;
        }

    }
}