using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;

using Lab4;


namespace Lab4
{
    class Db
    {
        public string connStr = "server=localhost;user=root;database=4lab;password=0000;";

        // All clients
        public List<Pub> GetAllPubs()
        {
            List<Pub> pubs = new List<Pub>();
            string sql = "SELECT * FROM pub";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Pub pub = new Pub(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                DateTime.Parse(reader[2].ToString()), DateTime.Parse(reader[3].ToString()));
                            pubs.Add(pub);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }

            return pubs;
        }
        public Pub GetPubById(int id)
        {
            Pub pub = null;
            string sql = "SELECT * FROM pub WHERE idpub = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            pub = new Pub(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                DateTime.Parse(reader[2].ToString()), DateTime.Parse(reader[3].ToString()));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (pub == null)
            {
                System.Windows.Forms.MessageBox.Show("Pub is not found.", "Fail");
            }
            return pub;
        }
        public void UpdatePub(Pub pub)
        {
            string sql = "UPDATE pub SET address=?address, openTime=?openTime, closeTime=?closeTime " +
                            "WHERE(idpub=?idpub)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?address", MySqlDbType.VarChar).Value = pub.Address;
                        command.Parameters.Add("?openTime", MySqlDbType.Time).Value = new TimeSpan(pub.OpenTime.Hour, pub.OpenTime.Minute, pub.OpenTime.Second);
                        command.Parameters.Add("?closeTime", MySqlDbType.Time).Value = new TimeSpan(pub.CloseTime.Hour, pub.CloseTime.Minute, pub.CloseTime.Second);
                        command.Parameters.Add("?idpub", MySqlDbType.Int32).Value = pub.Id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void DeletePub(int id)
        {
            if (GetAllEvents().Any(ev => ev.Id_pub == id) || GetAllWorkers().Any(wk => wk.Id_pub == id) || GetAllPubIngreds().Any(wk => wk.Id_pub == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM pub WHERE idpub = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void AddPub(Pub pub)
        {
            string sqlExpression = "INSERT INTO 4lab.pub (address, openTime, closeTime) " +
                "VALUES (?address, ?openTime, ?closeTime);";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?address", MySqlDbType.VarChar).Value = pub.Address;
                        command.Parameters.Add("?openTime", MySqlDbType.Time).Value = new TimeSpan(pub.OpenTime.Hour, pub.OpenTime.Minute, pub.OpenTime.Second);
                        command.Parameters.Add("?closeTime", MySqlDbType.Time).Value = new TimeSpan(pub.CloseTime.Hour, pub.CloseTime.Minute, pub.CloseTime.Second);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }



        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            string sql = "SELECT * FROM event";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Event event1 = new Event(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), DateTime.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()),
                                Convert.ToInt32(reader[5]));

                            events.Add(event1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }

            return events;
        }
        public Event GetEventById(int id)
        {
            Event ev = null;
            string sql = "SELECT * FROM event WHERE idevent = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ev = new Event(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(),
                                DateTime.Parse(reader[3].ToString()), DateTime.Parse(reader[4].ToString()), Convert.ToInt32(reader[5]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (ev == null)
            {
                System.Windows.Forms.MessageBox.Show("Event is not found.", "Fail");
            }
            return ev;
        }
        public void UpdateEvent(Event Event1)
        {
            if (GetAllPubs().Any(elem => elem.Id == Event1.Id_pub))
            {
                string sql = "UPDATE event SET name = ?name, description = ?description, startTime = ?startTime, endTime = ?endTime, id_pub = ?id_pub " +
                            "WHERE idevent = ?idevent";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = Event1.Name;
                            command.Parameters.Add("?description", MySqlDbType.VarChar).Value = Event1.Description;
                            command.Parameters.Add("?startTime", MySqlDbType.DateTime).Value = Event1.StartTime;
                            command.Parameters.Add("?endTime", MySqlDbType.DateTime).Value = Event1.EndTime;
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = Event1.Id_pub;
                            command.Parameters.Add("?idevent", MySqlDbType.Int32).Value = Event1.Id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Pub with that id doesn't exist.", "Fail");
            }
        }
        public void DeleteEvent(int id)
        {
            string sqlExpression = "DELETE FROM event WHERE idevent = ?id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }

        }
        public void AddEvent(Event Event1)
        {
            if (GetAllPubs().Any(elem => elem.Id == Event1.Id_pub))
            {
                string sqlExpression = "INSERT INTO event (name, description, startTime, endTime, id_pub) " +
               "VALUES (?name, ?description, ?startTime, ?endTime, ?id_pub)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = Event1.Name;
                            command.Parameters.Add("?description", MySqlDbType.VarChar).Value = Event1.Description;
                            command.Parameters.Add("?startTime", MySqlDbType.DateTime).Value = Event1.StartTime;
                            command.Parameters.Add("?endTime", MySqlDbType.DateTime).Value = Event1.EndTime;
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = Event1.Id_pub;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Event can't exist in this pub.", "Fail");
            }
        }



        public List<Worker> GetAllWorkers()
        {
            List<Worker> workers = new List<Worker>();
            string sql = "SELECT * FROM worker";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Worker worker1 = new Worker(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]),
                                reader[6].ToString(), Convert.ToBoolean(reader[7]), Convert.ToInt32(reader[8]), Convert.ToInt32(reader[9]),
                                reader[10].ToString(), reader[11].ToString());

                            workers.Add(worker1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return workers;
        }
        public Worker GetWorkerById(int id)
        {
            Worker worker = null;
            string sql = "SELECT * FROM worker WHERE idworker = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            worker = new Worker(Convert.ToInt32(reader[0]), reader[1].ToString(),
                            reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]),
                            reader[6].ToString(), Convert.ToBoolean(reader[7]), Convert.ToInt32(reader[8]), Convert.ToInt32(reader[9]),
                            reader[10].ToString(), reader[11].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (worker == null)
            {
                System.Windows.Forms.MessageBox.Show("worker is not found.", "Fail");
            }
            return worker;
        }
        public void UpdateWorker(Worker worker)
        {
            if (GetAllPubs().Any(elem => elem.Id == worker.Id_pub) && GetAllposts().Any(elem => elem.Id == worker.Id_post))
            {
                string sql = "UPDATE worker SET name = ?name, surname = ?surname, patronomyc = ?patronomyc, passportNo = ?passportNo, passportSerial = ?passportSerial, " +
                "address = ?address, criminalRec = ?criminalRec, id_post = ?id_post, id_pub = ?id_pub, username = ?username, password = ?password " +
                            "WHERE idworker = ?idworker";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = worker.Name;
                            command.Parameters.Add("?surname", MySqlDbType.VarChar).Value = worker.Surname;
                            command.Parameters.Add("?patronomyc", MySqlDbType.VarChar).Value = worker.Patronomyc;
                            command.Parameters.Add("?passportNo", MySqlDbType.Int32).Value = worker.PassNo;
                            command.Parameters.Add("?passportSerial", MySqlDbType.Int32).Value = worker.PassSer;
                            command.Parameters.Add("?address", MySqlDbType.VarChar).Value = worker.Address;
                            command.Parameters.Add("?criminalRec", MySqlDbType.Binary).Value = worker.CriminalRec ? 1 : 0;
                            command.Parameters.Add("?id_post", MySqlDbType.Int32).Value = worker.Id_post;
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = worker.Id_pub;
                            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = worker.Username;
                            command.Parameters.Add("?password", MySqlDbType.VarChar).Value = worker.Password;
                            command.Parameters.Add("?idworker", MySqlDbType.Int32).Value = worker.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Worker with that data cant't exist.", "Fail");
            }
        }
        public void DeleteWorker(int id)
        {
            if (GetAllorders().Any(elem => elem.Idworker == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM worker WHERE idworker = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void AddWorker(Worker worker)
        {
            if (GetAllPubs().Any(elem => elem.Id == worker.Id_pub) && GetAllposts().Any(elem => elem.Id == worker.Id_post))
            {
                string sqlExpression = "INSERT INTO worker (name, surname, patronomyc, passportNo, passportSerial, address, criminalRec, id_post, id_pub, username, password) " +
               "VALUES (?name, ?surname, ?patronomyc, ?passportNo, ?passportSerial, ?address, ?criminalRec, ?id_post, ?id_pub, ?username, ?password)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = worker.Name;
                            command.Parameters.Add("?surname", MySqlDbType.VarChar).Value = worker.Surname;
                            command.Parameters.Add("?patronomyc", MySqlDbType.VarChar).Value = worker.Patronomyc;
                            command.Parameters.Add("?passportNo", MySqlDbType.Int32).Value = worker.PassNo;
                            command.Parameters.Add("?passportSerial", MySqlDbType.Int32).Value = worker.PassSer;
                            command.Parameters.Add("?address", MySqlDbType.VarChar).Value = worker.Address;
                            command.Parameters.Add("?criminalRec", MySqlDbType.Binary).Value = worker.CriminalRec ? 1 : 0;
                            command.Parameters.Add("?id_post", MySqlDbType.Int32).Value = worker.Id_post;
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = worker.Id_pub;
                            command.Parameters.Add("?username", MySqlDbType.VarChar).Value = worker.Username;
                            command.Parameters.Add("?password", MySqlDbType.VarChar).Value = worker.Password;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Worker with that data cannot exist.", "Fail");
            }
        }


        public List<Post> GetAllposts()
        {
            List<Post> posts = new List<Post>();
            string sql = "SELECT * FROM post";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Post post1 = new Post(Convert.ToInt32(reader[0]), reader[1].ToString());

                            posts.Add(post1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return posts;
        }
        public Post GetpostById(int id)
        {
            Post post = null;
            string sql = "SELECT * FROM post WHERE idpost = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            post = new Post(Convert.ToInt32(reader[0]), reader[1].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (post == null)
            {
                System.Windows.Forms.MessageBox.Show("post is not found.", "Fail");
            }
            return post;
        }
        public void Updatepost(Post post)
        {
            string sql = "UPDATE post SET name = ?name " +
                             "WHERE idpost = ?idpost";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = post.Name;
                        command.Parameters.Add("?idpost", MySqlDbType.Int32).Value = post.Id;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void Deletepost(int id)
        {
            if (GetAllWorkers().Any(elem => elem.Id_post == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM post WHERE idpost = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void Addpost(Post post)
        {
            string sqlExpression = "INSERT INTO post (name) " +
               "VALUES (?name)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = post.Name;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }


        public List<Order> GetAllorders()
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM 4lab.order;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Order order1 = new Order(Convert.ToInt32(reader[0]), DateTime.Parse(reader[1].ToString()), Convert.ToBoolean(reader[2]), Convert.ToInt32(reader[3]));

                            orders.Add(order1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return orders;
        }
        public Order GetorderById(int id)
        {
            Order order1 = null;
            string sql = "SELECT * FROM 4lab.order WHERE idorder = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            order1 = new Order(Convert.ToInt32(reader[0]), DateTime.Parse(reader[1].ToString()), Convert.ToBoolean(reader[2]), Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (order1 == null)
            {
                System.Windows.Forms.MessageBox.Show("order is not found.", "Fail");
            }
            return order1;
        }
        public void Updateorder(Order order)
        {
            if (GetAllWorkers().Any(elem => elem.Id == order.Idworker))
            {
                string sql = "UPDATE 4lab.order SET time = ?time, issued = ?issued, idworker = ?idworker " +
                            "WHERE idorder = ?idorder";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?time", MySqlDbType.DateTime).Value = order.Time.ToString("yyyy-MM-dd HH:mm:ss");
                            command.Parameters.Add("?idworker", MySqlDbType.Int32).Value = order.Idworker;
                            command.Parameters.Add("?issued", MySqlDbType.Binary).Value = order.Issued ? 1 : 0;
                            command.Parameters.Add("?idorder", MySqlDbType.Int32).Value = order.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Order with that worker cannot exist.", "Fail");
            }
        }
        public void Deleteorder(int id)
        {
            if (GetAllprodOrds().Any(elem => elem.Id_order == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM 4lab.order WHERE idorder = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void Addorder(Order order)
        {
            if (GetAllWorkers().Any(elem => elem.Id == order.Idworker))
            {
                string sqlExpression = "INSERT INTO 4lab.order (time, issued, idworker) " +
               "VALUES (?time, ?issued, ?idworker)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?time", MySqlDbType.DateTime).Value = order.Time.ToString("yyyy-MM-dd HH:mm:ss");
                            command.Parameters.Add("?issued", MySqlDbType.Binary).Value = order.Issued ? 1 : 0;
                            command.Parameters.Add("?idworker", MySqlDbType.Int32).Value = order.Idworker;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Order with that worker cannot exist.", "Fail");
            }
        }

        public List<Product> GetAllproducts()
        {
            List<Product> products = new List<Product>();
            string sql = "SELECT * FROM product";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Product product1 = new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDouble(reader[2]), Convert.ToInt32(reader[3]));

                            products.Add(product1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return products;
        }
        public Product GetproductById(int id)
        {
            Product product1 = null;
            string sql = "SELECT * FROM product WHERE idproduct = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            product1 = new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDouble(reader[2]), Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (product1 == null)
            {
                System.Windows.Forms.MessageBox.Show("product is not found.", "Fail");
            }
            return product1;
        }
        public void Updateproduct(Product product)
        {
            if (GetAllprod_types().Any(elem => elem.Id == product.Id_productType))
            {
                string sql = "UPDATE product SET name = ?name, price = ?price, id_productType = ?id_productType " +
                            "WHERE idproduct = ?idproduct";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = product.Name;
                            command.Parameters.Add("?price", MySqlDbType.Double).Value = product.Price;
                            command.Parameters.Add("?id_productType", MySqlDbType.Int32).Value = product.Id_productType;
                            command.Parameters.Add("?idproduct", MySqlDbType.Int32).Value = product.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Product with this type cannot exist.", "Fail");
            }
        }
        public void Deleteproduct(int id)
        {
            if (GetAllprodOrds().Any(elem => elem.Id_product == id) || GetAllprodIngreds().Any(elem => elem.Id_product == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM product WHERE idproduct = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void Addproduct(Product product)
        {
            if (GetAllprod_types().Any(elem => elem.Id == product.Id_productType))
            {

                string sqlExpression = "INSERT INTO product (name, price, id_productType) " +
               "VALUES (?name, ?price, ?id_productType)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = product.Name;
                            command.Parameters.Add("?price", MySqlDbType.Double).Value = product.Price;
                            command.Parameters.Add("?id_productType", MySqlDbType.Int32).Value = product.Id_productType;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Product with this type cannot exist.", "Fail");
            }
        }


        public List<Prod_type> GetAllprod_types()
        {
            List<Prod_type> prodTypes = new List<Prod_type>();
            string sql = "SELECT * FROM typeproduct";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Prod_type prodTypet1 = new Prod_type(Convert.ToInt32(reader[0]), reader[1].ToString());

                            prodTypes.Add(prodTypet1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return prodTypes;
        }
        public Prod_type Getprod_typeById(int id)
        {
            Prod_type prodTypet1 = null;
            string sql = "SELECT * FROM typeproduct WHERE idtypeProduct = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            prodTypet1 = new Prod_type(Convert.ToInt32(reader[0]), reader[1].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (prodTypet1 == null)
            {
                System.Windows.Forms.MessageBox.Show("product is not found.", "Fail");
            }
            return prodTypet1;
        }
        public void Updateprod_type(Prod_type prod_type)
        {
            string sql = "UPDATE typeproduct SET type = ?type " +
                             "WHERE idtypeProduct = ?idtypeProduct";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?type", MySqlDbType.VarChar).Value = prod_type.Name;
                        command.Parameters.Add("?idtypeProduct", MySqlDbType.Int32).Value = prod_type.Id;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void Deleteprod_type(int id)
        {
            if (GetAllproducts().Any(elem => elem.Id_productType == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM typeproduct WHERE idtypeProduct = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void Addprod_type(Prod_type prod_type)
        {
            string sqlExpression = "INSERT INTO typeproduct (type) " +
               "VALUES (?type)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?type", MySqlDbType.VarChar).Value = prod_type.Name;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                }

            }
        }


        public List<ProdOrd> GetAllprodOrds()
        {
            List<ProdOrd> prodords = new List<ProdOrd>();
            string sql = "SELECT * FROM 4lab.`product-order`;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ProdOrd prodord1 = new ProdOrd(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[3]),
                                Convert.ToDouble(reader[2]));

                            prodords.Add(prodord1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return prodords;
        }
        public ProdOrd GetprodOrdById(int id)
        {
            ProdOrd prodord1 = null;
            string sql = "SELECT * FROM 4lab.`product-order` WHERE `idproduct-order` = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            prodord1 = new ProdOrd(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[3]),
                                Convert.ToDouble(reader[2]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (prodord1 == null)
            {
                System.Windows.Forms.MessageBox.Show("prodord is not found.", "Fail");
            }
            return prodord1;
        }
        public void UpdateprodOrd(ProdOrd prodOrd)
        {
            if (GetAllproducts().Any(elem => elem.Id == prodOrd.Id_product) && GetAllorders().Any(elem => elem.Id == prodOrd.Id_order))
            {
                string sql = "UPDATE 4lab.`product-order` SET id_product = ?id_product, countProduct = ?countProduct, id_order = ?id_order " +
                            "WHERE `idproduct-order` = ?idproductOrder";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?id_product", MySqlDbType.Int32).Value = prodOrd.Id_product;
                            command.Parameters.Add("?countProduct", MySqlDbType.Double).Value = prodOrd.CountProduct;
                            command.Parameters.Add("?id_order", MySqlDbType.Int32).Value = prodOrd.Id_order;
                            command.Parameters.Add("?idproductOrder", MySqlDbType.Int32).Value = prodOrd.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Prod-Ord with that data con't exist.", "Fail");
            }
        }
        public void DeleteprodOrd(int id)
        {
            string sqlExpression = "DELETE FROM 4lab.`product-order` WHERE `idproduct-order` = ?id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void AddprodOrd(ProdOrd prodOrd)
        {
            if (GetAllproducts().Any(elem => elem.Id == prodOrd.Id_product) && GetAllorders().Any(elem => elem.Id == prodOrd.Id_order))
            {
                string sqlExpression = "INSERT INTO 4lab.`product-order` (id_product, countProduct, id_order) " +
               "VALUES (?id_product, ?countProduct, ?id_order)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id_product", MySqlDbType.Int32).Value = prodOrd.Id_product;
                            command.Parameters.Add("?countProduct", MySqlDbType.Double).Value = prodOrd.CountProduct;
                            command.Parameters.Add("?id_order", MySqlDbType.Int32).Value = prodOrd.Id_order;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Prod-Ord with that data con't exist.", "Fail");
            }
        }


        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            string sql = "SELECT * FROM ingredient";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Ingredient ingredient1 = new Ingredient(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]));

                            ingredients.Add(ingredient1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return ingredients;
        }
        public Ingredient GetIngredientById(int id)
        {
            Ingredient ingredient1 = null;
            string sql = "SELECT * FROM ingredient WHERE idingredient = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ingredient1 = new Ingredient(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (ingredient1 == null)
            {
                System.Windows.Forms.MessageBox.Show("prodord is not found.", "Fail");
            }
            return ingredient1;
        }
        public void UpdateIngredient(Ingredient ingredient)
        {
            if (GetAllproviders().Any(elem => elem.Id == ingredient.Id_provider) && GetAlltypeIngreds().Any(elem => elem.Id == ingredient.Id_typeOfIngredient ))
            {
                string sql = "UPDATE ingredient SET name = ?name, id_provider = ?id_provider, id_typeOfIngredient = ?id_typeOfIngredient " +
                            "WHERE idingredient = ?idingredient";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = ingredient.Name;
                            command.Parameters.Add("?id_provider", MySqlDbType.Int32).Value = ingredient.Id_provider;
                            command.Parameters.Add("?id_typeOfIngredient", MySqlDbType.Int32).Value = ingredient.Id_typeOfIngredient;
                            command.Parameters.Add("?idingredient", MySqlDbType.Int32).Value = ingredient.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingredient with that data can't exist.", "Fail");
            }
        }
        public void DeleteIngredient(int id)
        {
            if (GetAllprodIngreds().Any(elem => elem.Id_ingredient == id) || GetAllPubIngreds().Any(elem => elem.Id_ingred == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM ingredient WHERE idingredient = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void AddIngredient(Ingredient ingredient)
        {
            if (GetAllproviders().Any(elem => elem.Id == ingredient.Id_provider) && GetAlltypeIngreds().Any(elem => elem.Id == ingredient.Id_typeOfIngredient))
            {
                string sqlExpression = "INSERT INTO ingredient (name, id_provider, id_typeOfIngredient) " +
               "VALUES (?name, ?id_provider, ?id_typeOfIngredient)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?name", MySqlDbType.VarChar).Value = ingredient.Name;
                            command.Parameters.Add("?id_provider", MySqlDbType.Int32).Value = ingredient.Id_provider;
                            command.Parameters.Add("?id_typeOfIngredient", MySqlDbType.Int32).Value = ingredient.Id_typeOfIngredient;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingredient with that data can't exist.", "Fail");
            }
        }

        public List<Pub_ingred> GetAllPubIngreds()
        {
            List<Pub_ingred> Pub_ingreds = new List<Pub_ingred>();
            string sql = "SELECT * FROM 4lab.`pub-ingredient`;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Pub_ingred pub_ingred1 = new Pub_ingred(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                                Convert.ToInt32(reader[2]), Convert.ToDouble(reader[3]));

                            Pub_ingreds.Add(pub_ingred1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return Pub_ingreds;
        }
        public Pub_ingred GetPubIngredById(int id)
        {
            Pub_ingred pub_ingred1 = null;
            string sql = "SELECT * FROM 4lab.`pub-ingredient` WHERE idpubIngred = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            pub_ingred1 = new Pub_ingred(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                                Convert.ToInt32(reader[2]), Convert.ToDouble(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (pub_ingred1 == null)
            {
                System.Windows.Forms.MessageBox.Show("PubIng is not found.", "Fail");
            }
            return pub_ingred1;
        }
        public void UpdatePubIngred(Pub_ingred pub_ingred)
        {
            if (GetAllPubs().Any(elem => elem.Id == pub_ingred.Id_pub) && GetAllIngredients().Any(elem => elem.Id == pub_ingred.Id_ingred))
            {
                string sql = "UPDATE 4lab.`pub-ingredient` SET id_pub = ?id_pub, id_ingred = ?id_ingred, countLeft = ?countLeft " +
                            "WHERE idpubIngred = ?idpubIngred";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = pub_ingred.Id_pub;
                            command.Parameters.Add("?id_ingred", MySqlDbType.Int32).Value = pub_ingred.Id_ingred;
                            command.Parameters.Add("?countLeft", MySqlDbType.Double).Value = pub_ingred.CountLeft;
                            command.Parameters.Add("?idpubIngred", MySqlDbType.Int32).Value = pub_ingred.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("PubIngred with that data can't exist.", "Fail");
            }
        }
        public void DeletePubIngred(int id)
        {
            string sqlExpression = "DELETE FROM 4lab.`pub-ingredient` WHERE idpubIngred = ?id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void AddPubIngred(Pub_ingred pub_ingred)
        {
            if (GetAllPubs().Any(elem => elem.Id == pub_ingred.Id_pub) && GetAllIngredients().Any(elem => elem.Id == pub_ingred.Id_ingred))
            {
                string sqlExpression = "INSERT INTO 4lab.`pub-ingredient` (id_pub, id_ingred, countLeft) " +
               "VALUES (?id_pub, ?id_ingred, ?countLeft)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = pub_ingred.Id_pub;
                            command.Parameters.Add("?id_ingred", MySqlDbType.Int32).Value = pub_ingred.Id_ingred;
                            command.Parameters.Add("?countLeft", MySqlDbType.Double).Value = pub_ingred.CountLeft;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ProdIngred with that data can't exist.", "Fail");
            }
        }


        public List<ProdIngred> GetAllprodIngreds()
        {
            List<ProdIngred> prodingreds = new List<ProdIngred>();
            string sql = "SELECT * FROM 4lab.`product-ingredient`;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ProdIngred prodingred1 = new ProdIngred(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                                Convert.ToInt32(reader[2]), Convert.ToDouble(reader[3]));

                            prodingreds.Add(prodingred1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return prodingreds;
        }
        public ProdIngred GetprodIngredById(int id)
        {
            ProdIngred prodIngred1 = null;
            string sql = "SELECT * FROM 4lab.`product-ingredient` WHERE `idproduct-ingredient` = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            prodIngred1 = new ProdIngred(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                                Convert.ToInt32(reader[2]), Convert.ToDouble(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (prodIngred1 == null)
            {
                System.Windows.Forms.MessageBox.Show("ProdIng is not found.", "Fail");
            }
            return prodIngred1;
        }
        public void UpdateprodIngred(ProdIngred prodIngred)
        {
            if (GetAllproducts().Any(elem => elem.Id == prodIngred.Id_product) && GetAllIngredients().Any(elem => elem.Id == prodIngred.Id_ingredient))
            {
                string sql = "UPDATE 4lab.`product-ingredient` SET id_product = ?id_product, id_ingredient = ?id_ingredient, countIngredint = ?countIngredint " +
                            "WHERE `idproduct-ingredient` = ?idproductIngredient";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?id_product", MySqlDbType.Int32).Value = prodIngred.Id_product;
                            command.Parameters.Add("?id_ingredient", MySqlDbType.Int32).Value = prodIngred.Id_ingredient;
                            command.Parameters.Add("?countIngredint", MySqlDbType.Double).Value = prodIngred.CountIngredient;
                            command.Parameters.Add("?idproductIngredient", MySqlDbType.Int32).Value = prodIngred.Id;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ProdIngred with that data can't exist.", "Fail");
            }
        }
        public void DeleteprodIngred(int id)
        {
            string sqlExpression = "DELETE FROM 4lab.`product-ingredient` WHERE `idproduct-ingredient` = ?id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void AddprodIngred(ProdIngred prodIngred)
        {
            if (GetAllproducts().Any(elem => elem.Id == prodIngred.Id_product) && GetAllIngredients().Any(elem => elem.Id == prodIngred.Id_ingredient))
            {
                string sqlExpression = "INSERT INTO 4lab.`product-ingredient` (id_product, id_ingredient, countIngredint) " +
               "VALUES (?id_product, ?id_ingredient, ?countIngredint)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id_product", MySqlDbType.Int32).Value = prodIngred.Id_product;
                            command.Parameters.Add("?id_ingredient", MySqlDbType.Int32).Value = prodIngred.Id_ingredient;
                            command.Parameters.Add("?countIngredint", MySqlDbType.Double).Value = prodIngred.CountIngredient;

                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ProdIngred with that data can't exist.", "Fail");
            }
        }


        public List<TypeIngred> GetAlltypeIngreds()
        {
            List<TypeIngred> TypeIngreds = new List<TypeIngred>();
            string sql = "SELECT * FROM typeofingredient";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            TypeIngred typeingred1 = new TypeIngred(Convert.ToInt32(reader[0]), reader[1].ToString());

                            TypeIngreds.Add(typeingred1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return TypeIngreds;
        }
        public TypeIngred GettypeIngredById(int id)
        {
            TypeIngred typeIngred1 = null;
            string sql = "SELECT * FROM typeofingredient WHERE idtypeOfIngredient = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            typeIngred1 = new TypeIngred(Convert.ToInt32(reader[0]), reader[1].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (typeIngred1 == null)
            {
                System.Windows.Forms.MessageBox.Show("prodord is not found.", "Fail");
            }
            return typeIngred1;
        }
        public void UpdatetypeIngred(TypeIngred typeIngred)
        {
            string sql = "UPDATE typeofingredient SET measureUnits = ?measureUnits " +
                             "WHERE idtypeOfIngredient = ?idtypeOfIngredient";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?measureUnits", MySqlDbType.VarChar).Value = typeIngred.MeasureUnits;
                        command.Parameters.Add("?idtypeOfIngredient", MySqlDbType.Int32).Value = typeIngred.Id;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void DeletetypeIngred(int id)
        {
            if (GetAllIngredients().Any(elem => elem.Id_typeOfIngredient == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM typeofingredient WHERE idtypeOfIngredient = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void AddtypeIngred(TypeIngred typeIngred)
        {
            string sqlExpression = "INSERT INTO typeofingredient (measureUnits) " +
               "VALUES (?measureUnits)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?measureUnits", MySqlDbType.VarChar).Value = typeIngred.MeasureUnits;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                }

            }
        }


        public List<Provider> GetAllproviders()
        {
            List<Provider> providers = new List<Provider>();
            string sql = "SELECT * FROM provider";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Provider provider1 = new Provider(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), reader[3].ToString());

                            providers.Add(provider1);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }

            }
            return providers;
        }
        public Provider GetproviderById(int id)
        {
            Provider provider1 = null;
            string sql = "SELECT * FROM provider WHERE idprovider = ?id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            provider1 = new Provider(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), reader[3].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (provider1 == null)
            {
                System.Windows.Forms.MessageBox.Show("prodord is not found.", "Fail");
            }
            return provider1;
        }
        public void Updateprovider(Provider provider)
        {
            string sql = "UPDATE provider SET company = ?company, address = ?address, phone = ?phone " +
                             "WHERE idprovider = ?idprovider";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?company", MySqlDbType.VarChar).Value = provider.Company;
                        command.Parameters.Add("?address", MySqlDbType.VarChar).Value = provider.Address;
                        command.Parameters.Add("?phone", MySqlDbType.VarChar).Value = provider.Phone;
                        command.Parameters.Add("?idprovider", MySqlDbType.Int32).Value = provider.Id;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
        }
        public void Deleteprovider(int id)
        {
            if (GetAllIngredients().Any(elem => elem.Id_provider == id))
            {
                System.Windows.Forms.MessageBox.Show("Data is already used in other tables.", "Fail");
            }
            else
            {
                string sqlExpression = "DELETE FROM provider WHERE idprovider = ?id";


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                        {
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    }
                }
            }
        }
        public void Addprovider(Provider provider)
        {
            string sqlExpression = "INSERT INTO 4lab.provider (company, address, phone) " +
               "VALUES (?company, ?address, ?phone)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlExpression, conn))
                    {
                        command.Parameters.Add("?company", MySqlDbType.VarChar).Value = provider.Company;
                        command.Parameters.Add("?address", MySqlDbType.VarChar).Value = provider.Address;
                        command.Parameters.Add("?phone", MySqlDbType.VarChar).Value = provider.Phone;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");

                }

            }

        }


        //Login
        public Worker checkLogin(string login, string pass)
        {

            List<Worker> list_worker = GetAllWorkers();
            foreach (Worker elem in list_worker)
            {
                if (elem.Username == login && elem.Password == pass)
                {
                    return elem;
                }
            }
            return null;
        }

        //Barmen
        public Product GetProductByName(string name)
        {
            Product product1 = null;
            string sql = "SELECT * FROM product WHERE name = ?name";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            product1 = new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDouble(reader[2]),
                                Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (product1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Product is not found.", "Fail");
            }
            return product1;
        }

        public bool GetIngredientsOfProduct(int id_prod, int id_pub, List<double> cnt_need, List<double> cnt_left)
        {

            if (GetAllproducts().Any(elem => elem.Id == id_prod) && GetAllprodIngreds().Any(elem => elem.Id_product == id_prod) && 
                GetAllPubIngreds().Any(elem => elem.Id_pub == id_pub) )
            {
                cnt_need.Clear(); cnt_left.Clear();

                string sql = "SELECT countIngredint, countLeft FROM 4lab.ingredient " +
                    "INNER JOIN 4lab.`product-ingredient` ON id_ingredient = idingredient " +
                    "INNER JOIN 4lab.`pub-ingredient` ON id_ingred = idingredient " +
                    "WHERE id_pub = ?id_pub AND id_product = ?id";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = id_pub;
                            command.Parameters.Add("?id", MySqlDbType.Int32).Value = id_prod;
                            
                            MySqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                cnt_need.Add(Convert.ToDouble(reader[0]));
                                cnt_left.Add(Convert.ToDouble(reader[1]));
                            }
                            reader.Close();
                        }
                        return true;
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Db Fail");
                    }
                }
            }
            return false;
        }

        public bool GetAllWaitersAndBarmens(int id_pub, List<string> names, List<string> surnames)
        {
            if (GetAllPubs().Any(elem => elem.Id == id_pub) )
            {
                names.Clear(); surnames.Clear();

                string sql = "SELECT name, surname FROM 4lab.worker " +
                    "WHERE id_pub = ?id_pub AND ( id_post = 2 OR id_post = 4)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = id_pub;

                            MySqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                names.Add(reader[0].ToString());
                                surnames.Add(reader[1].ToString());
                            }
                            reader.Close();
                        }
                        return true;
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Connection Fault.", "Db Fail");
                    }
                }
            }
            return false;
        }

        public Worker GetWorkerByName(string name, string surname)
        {

            Worker worker1 = null;
            string sql = "SELECT * FROM 4lab.worker WHERE name = ?name AND surname = ?surname";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                        command.Parameters.Add("?surname", MySqlDbType.VarChar).Value = surname;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            worker1 = new Worker(Convert.ToInt32(reader[0]), reader[1].ToString(),
                            reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]),
                            reader[6].ToString(), Convert.ToBoolean(reader[7]), Convert.ToInt32(reader[8]), Convert.ToInt32(reader[9]),
                            reader[10].ToString(), reader[11].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Db Fail");
                }
            }
            if (worker1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Worker is not found.", "Db Fail");
            }
            return worker1;
        }

        public Order GetOrderByTimeWork(DateTime time, bool issue, int id_work)
        {
            Order order1 = null;
            string sql = "SELECT * FROM 4lab.order WHERE time = ?time AND issued = ?issued AND idworker = ?idworker";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?time", MySqlDbType.DateTime).Value = time.ToString("yyyy-MM-dd HH:mm:ss");
                        command.Parameters.Add("?issued", MySqlDbType.Binary).Value = issue ? 1 : 0;
                        command.Parameters.Add("?idworker", MySqlDbType.Int32).Value = id_work;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            order1 = new Order(Convert.ToInt32(reader[0]), DateTime.Parse(reader[1].ToString()), Convert.ToBoolean(reader[2]), Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (order1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Order is not found.", "Fail");
            }
            return order1;
        }

        //Cook
        public List<Order> GetAllNonIssuedOrders(int id_pub)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT order.idorder, order.time, order.issued, order.idworker FROM 4lab.order " +
                     "INNER JOIN 4lab.worker ON order.idworker = worker.idworker " +
                     "WHERE id_pub = ?id_pub AND issued = 0";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {

                        command.Parameters.Add("?id_pub", MySqlDbType.Int32).Value = id_pub;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Order order = new Order(Convert.ToInt32(reader[0]), DateTime.Parse(reader[1].ToString()), Convert.ToBoolean(reader[2]), Convert.ToInt32(reader[3]));
                            orders.Add(order);
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            return orders;
        }

        public bool GetProductOfOrder(int id_order, List<string> names, List<int> counts)
        {
            names.Clear();
            counts.Clear();

            string sql = "SELECT product.name, `product-order`.countProduct FROM 4lab.`product-order` " +
                     "INNER JOIN 4lab.product ON idproduct = id_product " +
                     "WHERE id_order = ?id_order";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {

                        command.Parameters.Add("?id_order", MySqlDbType.Int32).Value = id_order;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            names.Add(reader[0].ToString());
                            counts.Add(Convert.ToInt32(reader[1]));
                        }
                        reader.Close();
                        return true;
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                    return false;
                }
            }
        }

        public Ingredient GetIngredientByName(string name)
        {
            Ingredient ingredient1 = null;
            string sql = "SELECT * FROM 4lab.ingredient WHERE name = ?name";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ingredient1 = new Ingredient(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]),
                                Convert.ToInt32(reader[3]));
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (ingredient1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Ingredient is not found.", "Fail");
            }
            return ingredient1;
        }

        public Provider GetProviderByName(string company)
        {
            Provider provider1 = null;
            string sql = "SELECT * FROM 4lab.provider WHERE company = ?company";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?company", MySqlDbType.VarChar).Value = company;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            provider1 = new Provider(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(),
                                reader[3].ToString() );
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (provider1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Ingredient is not found.", "Fail");
            }
            return provider1;
        }

        public TypeIngred GetTypeIngredByName(string measureUnits)
        {
            TypeIngred typeIngred1 = null;
            string sql = "SELECT * FROM 4lab.typeOfIngredient WHERE measureUnits = ?measureUnits";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?measureUnits", MySqlDbType.VarChar).Value = measureUnits;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            typeIngred1 = new TypeIngred(Convert.ToInt32(reader[0]), reader[1].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (typeIngred1 == null)
            {
                System.Windows.Forms.MessageBox.Show("Ingredient is not found.", "Fail");
            }
            return typeIngred1;
        }

        public Prod_type GetTypeProdByName(string type)
        {
            Prod_type Prod_type1 = null;
            string sql = "SELECT * FROM 4lab.typeproduct WHERE type = ?type";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.Add("?type", MySqlDbType.VarChar).Value = type;
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Prod_type1 = new Prod_type(Convert.ToInt32(reader[0]), reader[1].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Connection Fault.", "Fail");
                }
            }
            if (Prod_type1 == null)
            {
                System.Windows.Forms.MessageBox.Show("type of product is not found.", "Fail");
            }
            return Prod_type1;
        }
    }
}