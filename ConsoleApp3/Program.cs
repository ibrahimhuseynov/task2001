using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stadion əlavə et");
            Console.WriteLine(" 2. Stadionları göstər");
            Console.WriteLine(" 3. İstifadəçi əlavə et");
            Console.WriteLine("4. İstifadəçiləri göstər");
            Console.WriteLine("5. Rezervasiyaları göstər");
            Console.WriteLine("6. Rezervasiya yarat");
            Console.WriteLine("7. Verilmiş id-li stadionun rezervasiyalarını göstər");
            Console.WriteLine("8. Verilmiş id-li userin rezervasiyalarını göstər");
            Console.WriteLine(" 9. Verilmiş id-li rezervasiyanı sil");
            Console.WriteLine("menyudan bir reqem daxil edin :");
            int number = Convert.ToInt32(Console.ReadLine());
            do
                switch (number)
                {
                    case 1:
                        string connection = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll3;Trusted_Connection=TRUE";
                        SqlConnection con1 = new SqlConnection(connection);
                        Console.WriteLine("stadionun adini daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("HourPrice adini daxil edin:");
                        int hourPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Capacity adini daxil edin:");
                        int capacity = Convert.ToInt32(Console.ReadLine());
                        con1.Open();
                        string query = $"INSERT INTO Stadions( Name,HourPrice,Capacity) VALUES('{name}',{hourPrice},{capacity})";
                        SqlCommand cmd = new SqlCommand(query, con1);
                        int result = cmd.ExecuteNonQuery();
                        con1.Close();
                        break;
                    case 2:
                        string connection1 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con2 = new SqlConnection(connection1);
                        con2.Open();
                        query = "SELECT*FROM Stadions";
                        cmd = new SqlCommand(query, con2);
                        SqlDataReader reader = cmd.ExecuteReader();
                        Console.WriteLine("stadions");
                        while (reader.Read())
                        {
                            Console.WriteLine($"name:{reader.GetString(1)}\nHourPrice:{reader.GetInt32(2)}\ncapacity:{reader.GetInt32(3)}");

                        }
                        break;
                        con2.Close();
                    case 3:
                        string connection3 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con3 = new SqlConnection(connection3);
                        Console.WriteLine(" fullname daxil edin ");
                        string fullname = Console.ReadLine();
                        Console.WriteLine(" Email daxil edin ");
                        string email = Console.ReadLine();
                        con3.Open();
                        string query1 = $"INSERT INTO Users(FullName,Email)VALUES('{fullname}','{email}')";
                        SqlCommand cmd1 = new SqlCommand(query1, con3);
                        int result1 = cmd1.ExecuteNonQuery();
                        Console.WriteLine(result1 + "eleve edildi");
                        con3.Close();
                        break;
                    case 4:
                        string connection4 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con4 = new SqlConnection(connection4);
                        con4.Open();
                        query = "SELECT*FROM Users";
                        cmd = new SqlCommand(query, con4);
                        SqlDataReader reader4 = cmd.ExecuteReader();
                        Console.WriteLine("users");
                        while (reader4.Read())
                        {
                            Console.WriteLine($"fullname:{reader4.GetString(1)}\nemail:{reader4.GetString(2)}");

                        }
                        break;
                        con4.Close();
                    case 5:
                        string connection5 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con5 = new SqlConnection(connection5);
                        con5.Open();
                        query = "SELECT*FROM Reservations";
                        cmd = new SqlCommand(query, con5);
                        SqlDataReader reader5 = cmd.ExecuteReader();
                        Console.WriteLine("users");
                        while (reader5.Read())
                        {
                            Console.WriteLine($"StadionId :{StadionId},UserId :{UserId},StartDate :{StartDate},EndDate:{EndDate}");

                        }
                    case 6:
                        string connection6 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con6 = new SqlConnection(connection6);
                        Console.WriteLine("Id1 daxil edin :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Id2 daxil edin :");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("I3 daxil edin :");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("I4 daxil edin :");
                        int i3 = Convert.ToInt32(Console.ReadLine());
                        con6.Open();
                        string query6 = $"INSERT INTO Reservations(StadionId,UserId,StartDate,EndDate)VALUES({StadionId},{UserId},{StartDate},{EndDate})";
                        SqlCommand cmd6 = new SqlCommand(query6, con6);
                        int result6 = cmd6.ExecuteNonQuery();
                        Console.WriteLine(result6 + "eleve edildi");
                        con6.Close();
                        break;
                    case 7:
                        string connection7 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con7 = new SqlConnection(connection7);
                        Console.WriteLine("Id daxil edin :");
                        int id8 = Convert.ToInt32(Console.ReadLine());
                        query = "SELECT*FROM Stadions";
                        cmd = new SqlCommand(query, con7);
                        SqlDataReader reader7 = cmd.ExecuteReader();
                        if (id8 == stadionId)
                        {
                            while (reade7.Read())
                            {
                                Console.WriteLine($"fullname:{reader4.GetString(1)}\nemail:{reader4.GetString(2)}");

                            }
                        }
                        else Console.WriteLine("bele bir stodion reverzasiya yoxdur ");
                        break;
                    case 8:
                        string connection8 = @"Server=WINDOWS-CB3KID5\SQLEXPRESS01;Database=futboll2;Trusted_Connection=TRUE";
                        SqlConnection con8 = new SqlConnection(connection8);
                        Console.WriteLine("Id daxil edin :");
                        int id9 = Convert.ToInt32(Console.ReadLine());
                        query = "SELECT*FROM Stadions";
                        cmd = new SqlCommand(query, con8);
                        SqlDataReader reader8 = cmd.ExecuteReader();
                        if (id8 == userId)
                        {
                            while (reade8.Read())
                            {
                                Console.WriteLine($"name:{reader.GetString(1)}\nHourPrice:{reader.GetInt32(2)}\ncapacity:{reader.GetInt32(3)}");

                            }
                        }
                        else Console.WriteLine("bele bir reverzasiya yoxdur ");
                        break;

                } while (number != 0);
            Console.ReadLine(); 
    
        }
        
    }
}
