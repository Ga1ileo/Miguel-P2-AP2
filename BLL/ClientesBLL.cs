using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Miguel_P2_AP2.DAL;
using Miguel_P2_AP2.Models;

namespace Miguel_P2_AP2.BLL
{
    public class ClientesBLL
    {
        public static List<Clientes> GetList()
        {
            List<Clientes> lista = new List<Clientes>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Clientes.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }
    }
}
