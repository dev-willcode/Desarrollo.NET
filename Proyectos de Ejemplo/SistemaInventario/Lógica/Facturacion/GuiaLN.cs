﻿using System;
using System.Collections.Generic;
using Datos;
using Datos.Facturacion;
using Entidades.Facturacion;

namespace Lógica.Facturacion
{
    public class GuiaLN
    {
        public List<Guia> MostrarGuiaFitro(string busqueda)
        {
            List<Guia> Lista = new List<Guia>();
            Guia oc;
            try
            {
                List<SP_ListarGuia_FiltroResult> auxLista = GuiaCD.ListarGuiaFiltro(busqueda);
                foreach (SP_ListarGuia_FiltroResult aux in auxLista)
                {

                    oc = new Guia(
                        aux.IdGuia,
                        aux.IdLocal,
                        aux.FechaSalida,
                        aux.Transportista,
                        aux.Total.GetValueOrDefault(),
                        aux.cantidad_Item.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Guia.", ex);
            }
            return Lista;
        }
        public List<Guia> MostrarGuia()
        {
            List<Guia> Lista = new List<Guia>();
            Guia oc;
            try
            {
                List<GUIA> auxLista = GuiaCD.ListarGuia();
                foreach (GUIA aux in auxLista)
                {

                    oc = new Guia(
                        aux.IdGuia,
                        aux.IdLocal,
                        aux.FechaSalida,
                        aux.Transportista,
                        aux.Total.GetValueOrDefault(),
                        aux.cantidad_Item.GetValueOrDefault());
                    Lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al listar Guia.", ex);
            }
            return Lista;
        }
        public bool CreateGuia(Guia oc)
        {
            try
            {
                GuiaCD.InsertarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al crear Guia.", ex);
            }
        }
        public bool UpdateGuia(Guia oc)
        {
            try
            {
                GuiaCD.ActualizarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al Actualizar Guia.", ex);
            }
        }

        public bool DeleteGuia(Guia oc)
        {
            try
            {
                GuiaCD.EliminarGuia(oc);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al eliminar Guia.", ex);
            }
        }
    }
}
