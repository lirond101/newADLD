using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponsSystems
{
    public class DataAccessLayer
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader rdr = null;

        public DataAccessLayer()
        {
            //conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Amit\Documents\visual studio 2012\Projects\CouponsSystems\CouponsSystems\coupons.mdf;Integrated Security=True";
            //conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\לימודים\שנה ג\סמסטר ב\ניתוח ועיצוב\ass2Ver2\CouponsSystems\CouponsSystems\coupons.mdf;Integrated Security=True";
            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Eden_Yakobi\Desktop\CouponsSystems\CouponsSystems\coupons.mdf;Integrated Security=True";
            command.Connection = conn;
        }

        private bool updateTable(string table, string values, string key)
        {
            string sqlText = "UPDATE " + table + " SET " + values + " WHERE " + key;
            command.CommandText = sqlText;
            bool result = true;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return result;
        }

        private bool insertToTable(string table, string values, string fields)
        {

            string sqlText = "";
            if (fields == "")
                sqlText = "INSERT INTO " + table + " VALUES (" + values + ")";
            else
                sqlText = "INSERT INTO " + table + "(" + fields + ")" + " VALUES (" + values + ")";
            command.CommandText = sqlText;
            bool result = true;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return result;
        }
        
        /// <summary> 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pass"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="type">3=admin, 1=customer, 2=owner</param>
        public bool addGeneralUser(string userName, string pass, string fname, string lname, int type)
        {
            string values = "'"+userName+"', '"+pass+"', '"+fname+"', '"+lname+"', "+type;
            return insertToTable("Users", values, "");
        }

        public bool addAdministrator(string userName, string eID)
        {
            string values = "'" + userName + "', '" + eID + "'";
            return insertToTable("Administrators", values, "");
        }

        /// <summary>
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="email"></param>
        /// <param name="dob">yyyy-mm-dd</param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="pref">2=fun, 1=restaurant, 4=shopping 3=sports</param>
        public bool addCustomer(string uname, string email, string dob, string address, string city, string phone, int pref)
        {
            string vals = "'"+uname+"', '"+email+"', '"+dob+"', '"+address+"', '" + city + "', '" +phone+"', "+pref;
            string fields = "UserName, Email, DateOfBirth, Address, City, Phone_num, CouponPreference";
            return insertToTable("Customers", vals, fields);
        }

        public bool addStoreOwner(string uname, string email, string phone)
        {
            string values = "'" + uname + "', '" + email + "', '"+phone+"'";
            return insertToTable("StoreOwners", values, "");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeID"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="address"></param>
        /// <param name="catagory">2=fun, 1=restaurant, 4=shopping 3=sports</param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="owner"></param>
        public bool addStore(string storeID, string name, string desc, string address, int catagory, string city, string phone, string owner)
        {
            string fields = "StoreID, Name, Description, Address, StoreCatagory, City, Phone_num, StoreOwner";
            string values = "'" + storeID + "', '" + name + "', '" + desc + "', '" + address + "', " + catagory + ", '" +city + "', '"  +  phone + "', '" + owner + "'";
            return insertToTable("Stores", values, fields);
        }

        public bool addDeal(string oDate, string serial, int cCode, string customerUN)
        {
            string fields = "OrderDate, SerialKey, CouponCode, Customer";
            string values = "'" + oDate + "', '" + serial + "', " + cCode + ", '" + customerUN + "'";
            return insertToTable("Deals", values, fields);
        }

        public bool addCity(string name, int tlX, int tlY, int brX, int brY)
        {
            string values = "'" + name + "', " + tlX + ", " + tlY + ", " + brX + ", " + brY;
            return insertToTable("Cities", values, "");
        }

        public bool addCoupon(string name, string desc, string storeID, double OriginialPrice, double DiscountPrice, string deadline, int daysValid)
        {
            
            string values = "'" + name + "', '" + desc + "', '" + storeID + "', " + OriginialPrice + ", " + DiscountPrice + ", '" + deadline + "', " + daysValid + ", 0, 0, 0";
            return insertToTable("Coupons", values, "");
        }

        public void editDeal(string values, int DealCode)
        {
            updateTable("Deals", values, "PurchaseCode = " + DealCode);
        }

        public void editDealToUsed(string serialKey)
        {
            updateTable("Deals", "Status = 3", "SerialKey = '" + serialKey + "'");
        }

        public void editDealToPayed(string serialKey)
        {
            updateTable("Deals", "Status = 2", "SerialKey = '" + serialKey + "'");
        }

        public void editCoupon(string values, int cCode)
        {
            updateTable("Coupons", values, "Code = " + cCode);
        }

        public void editAdministrator(string values, string EmployeeID)
        {
            updateTable("Administrators", values, "EmployeeID = '" + EmployeeID + "'");
        }

        public bool editCustomer(string values, string UserName)
        {
            return updateTable("Customers", values, "UserName = '" + UserName + "'");
        }

        public void editStore(string values, string StoreID)
        {
            updateTable("Stores", values, "StoreID = '" + StoreID +"'");
        }

        public void editStoreOwner(string values, string UserName)
        {
            updateTable("StoreOwners", values, "StoreID = '" + UserName+"'");
        }

        public Dictionary<string, Customer> getAllCustomers()
        {
            Dictionary<string, Customer> AllCustomers = new Dictionary<string, Customer>();
            try
            {
                conn.Open();
                command.CommandText = "select * from Customers join Users on Customers.UserName = Users.UserName";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string userName = (string)rdr["UserName"];
                    string password = (string)rdr["Password"];
                    string firstName = (string)rdr["First_Name"];
                    string LastName = (string)rdr["Last_Name"];
                    string email = (string)rdr["Email"];
                    DateTime dob;
                    if (!DateTime.TryParse(rdr["DateOfBirth"].ToString(), out dob))
                        dob = new DateTime(1990,1,1);
                    string address = (string)rdr["Address"];
                    string city = (string)rdr["City"];
                    string phone = (string)rdr["Phone_num"];
                    int pref;
                    if (!int.TryParse(rdr["CouponPreference"].ToString(), out pref))
                        pref = 1;
                    Customer c = new Customer(userName, password, firstName, LastName, email, dob, address, city, phone, pref);
                    AllCustomers.Add(userName, c);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                conn.Close();
            }
            return AllCustomers;
        }

        public Dictionary<string, Administrator> getAllAdministrators()
        {
            Dictionary<string, Administrator> AllAdmins = new Dictionary<string, Administrator>();
            try
            {
                conn.Open();
                command.CommandText = "select * from Administrators join Users on Administrators.UserName = Users.UserName";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string userName = (string)rdr["UserName"];
                    string password = (string)rdr["Password"];
                    string firstName = (string)rdr["First_Name"];
                    string LastName = (string)rdr["Last_Name"];
                    string eeID = (string)rdr["EmployeeID"];
                    Administrator a = new Administrator(userName, password, firstName, LastName, eeID);
                    AllAdmins.Add(userName, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllAdmins;
        }

        public Dictionary<string, StoreOwner> GetAllOwners()
        {
            Dictionary<string, StoreOwner> AllOwners = new Dictionary<string, StoreOwner>();
            try
            {
                conn.Open();
                command.CommandText = "select * from StoreOwners join Users on StoreOwners.UserName = Users.UserName";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string userName = (string)rdr["UserName"];
                    string password = (string)rdr["Password"];
                    string firstName = (string)rdr["First_Name"];
                    string LastName = (string)rdr["Last_Name"];
                    string email = (string)rdr["Email"];
                    string phone = (string)rdr["Phone_num"];
                    StoreOwner a = new StoreOwner(userName, password, firstName, LastName, email, phone);
                    AllOwners.Add(userName, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllOwners;
        }

        public Dictionary<string, Store> getAllStores(string condition)
        {
            Dictionary<string, Store> AllStores = new Dictionary<string, Store>();
            try
            {

                conn.Open();
                if (condition == "")
                    command.CommandText = "select * from Stores";
                else
                    command.CommandText = "select * from Stores where " + condition;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    int catagory;
                    if (!int.TryParse(rdr["StoreCatagory"].ToString(), out catagory))
                        catagory = 1;
                    double rank;
                    if (!double.TryParse(rdr["Store_Rank"].ToString(), out rank))
                        rank = 0;
                    string storeID = (string)rdr["StoreID"];
                    string Name = (string)rdr["Name"];
                    string desc = (string)rdr["Description"];
                    string add = (string)rdr["Address"];
                    string city = (string)rdr["City"];
                    string phone = (string)rdr["Phone_num"];
                    string storeOwnerUN = (string)rdr["StoreOwner"];
                    Store a = new Store(storeID, Name, desc, add, catagory, city, phone, rank, storeOwnerUN);
                    AllStores.Add(storeID, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllStores;
        }

        public Dictionary<string, City> getAllCities()
        {
            Dictionary<string, City> AllCities = new Dictionary<string, City>();
            try
            {
                conn.Open();
                command.CommandText = "select * from Cities";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    int tlx;
                    if (!int.TryParse(rdr["TopLeft_X"].ToString(), out tlx))
                        tlx = 0;
                    int tly;
                    if (!int.TryParse(rdr["TopLeft_Y"].ToString(), out tly))
                        tly = 0;
                    int brx;
                    if (!int.TryParse(rdr["BottomRight_X"].ToString(), out brx))
                        brx = 0;
                    int bry;
                    if (!int.TryParse(rdr["BottomRight_Y"].ToString(), out bry))
                        bry = 0;
                    string Name = (string)rdr["Name"];

                    City a = new City(Name, tlx, tly, brx, bry);
                    AllCities.Add(Name, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllCities;
        }

        public Dictionary<int, Deal> getAllDeals(string condition)
        {
            Dictionary<int, Deal> AllDeals = new Dictionary<int, Deal>();
            try
            {
                conn.Open();
                if (condition == "")
                    command.CommandText = "select * from Deals, Coupons where Deals.CouponCode = Coupons.Code";
                else
                    command.CommandText = "select * from Deals, Coupons where Deals.CouponCode = Coupons.Code and " + condition;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    int status;
                    if (!int.TryParse(rdr["Status"].ToString(), out status))
                        status = 1;
                    int CouponCode;
                    if (!int.TryParse(rdr["CouponCode"].ToString(), out CouponCode))
                        CouponCode = 0;
                    double UserRank;
                    if (!double.TryParse(rdr["UserRank"].ToString(), out UserRank))
                        UserRank = 0;
                    int PurchaseCode;
                    if (!int.TryParse(rdr["PurchaseCode"].ToString(), out PurchaseCode))
                        PurchaseCode = 0;
                    string SerialKey = (string)rdr["SerialKey"];
                    DateTime orderDate;
                    if (!DateTime.TryParse(rdr["OrderDate"].ToString(), out orderDate))
                        orderDate = DateTime.Today;
                    int daysValid;
                    if (!int.TryParse(rdr["daysValid"].ToString(), out daysValid))
                        daysValid = 0;
                    int daysPassed = (int)DateTime.Now.Subtract(orderDate).TotalDays;
                    if (daysValid - daysPassed < 0)
                        daysValid = 0;
                    else
                        daysValid = daysValid - daysPassed;
                    string customer = (string)rdr["Customer"];
                    string store = (string)rdr["Store"];
                    string name = (string)rdr["Name"];
                    double price;
                    if (!double.TryParse(rdr["DiscountPrice"].ToString(), out price))
                        UserRank = 0;
                    Deal a = new Deal(PurchaseCode, SerialKey, orderDate, status, CouponCode, customer, store, UserRank, price, name, daysValid);
                    AllDeals.Add(PurchaseCode, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllDeals;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="approved">0 = all, 1 = approved, 2 = unapproved</param>
        /// <returns></returns>
        public Dictionary<int, Coupon> getAllCouponsByApproval(int approved)
        {
            if (approved == 1)
                return getAllCoupons("Approved = 1");
            else if (approved == 2)
                return getAllCoupons("Approved = 0");
            else
                return getAllCoupons("");

        }

        public Dictionary<int, Coupon> getAllCoupons(string condition)
        {
            Dictionary<int, Coupon> AllCoupons = new Dictionary<int, Coupon>();
            try
            {
                conn.Open();
                if (condition == "")
                    command.CommandText = "select * from Coupons, Stores where Coupons.Store = Stores.StoreID";
                else
                    command.CommandText = "select * from Coupons, Stores where Coupons.Store = Stores.StoreID and " + condition;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Coupon a = createCoupon(rdr);
                    AllCoupons.Add(a.Code, a);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return AllCoupons;
        }

        ///////// DELETED THESE METHODS!
        ///**
        // * dob = yyyy-mm-dd
        // * 2=fun, 1=restaurant, 4=shopping 3=sports
        // * */
        //public Dictionary<int, Coupon> getAllApprovedByCouponsCatagory(int catagory)
        //{
        //    return getAllCoupons("Approved = 1 and Stores.StoreCatagory = " + catagory);
        //}

        //public Dictionary<int, Coupon> getAllApprovedByCouponsCity(string city)
        //{
        //    return getAllCoupons("Approved = 1 and Stores.City = " + city);
        //}

        public Dictionary<int, Coupon> getAllApprovedByStore(string storeID)
        {
            return getAllCoupons("StoreID = " + storeID);
        }

        public Dictionary<int, Coupon> getAllCouponsByCatagory(int catagory)
        {
            return getAllCoupons("Stores.StoreCatagory = " + catagory);
        }

        public Dictionary<int, Coupon> getAllCouponsByStore(string StoreID)
        {
            return getAllCoupons("Store = '" + StoreID + "'");
        }

        public Dictionary<int, Coupon> getAllCouponsByCity(string City)
        {
            return getAllCoupons("City = " + City);
        }

 

        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * */
        public Dictionary<int, Coupon> getAllApprovedByCityPrefrence(string City, int prefrence)
        {
            if (City != "" && prefrence > 0)
                return getAllCoupons("Approved = 1 and City = '" + City + "' and Stores.StoreCatagory = " + prefrence);
            else if (City == "")
                return getAllCoupons("Approved = 1 and Stores.StoreCatagory = " + prefrence);
            else
                return getAllCoupons("Approved = 1 and City = '" + City + "'");


        }

        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * */


        private Coupon createCoupon(SqlDataReader rdr)
        {
            DateTime purchaseDeadline;
            if (!DateTime.TryParse(rdr["purchaseDeadline"].ToString(), out purchaseDeadline))
                purchaseDeadline = DateTime.Today;
            int Code;
            if (!int.TryParse(rdr["Code"].ToString(), out Code))
                Code = 1;
            int daysValid;
            if (!int.TryParse(rdr["daysValid"].ToString(), out daysValid))
                daysValid = 1;
            int NumOfRanks;
            if (!int.TryParse(rdr["NumOfRanks"].ToString(), out NumOfRanks))
                NumOfRanks = 1;
            int Approved;
            if (!int.TryParse(rdr["Approved"].ToString(), out Approved))
                Approved = 0;
            double OriginalPrice;
            if (!double.TryParse(rdr["OriginalPrice"].ToString(), out OriginalPrice))
                OriginalPrice = 0;
            double DiscountPrice;
            if (!double.TryParse(rdr["DiscountPrice"].ToString(), out DiscountPrice))
                DiscountPrice = 0;
            double CouponRank;
            if (!double.TryParse(rdr["CouponRank"].ToString(), out CouponRank))
                CouponRank = 0;
            string Name = (string)rdr["Name"];
            string Description = (string)rdr["Description"];
            string StoreID = (string)rdr["Store"];
            string City = (string)rdr["City"];
            int catagory = 1;
            if (!int.TryParse(rdr["StoreCatagory"].ToString(), out catagory))
                catagory = 1;
            Coupon a = new Coupon(Code, Name, Description, StoreID, OriginalPrice, DiscountPrice, daysValid, purchaseDeadline, CouponRank, NumOfRanks, Approved, catagory, City);
            return a;
        }

        public User getUser(string UserName)
        {
            User user = null;
            try
            {
                conn.Open();
                command.CommandText = "select * from Users where UserName = '" + UserName +"'";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string userName = (string)rdr["UserName"];
                    string password = (string)rdr["Password"];
                    string firstName = (string)rdr["First_Name"];
                    string LastName = (string)rdr["Last_Name"];
                    int UserType;
                    if (!int.TryParse(rdr["UserType"].ToString(), out UserType))
                        UserType = 1;
                    user = new User(userName, password, firstName, LastName, UserType);
                }
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            return user;  
        }

        public Coupon getCoupon(int Code)
        {
            Dictionary<int, Coupon> all = getAllCoupons("Code = " + Code);
            if (all.Count == 0)
                return null;
            else
                return all.ElementAt(0).Value;
        }

        public void deleteDeal(int dealID)
        {
            string sqlText = "delete from Deals where PurchaseCode = " + dealID;
            command.CommandText = sqlText;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public bool deleteCoupon(int cID)
        {
            string sqlText = "delete from Coupons where Code = " + cID;
            command.CommandText = sqlText;
            bool result = true;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return result;
        }

        public void deleteStore(string storeID)
        {
            string sqlText = "delete from Stores where StoreID = '" + storeID + "'";
            command.CommandText = sqlText;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public Deal getDeal(int dealID)
        {
            Dictionary<int, Deal> deals = getAllDeals("PurchaseCode = " + dealID);
            if (deals.Count == 0)
                return null;
            else
                return deals.ElementAt(0).Value;
        }

        public Deal getDeal(string serialKey)
        {
            Dictionary<int, Deal> deals = getAllDeals("SerialKey = '" + serialKey + "'");
            if (deals.Count == 0)
                return null;
            else
                return deals.ElementAt(0).Value;
        }

        public Store getStore(string StoreID)
        {
            Dictionary<string, Store> all = getAllStores("StoreID = '" + StoreID + "'");
            if (all.Count == 0)
                return null;
            else
                return all.ElementAt(0).Value;
        }

        public Dictionary<int, Deal> AllUnusedDealsByCustomer(string userName)
        {
            return getAllDeals("Status = 2 and Customer = '" + userName + "'");
        }

        public Dictionary<int, Deal> AllUnpayedDealsByCustomer(string userName)
        {
            return getAllDeals("Status = 1 and Customer = '" + userName + "'");
        }

        public Dictionary<int, Deal> AllDealsByCustomer(string userName)
        {
            return getAllDeals("Customer = '" + userName + "'");
        }

        public Dictionary<int, Deal> AllUsedDealsByCustomer(string userName)
        {
            return getAllDeals("Status = 3 and Customer = '" + userName + "'");
        }
    }
}
