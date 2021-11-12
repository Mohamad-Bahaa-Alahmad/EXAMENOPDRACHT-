using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace News
{
    internal class DbConnect
    {
        private SqlConnection GetDbConnectie()

        {
            string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bahaa\\source\\repos\\News\\ManageData.mdf;Integrated Security=True;Connect Timeout=30";

            return new SqlConnection(con);

        }
        public Boolean RegisterConnect(string firstname, string lastname, string email, string pass)
        {
            Boolean check = true;           
            string insertSqlText = "Select * From Users Where Email =@email ";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@email", email));
            insertSql.Connection = GetDbConnectie();
            try

            {
                insertSql.Connection.Open();
                SqlDataReader de = insertSql.ExecuteReader();

                while (de.Read())
                {
                    if (de.HasRows)
                    {
                        check = false;
                        insertSql.Connection.Close();
                        return check;
                    }

                }
                de.Close();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }

            
            insertSqlText = "INSERT INTO Users(FirstName, LastName, Email, Password)     VALUES(@first,  @last,  @email,  @pass)";
            insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@first", firstname));
            insertSql.Parameters.Add(new SqlParameter("@last", lastname));
            insertSql.Parameters.Add(new SqlParameter("@email", email));
            insertSql.Parameters.Add(new SqlParameter("@pass", pass));
            insertSql.Connection = GetDbConnectie();

            try

            {
                insertSql.Connection.Open();
                insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }

            return check;
        }
        public Boolean LogInConnect(string email, string pass)
        {
            Boolean check = false;
            string insertSqlText = "Select * From Users Where Email =@email AND Password =@pass";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@email", email));
            insertSql.Parameters.Add(new SqlParameter("@pass", pass));
            insertSql.Connection = GetDbConnectie();
            try

            {
                insertSql.Connection.Open();
                SqlDataReader de = insertSql.ExecuteReader();

                while (de.Read())
                {
                    if (de.HasRows)
                    {
                        check = true;

                    }

                }

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }
            return check;
        }
        public void AddNews(News news)
        {
            string insertSqlText = "INSERT INTO News(title, text, date)     VALUES(@title,  @text,  @date)";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@title", news.Title));
            insertSql.Parameters.Add(new SqlParameter("@text", news.Text));
            insertSql.Parameters.Add(new SqlParameter("@date", news.dateTime));
            insertSql.Connection = GetDbConnectie();
            try

            {

                insertSql.Connection.Open();
                insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }

        }
        public void AddSessies(Sessies sessies)
        {
            string insertSqlText = "INSERT INTO Sessies(Title, Speaker, Description, date)     VALUES(@title, @speaker,  @Description,  @date)";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@title", sessies.Title));
            insertSql.Parameters.Add(new SqlParameter("@speaker", sessies.Speaker));
            insertSql.Parameters.Add(new SqlParameter("@Description", sessies.Description));
            insertSql.Parameters.Add(new SqlParameter("@date", sessies.date));
            insertSql.Connection = GetDbConnectie();

            try

            {
                insertSql.Connection.Open();
                insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }

        }
        public List<News> getAllNews()
        {
            List<News> listnews = new List<News>();
            string insertSqlText = "Select * From News";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Connection = GetDbConnectie();

            try

            {
                insertSql.Connection.Open();
                SqlDataReader de = insertSql.ExecuteReader();

                while (de.Read())
                {
                    if (de.HasRows)
                    {
                        listnews.Add(new News(de.GetString(1), de.GetString(2), de.GetString(3)));

                    }

                }

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }
            return listnews;
        }
        public List<Sessies> getAllSessies()
        {
            List<Sessies> listsessies = new List<Sessies>();
            
            string insertSqlText = "Select * From Sessies";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Connection = GetDbConnectie();

            try

            {
                insertSql.Connection.Open();
                SqlDataReader de = insertSql.ExecuteReader();

                while (de.Read())
                {
                    if (de.HasRows)
                    {
                        listsessies.Add(new Sessies(de.GetString(1), de.GetString(2), de.GetString(3), de.GetString(4)));

                    }

                }

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }
            return listsessies;
        }
        public void deleteSessies(string title, string date)
        {
            string insertSqlText = "DELETE FROM Sessies Where Title =@title AND date = @date";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@title", title));
            insertSql.Parameters.Add(new SqlParameter("@date", date));
            insertSql.Connection = GetDbConnectie();
         
            try

            {

                insertSql.Connection.Open(); 
                insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }
            }
        }
        public void deleteNews(string title, string date)
        {
            string insertSqlText = "DELETE FROM News Where title =@title AND date = @date";
            SqlCommand insertSql = new SqlCommand(insertSqlText);
            insertSql.Parameters.Add(new SqlParameter("@title", title));
            insertSql.Parameters.Add(new SqlParameter("@date", date));
            insertSql.Connection = GetDbConnectie();

            try

            {

                insertSql.Connection.Open();
                insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }
            }
        }
    }
}
