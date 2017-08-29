using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class OrderRepo
    {
        private string _connectionString;

        public OrderRepo(string Connstr)
        {
            _connectionString = Connstr;
        }

        public int CreateOrder(Order o)
        {
         
            using(CheckingContext db = new CheckingContext(_connectionString))
            {
                db.Orders.Add(o);
                db.SaveChanges();
            }
            
            return o.OrderID;
        }

        public Order GetOrder(int orderId)
        {
            Order o = null;
            using(CheckingContext db = new CheckingContext(_connectionString))
            {
              o = db.Orders.Find(orderId);
                var email = o.User.UserName;
            }
            return o;
        }

        public Order UpdateOrder(Order order, Questionnaire q)
        {
            using (CheckingContext db = new CheckingContext(_connectionString))
            {
               Order o = db.Orders.Find(order.OrderID);
                o.Questionnaire = q;
                db.SaveChanges();
               
            }
            return order;
        }

        public List<string> GetImagePaths(int orderId)
        {
            List<string> paths = new List<string>();
            
            using (CheckingContext db = new CheckingContext(_connectionString))
            {
              Order order = db.Orders.Find(orderId);
                foreach (var i in order.Images)
                {
                    string s = Path.GetFullPath(i.FileName);
                    paths.Add(s);
                    // FileStream stream = new FileStream(s, FileMode.Open);
                }
            }
            return paths;
        }
    }
}
