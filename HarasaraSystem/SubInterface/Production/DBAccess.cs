using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem
{
   public  class DBAccess
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=harasara2");

    //Constructor
    public void DBConnect()
    {
        
        

    }


    

    public void Close(MySqlConnection Connection)
    {
        try
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }

        }
        catch (Exception)
        {

            throw;
        }
    }

    //Initialize values
   
    //open connection to database
    private bool OpenConnection()
    {
         try
    {
        connection.Open();
        //MessageBox.Show("Connection Open ! ");
        return true;
    }
    catch (Exception ex)
    {
        
        
                MessageBox.Show(ex.Message);
                
        
        return false;
    }
    }

    //Close connection
    private bool CloseConnection()
    {
        try
    {
        connection.Close();
        return true;
    }
    catch (MySqlException ex)
    {
        MessageBox.Show(ex.Message);
        return false;
    }
    }

    //Insert statement
    public void Insert(String insertquery)
    {
        string query = insertquery;

    //open connection
    if (this.OpenConnection() == true)
    {

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);


            cmd.ExecuteNonQuery();


            this.CloseConnection();
        }
        catch (Exception e)
        {

            MessageBox.Show(e.Message);
        }
    }
    }

    //Update statement
    public void Update(String updatequery)
    {
        string query = updatequery;

    //Open connection
    if (this.OpenConnection() == true)
    {
        
        
        
        MySqlCommand cmd = new MySqlCommand(query, connection);
        
        
        cmd.ExecuteNonQuery();

        
        this.CloseConnection();
    }
    }

    //Delete statement
    public void Delete(String deletequery)
    {
        string query = deletequery;

    if (this.OpenConnection() == true)
    {
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.ExecuteNonQuery();
        this.CloseConnection();
    }
    }

    //Select statement
    public DataTable Select(String query)
    {
        DataTable dt= new DataTable();

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter=new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            this.CloseConnection();

            return dt;
        }
        else 
            return dt;
    }

    //Select statement 2
    //public DataTable Selectt(String query)
    //{
    //    DataTable dt = new DataTable();
    //    ProductItem pitem=new ProductItem
    //    if (this.OpenConnection() == true)
    //    {
    //        MySqlCommand cmd = new MySqlCommand(query, connection);
    //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
    //        adapter.Fill(dt);

    //        this.CloseConnection();

    //        return dt;
    //    }
    //    else
    //        return dt;
    //}
    //    public DataTable SelectOrder(String oid)
    //{

    //    String query="SELECT * FROM products WHERE "
    //    DataTable dt= new DataTable();

    //    if (this.OpenConnection() == true)
    //    {
    //        MySqlCommand cmd = new MySqlCommand(query, connection);
    //        MySqlDataAdapter adapter=new MySqlDataAdapter(cmd);
    //        adapter.Fill(dt);

    //        this.CloseConnection();

    //        return dt;
    //    }
    //    else 
    //        return dt;
    //}


    //Count statement
    
}
}
