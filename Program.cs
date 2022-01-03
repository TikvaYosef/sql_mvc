using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employyes> employyesList = new List<Employyes>();
            string stringCollection = "Data Source=desktop-5e70rm2;Initial Catalog=EmployyesDb;Integrated Security=True;Pooling=False";
            //List<Maneger> manegerList = new List<Maneger>();

            //addEmployye(stringCollection);
            //UpdateFromUser(stringCollection,id)
            //UpdateFromUser(stringCollection);
            //DeleteEmployye(stringCollection, 2);



        }
        public static void showAllEmployyees(List<Employyes> employyesList, string stringCollection)
        {
            using (SqlConnection connection = new SqlConnection(stringCollection))
            {
                connection.Open();

                string query = @"SELECT * FROM Employyes";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader DataFromDb = command.ExecuteReader();

                if (DataFromDb.HasRows)
                {
                    while (DataFromDb.Read())
                    {
                        employyesList.Add(new Employyes(DataFromDb.GetString(1), DataFromDb.GetString(2), DataFromDb.GetString(3), DataFromDb.GetInt32(4)));
                    }
                }

                else
                {
                    Console.WriteLine("no rows in table");
                }
                connection.Close();
            }
        }

        public static void addEmployye(string stringCollection)
        {

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your salery");
            int salery = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(stringCollection))
            {
                connection.Open();
                string query = $@"INSERT INTO Employyes (name,birthday,email,salery) 
                                VALUES('{name}','{birthday}','{email}',{salery})";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);



            }

        }

       public static void  UpdateFromUser(string stringCollection)
        {

            Console.WriteLine("Enter ID");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your salery");
            int salery = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(stringCollection))
            {

                connection.Open();
                string query = $@"UPDATE Employyes SET name = '{name}',birthday = '{birthday}',email= '{email}',salery= {salery}                   
                                WHERE Id = {ID}";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();
            }

        }

       public  static void DeleteEmployye(string stringCollection,int ID)
        {
        
           

            using (SqlConnection connection = new SqlConnection(stringCollection))
            {

                connection.Open();
                string query = $@"DELETE FROM Employyes                    
                                WHERE Id = {ID}";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();
            }

        }
       

        //===============================================================


        void showAllManegers(List<Maneger> manegerList, string stringCollection)
        {
            using (SqlConnection connection = new SqlConnection(stringCollection))
            {
                connection.Open();

                string query = @"SELECT * FROM Maneger";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader DataFromDb = command.ExecuteReader();

                if (DataFromDb.HasRows)
                {
                    while (DataFromDb.Read())
                    {
                        manegerList.Add(new Maneger(DataFromDb.GetString(1), DataFromDb.GetString(2), DataFromDb.GetString(3), DataFromDb.GetString(4), DataFromDb.GetString(5)));
                    }
                }

                else
                {
                    Console.WriteLine("no rows in table");
                }
                connection.Close();
            }
        }

        void addmaneger(string stringCollection)
        {

            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your calss");
            string classs = Console.ReadLine();


            using (SqlConnection connection = new SqlConnection(stringCollection))
            {
                string query = $@"INSERT INTO Maneger (name,birthday,email,salery) 
                                VALUES($'{fname}','{ lname }','{birthday}','{ email }','{classs}')";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);



            }

        }


        void Updatemaneger(string stringCollection)
        {
            Console.WriteLine("Enter ID");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your calss");
            string classs = Console.ReadLine();


            using (SqlConnection connection = new SqlConnection(stringCollection))
            {
                string query = $@"UPDATE Employyes SET (fname= {fname},lname = {lname},birthday = {birthday},email={email},classs={classs})                    
                                WHERE Id = {ID}";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);



            }

        }

        public static void DeleteManeger(string stringCollection, int ID)
        {



            using (SqlConnection connection = new SqlConnection(stringCollection))
            {

                connection.Open();
                string query = $@"DELETE FROM maneger                    
                                WHERE Id = {ID}";
                SqlCommand command = new SqlCommand(query, connection);
                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();
            }

        }

        //============================================================





    }
}
