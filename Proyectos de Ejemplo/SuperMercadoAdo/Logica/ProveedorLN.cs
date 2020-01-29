using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProveedorLN
    {
        public List<Proveedor> ListarProveedores(string parametro)
        {
            List<Proveedor> ListPro = new List<Proveedor>();
            try
            {
                string prAlmacenado = "cp_ListaProveedoresFiltro";
                DatosConexion db = new DatosConexion();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                db.AsignarParametroCadenaSP("@valor", parametro);
                DbDataReader datos = db.EjecutarConsulta();
                Proveedor p = null;

                while (datos.Read())
                {
                    try
                    {
                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                        ListPro.Add(p);
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener las Categorias.", ex);
            }
            return ListPro;
        }

        public Proveedor consultarProvedorId(int parametro)
        {
            Proveedor p = null;
            try
            {
                string prAlmacenado = "cp_ListarProveedorId";
                DatosConexion db = new DatosConexion();
                db.Conectar();
                db.CrearComandoSP(prAlmacenado);
                db.AsignarParametroEnteroSP("@id", parametro);
                DbDataReader datos = db.EjecutarConsulta();


                while (datos.Read())
                {
                    try
                    {
                        p = new Proveedor(datos.GetInt32(0), datos.GetString(1), datos.GetString(2), datos.GetString(3), datos.GetString(4), datos.GetString(5), datos.GetString(6), datos.GetString(7));
                    }
                    catch (Exception ex)
                    {
                        throw new ReglasExcepciones("Los tipos no coinciden.", ex);
                    }

                }
                datos.Close();
                db.Desconectar();
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error a obtener las categorias.", ex);
            }
            return p;
        }

        public bool InsertarProveedor(Proveedor prov)
        {
            DatosConexion db = new DatosConexion();
            try
            {
                db.Conectar();
                string paName = "cp_InsertarProveedor";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@IdProveedor", prov.IdProveedor);
                db.AsignarParametroCadenaSP("@CedProveedor", prov.Cedula);
                db.AsignarParametroCadenaSP("@Nombre", prov.Nombre);
                db.AsignarParametroCadenaSP("@Representante", prov.Representante);
                db.AsignarParametroCadenaSP("@Direccion", prov.Direccion);
                db.AsignarParametroCadenaSP("@Ciudad", prov.Ciudad);
                db.AsignarParametroCadenaSP("@Telefono",prov.Telefono);
                db.AsignarParametroCadenaSP("@Fax", prov.Fax);
                db.EjecutarComando();
                return true;
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al insertar Proveedor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }
        public bool ActualizarProveedor(Proveedor prov)
        {
            DatosConexion db = new DatosConexion();
            try
            {
                db.Conectar();
                string paName = "cp_ActualizarProveedor";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@IdProveedor", prov.IdProveedor);
                db.AsignarParametroCadenaSP("@Nombre", prov.Cedula);
                db.AsignarParametroCadenaSP("@Representante", prov.Representante);
                db.AsignarParametroCadenaSP("@Direccion", prov.Direccion);
                db.AsignarParametroCadenaSP("@Ciudad", prov.Ciudad);
                db.AsignarParametroCadenaSP("@Telefono", prov.Telefono);
                db.AsignarParametroCadenaSP("@Fax", prov.Fax);
                db.EjecutarComando();
                return true;
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al actualizar Proveedor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }

        public bool EliminarProveedor(int id)
        {
            DatosConexion db = new DatosConexion();
            try
            {
                db.Conectar();
                string paName = "cp_EliminarProveedor";
                db.CrearComandoSP(paName);
                db.AsignarParametroEnteroSP("@IdProveedor", id);
                db.EjecutarComando();
                return true;
            }
            catch (Exception ex)
            {
                throw new ReglasExcepciones("Error al eliminar Proveedor.", ex);
            }
            finally
            {
                db.Desconectar();
            }
        }
    }
}
