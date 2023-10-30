// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System;
using System.Data; 
    //addRecord();
    //show();
    addDisconnect();
    showDisconnect();

    void addDisconnect()
    {
     string connectionString= "User ID=sa;password=examlyMssql@123; server=localhost;Database=Mahi;trusted_connection=false;Persist Security Info=False;Encrypt=False";
   
    Console.WriteLine("Enter ID: ");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter product name: ");
    string name=Console.ReadLine();
    Console.WriteLine("Enter price: ");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter stock: ");
    int stock=Convert.ToInt32(Console.ReadLine());   
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodTable=null;
    try{
        ds=new DataSet();
        connection=new SqlConnection(connectionString);
        adapter=new SqlDataAdapter("select * from Product",connection);
        adapter.Fill(ds,"Prods");
        prodTable=ds.Tables["Prods"];
        DataRow prodrow=prodTable.NewRow();
        prodrow["id"]=id;
        prodrow["name"]=name;
        prodrow["price"]=price;
        prodrow["stock"]=stock;
        prodTable.Rows.Add(prodrow);
        SqlCommandBuilder scb=new SqlCommandBuilder(adapter);
        Console.WriteLine(scb.GetInsertCommand().CommandText);
        adapter.Update(prodTable);
        Console.WriteLine("Row added");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    }

    void showDisconnect()
    {
        string connectionString= "User ID=sa;password=examlyMssql@123; server=localhost;Database=Mahi;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        string cmdtext="insert into Product values(@id,@name,@price,@stock)"; 
        SqlConnection connection=null;
        SqlDataAdapter adapter=null;
        DataSet ds=null;
        DataTable prodTable=null;
        try{
            ds=new DataSet();
            connection=new SqlConnection(connectionString);
            adapter=new SqlDataAdapter("select * from Product",connection);
            adapter.Fill(ds,"Prods");
            prodTable=ds.Tables["Prods"];
            Console.WriteLine($"Rows={prodTable.Rows.Count}");
            Console.WriteLine($"Columns={prodTable.Columns.Count}");
            foreach(DataRow row in prodTable.Rows)
            {
                Console.WriteLine($"{row["id"]} -- {row["name"]} -- {row["price"]} -- {row["stock"]}");
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    void show() { 
        string connectionString= "User ID=sa;password=examlyMssql@123; server=localhost;Database=Mahi;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        try{
        string cmdtext="select * from Product";
        SqlConnection con=new SqlConnection(connectionString);
        con.Open();
        Console.WriteLine("Connection opened successfully");
        SqlCommand command=new SqlCommand(cmdtext,con);
        SqlDataReader reader=command.ExecuteReader();
        while(reader.Read())
        {
            Console.WriteLine($"{reader["id"]} --- {reader["Name"]} --- {reader["Price"]} --- {reader["Stock"]}");
        }
        con.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
        // con.Close();}
       }
    }
   
void addRecord()
{ 
    string connectionString= "User ID=sa;password=examlyMssql@123; server=localhost;Database=Mahi;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    // string cmdtext="select * from Product"; 
    string cmdtext="insert into Product values(@id,@name,@price,@stock)";
    Console.WriteLine("Enter ID: ");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter product name: ");
    string name=Console.ReadLine();
    Console.WriteLine("Enter price: ");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter stock: ");
    int stock=Convert.ToInt32(Console.ReadLine());
    SqlConnection con=null;
    SqlCommand command=null;
    try
    {
        con=new SqlConnection(connectionString);
        command=new SqlCommand(cmdtext,con);
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@price",price);
        command.Parameters.AddWithValue("@stock",stock);
        con.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Record Added");
        con.Close();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
       // con.Close();
    }
}