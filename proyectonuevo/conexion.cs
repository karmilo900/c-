using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Dynamic;



namespace MySqlCon{
    class Conexion{

       private string connectionString = "Server=LocalHost;Database=proyecto_c;Uid=root;";
       private MySqlConnection con;
       private MySqlCommand comd;

       private MySqlDataAdapter adap;
       private DataSet dtse;
       private DataTable databl;


       private void Conectar(){
        con =new MySqlConnection(connectionString);
       }

       public Conexion(){
            Conectar();
       }
       public bool guardarSQL(string sql){
            try{
                comd= new MySqlCommand(sql, con);
                con.Open();
                int a= comd.ExecuteNonQuery();
                if(a > 0){
                    return true;
                }else{
                    return false;
                }
            }
            catch (Exception e){
                throw e;

            }finally{
                con.Close();

            }
       
       }
       public DataTable listaempleados(String tabla)
{
    DataTable dtt = null;
    DataSet dats= null;

    try
    {
        string sql = "SELECT * FROM empleadoin" ; ;
        con.Open();
        adap = new MySqlDataAdapter(sql, con);
        dats = new DataSet();
        adap.Fill(dats, tabla);
        dtt = dats.Tables[tabla]; 
    }
    catch (Exception e)
    {
        
        Console.WriteLine("Error al obtener datos de la tabla " + tabla + ": " + e.Message);
    }
    finally
    {
        con.Close();
    }

    return dtt;
}
       

        
    }
        }

