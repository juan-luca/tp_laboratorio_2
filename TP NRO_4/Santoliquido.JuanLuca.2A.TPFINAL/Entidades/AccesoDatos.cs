using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private string conexionString;
        

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto en el cual inicializa la conexion
        /// </summary>
        public AccesoDatos()
        {
            this.conexionString = "Data Source=DESKTOP-TEO2IE6\\SQLEXPRESS;Initial Catalog=Santoliquido_TP4_BD;Integrated Security=True";
            this.conexion = new SqlConnection();
            this.conexion.ConnectionString = conexionString;
        }

        #endregion

        #region Métodos

        #region Getters
        /// <summary>
        /// Carga a una lista la informacion de la BD
        /// </summary>
        /// <returns>Lista de indumentaria</returns>
        public List<Indumentaria> LoadFromBD()
        {
            List<Indumentaria> lista = new List<Indumentaria>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                comando.CommandText = "SELECT * FROM Cortes ORDER BY Id";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    if(oDr["Tipo"].ToString()=="Jogging")
                    {
                        int Id = oDr.GetInt32(0);
                        int S = oDr.GetInt32(1);


                        Joggings corteJ = new Joggings(oDr.GetInt32(0), oDr.GetInt32(1), oDr.GetInt32(2), oDr.GetInt32(3), oDr.GetInt32(4), oDr.GetInt32(5), true, EMarca.Adidas, oDr["Modelo"].ToString());
                        if (oDr["Variante"].ToString()=="Con punio")
                        {
                            
                            lista.Add(corteJ);
                        }else
                        {
                            lista.Add(
                           new Joggings(oDr.GetInt32(0), oDr.GetInt32(1), oDr.GetInt32(2), oDr.GetInt32(3), oDr.GetInt32(4), oDr.GetInt32(5), false, (EMarca)Enum.Parse(typeof(EMarca), oDr["Marca"].ToString()), oDr["Modelo"].ToString())
                           );
                        }
                        
                    }
                    else
                    {
                        if (oDr["Variante"].ToString() == "Con capucha")
                        {
                            lista.Add(
                           new Buzos(oDr.GetInt32(0), oDr.GetInt32(1), oDr.GetInt32(2), oDr.GetInt32(3), oDr.GetInt32(4), oDr.GetInt32(5), true, (EMarca)Enum.Parse(typeof(EMarca), oDr["Marca"].ToString()), oDr["Modelo"].ToString())
                           );
                        }
                        else
                        {
                            lista.Add(
                           new Joggings(oDr.GetInt32(0), oDr.GetInt32(1), oDr.GetInt32(2), oDr.GetInt32(3), oDr.GetInt32(4), oDr.GetInt32(5), false, (EMarca)Enum.Parse(typeof(EMarca), oDr["Marca"].ToString()), oDr["Modelo"].ToString())
                           );
                        }
                    }
                    
                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
        /// <summary>
        /// Carga el DataTable desde la base de datos
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LoadDTFromBD()
        {
            DataTable tabla = new DataTable("Indumentaria");

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.CommandText = "SELECT * FROM Cortes ORDER BY Id";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                tabla.Load(oDr);

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return tabla;
        }
        /// <summary>
        /// Busca un corte en la BD
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Corte</returns>
        public Indumentaria BuscarCorte(int id)
       {
           Indumentaria c = null;

           try
           {
               this.comando = new SqlCommand();

               this.comando.CommandType = CommandType.Text;

               this.comando.Connection = this.conexion;

               this.comando.Parameters.AddWithValue("@id", id);

               this.comando.CommandText = "SELECT * FROM Cortes WHERE id = @id";

               this.conexion.Open();

               SqlDataReader oDr = this.comando.ExecuteReader();

               if (oDr.Read())
               {
                    int S = oDr.GetInt32(1);
                    int M = oDr.GetInt32(2);
                    int L = oDr.GetInt32(3);
                    int XL = oDr.GetInt32(4);
                    int XXL = oDr.GetInt32(5);
                    EMarca marca = (EMarca)Enum.Parse(typeof(EMarca), oDr["Marca"].ToString());
                    bool variante;

                    if (oDr["Tipo"].ToString() == "Jogging")
                    {

                        if (oDr["Variante"].ToString() == "Con punio")
                        {

                            variante = true;
                        }else
                        {
                            variante = false;
                        }


                        c = new Joggings(id, S, M, L, XL, XXL, variante, marca, oDr["Modelo"].ToString());

                    }
                    else
                    {
                        if (oDr["Variante"].ToString() == "Con capucha")
                        {
                            variante = true;
                        }
                        else
                        {
                            variante = false;
                        }
                        c = new Buzos(id, S, M, L, XL, XXL, variante, marca, oDr["Modelo"].ToString());
                    }
                }

               oDr.Close();
           }

           catch (Exception e)
           {
           }
           finally
           {
               if (this.conexion.State == ConnectionState.Open)
               {
                   this.conexion.Close();
               }
           }

           return c;
       }
        /// <summary>
        /// Devuelve el ultimo ID usado en la BD
        /// </summary>
        /// <returns>Ultimo id usado</returns>
        public int LastID()
        {
            int lastId = 0;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;


                this.comando.CommandText = "SELECT MAX(Id) AS MaxID FROM cortes";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                if (oDr.Read())
                {
                    
                    lastId = Convert.ToInt32(oDr["MaxId"].ToString());
                    
                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lastId;
        }

        /// <summary>
        /// Cuenta la cantidad de cortes ingresados en la BD
        /// </summary>
        /// <returns>Cantidad de cortes</returns>
        public int CountBD()
        {
            int cantidad = 0;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;


                this.comando.CommandText = "select Count(Id) AS Cantidad FROM Cortes";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                if (oDr.Read())
                {

                    Int32.TryParse(oDr["Cantidad"].ToString(), out cantidad);

                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return cantidad;
        }
        /// <summary>
        /// Devuelve el espacio ocupado en la BD
        /// </summary>
        /// <returns>Espacio ocupado</returns>
        public double TelaDisponibleBD()
        {
            double telaDisponible = 0;
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;


                this.comando.CommandText = "select MetrosTela FROM MetrosTela";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();
                

                if (oDr.Read())
                {

                    Double.TryParse(oDr["MetrosTela"].ToString(), out telaDisponible);

                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return telaDisponible;

            /*try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;


                this.comando.CommandText = "select SUM(S) AS S, SUM(M) AS M, SUM(L) AS L, SUM(XL) AS XL, SUM(XXL) AS XXL FROM Cortes";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();
                int S = 0;
                int M = 0;
                int L = 0;
                int XL = 0;
                int XXL = 0;

                if (oDr.Read())
                {
                    
                    Int32.TryParse(oDr["S"].ToString(),out S);
                    Int32.TryParse(oDr["M"].ToString(),out M);
                    Int32.TryParse(oDr["L"].ToString(),out L);
                    Int32.TryParse(oDr["XL"].ToString(),out XL);
                    Int32.TryParse(oDr["XXL"].ToString(),out XXL);
                    telaOcupada += S + M + L + XL + XXL;

                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }*/


        }
        public bool ReemplazarTela(double t)
        {
            bool todoOk = false;

            string sql = "UPDATE MetrosTela SET MetrosTela=@t";


            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;
                
                this.comando.Parameters.AddWithValue("@t", t);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception ex)
            {

                todoOk = false;
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return todoOk;
        }
        public bool UpdateTela(double t)
        {
            bool todoOk = false;

            string sql = "UPDATE MetrosTela SET MetrosTela=@t";


            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;
                t = t + this.TelaDisponibleBD();
                this.comando.Parameters.AddWithValue("@t", t);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception ex)
            {

                todoOk = false;
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return todoOk;
        }
        #endregion

        #region Insertar Corte

        /// <summary>
        /// Inserta un corte en la BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns>True or flase de acuerdo si pudo realizar la insercion</returns>
        public bool InsertarCorte(Indumentaria c)
       {
           bool save = false;

           string sql = "INSERT INTO Cortes values(@S, @M, @L, @XL, @XXL, @Tipo,  @Marca, @Modelo, @Variante);";

           try
           {
               this.comando = new SqlCommand();

               this.comando.CommandType = CommandType.Text;

               this.comando.Connection = this.conexion;

               this.comando.Parameters.AddWithValue("@S", c.S);
               this.comando.Parameters.AddWithValue("@M", c.M);
               this.comando.Parameters.AddWithValue("@L", c.L);
               this.comando.Parameters.AddWithValue("@XL", c.XL);
               this.comando.Parameters.AddWithValue("@XXL", c.XXL);
               this.comando.Parameters.AddWithValue("@Tipo", c.Tipo.ToString());
               this.comando.Parameters.AddWithValue("@Marca", c.Marca.ToString());
               this.comando.Parameters.AddWithValue("@Modelo", c.Modelo.ToString());
               this.comando.Parameters.AddWithValue("@Variante", c.Variante.ToString());

                this.comando.CommandText = sql;

               this.conexion.Open();

               this.comando.ExecuteNonQuery();

               save = true;
           }
           catch (Exception ex)
           {
               save = false;
                throw new Exception(ex.ToString());
            }
           finally
           {
               if (this.conexion.State == ConnectionState.Open)
               {
                   this.conexion.Close();
               }
           }

           return save;
       }
        /// <summary>
        /// Carga la BD Desde una lista
        /// </summary>
        /// <param name="lstInd"></param>
        /// <returns>True or flase de acuerdo si pudo realizar la carga</returns>
        public bool CargarBdFromLst(List<Indumentaria> lstInd)
        {
            bool save = false;
            string sqlDelete = "Delete Cortes";
            string sqlReSeed = "DBCC CHECKIDENT ('Cortes', RESEED, 0);";


            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                

               

                

                this.conexion.Open();
                //Borra
                this.comando.CommandText = sqlDelete;
                this.comando.ExecuteNonQuery();
                //ReSeed
                this.comando.CommandText = sqlReSeed;
                this.comando.ExecuteNonQuery();
                this.conexion.Close();
                //Carga
                foreach (Indumentaria c in lstInd)
                {
                    this.InsertarCorte(c);
                }

                save = true;
            }
            catch (Exception ex)
            {
                save = false;
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return save;
        }

        #endregion

        #region Modificar Corte

        /// <summary>
        /// Modifica el corte seleccionado en la BD
        /// </summary>
        /// <param name="C"></param>
        /// <returns>True or flase de acuerdo si pudo realizar la MODIFICACION</returns>
        public bool UpdateCorte(Indumentaria c)
       {
           bool todoOk = false;

           string sql = "UPDATE Cortes SET S=@S, M=@M, L=@L, XL=@XL, XXL=@XXL, Tipo=@Tipo,  Marca=@Marca, Modelo=@Modelo, Variante=@Variante WHERE Id = @Id";
           

           try
           {
               this.comando = new SqlCommand();

               this.comando.CommandType = CommandType.Text;

               this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@Id", c.Id);
                this.comando.Parameters.AddWithValue("@S", c.S);
                this.comando.Parameters.AddWithValue("@M", c.M);
                this.comando.Parameters.AddWithValue("@L", c.L);
                this.comando.Parameters.AddWithValue("@XL", c.XL);
                this.comando.Parameters.AddWithValue("@XXL", c.XXL);
                this.comando.Parameters.AddWithValue("@Tipo", c.Tipo.ToString());
                this.comando.Parameters.AddWithValue("@Marca", c.Marca.ToString());
                this.comando.Parameters.AddWithValue("@Modelo", c.Modelo.ToString());
                this.comando.Parameters.AddWithValue("@Variante", c.Variante.ToString());

                this.comando.CommandText = sql;

               this.conexion.Open();

               this.comando.ExecuteNonQuery();

               todoOk = true;
           }
           catch (Exception ex)
           {
                
                todoOk = false;
                throw new Exception(ex.ToString());
            }
           finally
           {
               if (this.conexion.State == ConnectionState.Open)
               {
                   this.conexion.Close();
               }
           }

           return todoOk;
       }

        #endregion

        #region Eliminar Corte
        /// <summary>
        /// Elimina un registro de la bd
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>True or flase de acuerdo si pudo realizar la ELIMINACION</returns>
        public bool DeleteCorte(int id)
       {
           bool todoOk = false;

           string sql = "DELETE FROM Cortes WHERE id = @id";

           try
           {
               this.comando = new SqlCommand();

               this.comando.CommandType = CommandType.Text;

               this.comando.Connection = this.conexion;

               this.comando.Parameters.AddWithValue("@id", id);

               this.comando.CommandText = sql;

               this.conexion.Open();

               this.comando.ExecuteNonQuery();

               todoOk = true;
           }
           catch (Exception ex)
           {
               todoOk = false;
                throw new Exception(ex.ToString());

            }
           finally
           {
               if (this.conexion.State == ConnectionState.Open)
               {
                   this.conexion.Close();
               }
           }

           return todoOk;
       }
        /// <summary>
        /// Carga la fabrica desde la BD
        /// </summary>
        /// <param name="FB"></param>
        /// <returns>Una fabrica</returns>
        public Fabrica loadFb(Fabrica FB)
        {
            bool finish = false;
            int id = 0;
            Indumentaria c = null;

            try
            {
                FB.TelaDisponible = this.TelaDisponibleBD();
                int lastId = LastID();
               while(finish==false)
               {
                    c = BuscarCorte(id);
                    if(c==null&&id>lastId)
                    {
                        finish = true;
                    }else
                    {
                        FB += c;
                    }
                    id++;
               }
                
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return FB;
        }

        #endregion

        #endregion

    }
}
