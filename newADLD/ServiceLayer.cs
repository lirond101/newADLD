using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class ServiceLayer
    {
        DataAccessLayer data = new DataAccessLayer();

        public string login(string userName, string password)
        {
            User user = data.getUser(userName);
            if (user == null)
                throw new Exception("User Does Not Exist");
            if (user.Password != password)
                throw new Exception("Incorrect Password");
            if (user.getType() == "Administrator")
                return "Administrator";
            else if (user.getType() == "Customer")
                return "Customer";
            else
                return "Store Owner";
        }

        public void approveCoupon(int couponID)
        {
            data.editCoupon("Approved = 1", couponID);
        }

        public void disapproveCoupon(int couponID)
        {
            data.editCoupon("Approved = 0", couponID);
        }

        public Dictionary<int, Coupon> getAllUnapprovedCoupons()
        {
            return data.getAllCouponsByApproval(2);
        }

        public Dictionary<int, Coupon> getAllApprovedCoupons()
        {
            return data.getAllCouponsByApproval(1);
        }
        
        public void addCoupon(string name, string description, string storeID, double originalPrice, double discountPrice, DateTime deadline, int daysValid)
        {
            string date = deadline.ToString("yyyy-MM-dd");
            data.addCoupon(name, description, storeID, originalPrice, discountPrice, date, daysValid);
        }

        public void addAdministrator(string userName, string pass, string fname, string lname, string eID)
        {
            if (!checkUserNameVacancy(userName))
                throw new Exception("User Name already Exists!");
            data.addGeneralUser(userName, pass, fname, lname, 3);
            data.addAdministrator(userName, eID);
        }

        public void addCustomer(string userName, string pass, string fname, string lname, string city, string email, DateTime dob, string address, string phone, int pref)
        {
            if (!checkUserNameVacancy(userName))
                throw new Exception("User Name already Exists!");
            string date = dob.ToString("yyyy-MM-dd");
            data.addGeneralUser(userName, pass, fname, lname, 1);
            data.addCustomer(userName, email, date, address, city, phone, pref);
        }

        public void addStoreOwner(string userName, string pass, string fname, string lname, string email, string phone)
        {
            if (!checkUserNameVacancy(userName))
                throw new Exception("User Name already Exists!");
            data.addGeneralUser(userName, pass, fname, lname, 2);
            data.addStoreOwner(userName, email, phone);
        }

        public void addStore(string storeID, string name, string desc, string address, int catagory, string city, string phone, string owner)
        {
            data.addStore(storeID, name, desc, address, catagory, city, phone, owner);
        }

        public void addDeal(DateTime orderDate, string SerialKey, int couponCode, string CustomerUserName)
        {
            string date = orderDate.ToString("yyyy-MM-dd");
            data.addDeal(date, SerialKey, couponCode, CustomerUserName);
        }

        public bool checkUserNameVacancy(string un)
        {
            User user = data.getUser(un);
            if (user == null)
                return true;
            else
                return false;
        }

        public void editUserLocation(string userName, int x, int y)
        {
            data.editCustomer("currLocationX = " + x + ", currLocationY = " + y, userName);
        }

        public void editStoreOwner(string newEmail, string newPhone, string UserName)
        {
            if (newEmail != "" && newPhone != "")
                data.editStoreOwner("Email = '" + newEmail + "', Phone_num = '" + newPhone + "'", UserName);
            else if (newEmail == "")
                data.editStoreOwner("Phone_num = '" + newPhone + "'", UserName);
            else
                data.editStoreOwner("Email = '" + newEmail + "'", UserName);
        }

        public void editStore(string storeID, string newName, string newDescription, int newCatagoty, string newAddress, string newCity, string newNum, string newOwnerUserName)
        {
            string values = "";
            if (newName != "")
                values = values + "Name = '" + newName + "'";
            if (newDescription != "")
            {
                if (values != "")
                    values = values + ", Description = '" + newDescription + "'";
                else
                    values = values + "Description = '" + newDescription + "'";
            }
            if (newCatagoty != 0)
            {
                if (values != "")
                    values = values + ", StoreCatagory = " + newCatagoty;
                else
                    values = values + "StoreCatagory = " + newCatagoty;
            }
            if (newAddress != "")
            {
                if (values != "")
                    values = values + ", Address = '" + newAddress + "'";
                else
                    values = values + "Address = '" + newAddress + "'";
            }
            if (newCity != "")
            {
                if (values != "")
                    values = values + ", City = '" + newCity + "'";
                else
                    values = values + "City = '" + newCity + "'";
            }
            if (newNum != "")
            {
                if (values != "")
                    values = values + ", Phone_num = '" + newNum + "'";
                else
                    values = values + "Phone_num = '" + newNum + "'";
            }
            if (newOwnerUserName != "")
            {
                if (values != "")
                    values = values + ", StoreOwner = '" + newOwnerUserName + "'";
                else
                    values = values + "StoreOwner = '" + newOwnerUserName + "'";
            }
            data.editStore(values, storeID);
        }

        public void editCustomer(string UserName, string Email, string Address, string City, string Phone_num, int CouponPreference)
        {
            string values = "";
            if (Email != "")
                values = values + "Email = '" + Email + "'";
            if (Address != "")
            {
                if (values != "")
                    values = values + ", Address = '" + Address + "'";
                else
                    values = values + "Address = '" + Address + "'";
            }
            if (CouponPreference != 0)
            {
                if (values != "")
                    values = values + ", CouponPreference = " + CouponPreference;
                else
                    values = values + "CouponPreference = " + CouponPreference;
            }
            if (City != "")
            {
                if (values != "")
                    values = values + ", City = '" + City + "'";
                else
                    values = values + "City = '" + City + "'";
            }
            if (Phone_num != "")
            {
                if (values != "")
                    values = values + ", Phone_num = '" + Phone_num + "'";
                else
                    values = values + "Phone_num = '" + Phone_num + "'";
            }
            data.editCustomer(values, UserName);
        }

        public List<Coupon> getAllCouponsByStore(string storeID)
        {
            return data.getAllCouponsByStore(storeID).Values.ToList();
        }

        public void setLastTimeNotified(string username, DateTime lastTimeNotified)
        {
            data.editCustomer("LastTimeNotified = " + lastTimeNotified.ToString("yyyy-MM-dd hh:mm:ss tt"), username);
        }

        public void deleteCoupon(int CouponID)
        {
            Dictionary<int, Deal> alld = data.getAllDeals("CouponCode = " + CouponID);
            foreach (Deal x in alld.Values)
            {
                    data.deleteDeal(x.purchaseCode);
            }
            data.deleteCoupon(CouponID);
        }

        public void deleteStore(string storeID)
        {
            Dictionary<int, Coupon> allc = data.getAllApprovedByStore(storeID);
            foreach (int x in allc.Keys)
            {
                    deleteCoupon(x);
            }
            data.deleteStore(storeID);
        }

        public Dictionary<int, Coupon> searchByPrefrenceAndLocation(string city, int prefrence)
        {
            return data.getAllApprovedByCityPrefrence(city, prefrence);
        }

        public Dictionary<int, Coupon> searchByPrefrence(int prefrence)
        {
            return data.getAllApprovedByCityPrefrence("", prefrence);
        }

        //amit i changed here
        public Dictionary<int, Coupon> SearchByCity(string city)
        {
            return data.getAllApprovedByCityPrefrence(city, 0);
        }

        public List<City> getAllCities()
        {
            return data.getAllCities().Values.ToList();
        }

        public Dictionary<int, Coupon> searchByLocation(int x, int y)
        {
            Dictionary<string, City> allCities = data.getAllCities();
            string city = "";
            foreach (string xc in allCities.Keys)
            {
                if ((x <= allCities[xc].brx && x >= allCities[xc].tlx) &&
                    (y <= allCities[xc].tly && y >= allCities[xc].bry))
                {
                    city = xc;
                }
            }
            if (city == "")
                return null;
            return data.getAllCoupons(city);
        }

        public Coupon getCoupon(int couponID)
        {
            return data.getCoupon(couponID);
        }

        public void editCoupon(int couponID, string name, DateTime dt, string desc, string storeID, double originalPrice, double discountPrice, int daysValid)
        {
            string values = "";
            if (name != "")
                values = values + "Name = '" + name + "'";
            if (desc != "")
            {
                if (values != "")
                    values = values + ", Description = '" + desc + "'";
                else
                    values = values + "Description = '" + desc + "'";
            }
            if (dt != null)
            {
                if (values != "")
                    values = values + ", purchaseDeadline = '" + dt.ToString("yyyy-MM-dd") + "'";
                else
                    values = values + "purchaseDeadline = " + dt.ToString("yyyy-MM-dd") + "'";
            }
            if (storeID != "")
            {
                if (values != "")
                    values = values + ", Store = '" + storeID + "'";
                else
                    values = values + "Store = '" + storeID + "'";
            }
            if (originalPrice != 0)
            {
                if (values != "")
                    values = values + ", OriginalPrice = " + originalPrice;
                else
                    values = values + "OriginalPrice = " + originalPrice;
            }
            if (discountPrice != 0)
            {
                if (values != "")
                    values = values + ", DiscountPrice = " + discountPrice;
                else
                    values = values + "DiscountPrice = " + discountPrice;
            }
            if (daysValid > 0)
            {
                if (values != "")
                    values = values + ", daysValid = " + daysValid;
                else
                    values = values + "daysValid = " + daysValid;
            }
            data.editCoupon(values, couponID);
        }

      
        public Dictionary<string, Store> getAllStores()
        {
            return data.getAllStores("");
        }

        public Dictionary<string, Store> getAllStoresByOwner(string OwnerID)
        {
            return data.getAllStores("StoreOwner = '" + OwnerID + "'");
        }

        public Store getStoreByID(string storeID)
        {
            return data.getStore(storeID);
        }

        public void setCouponDealToUsed(string serialKey)
        {
            data.editDealToUsed(serialKey);
        }

        public void setCouponDealToOrdered(string serialKey)
        {
            data.editDealToUsed(serialKey);
        }

        public void setCouponDealToPayed(string serialKey)
        {
            data.editDealToPayed(serialKey);
        }

        public List<Deal> AllDealsByCustomer(string userName)
        {
            return data.AllDealsByCustomer(userName).Values.ToList();
        }

        public Deal getDealByPurchaseCode(int code)
        {
            Deal deal = data.getDeal(code);
            if (deal == null)
                throw new Exception("Serial Key Does Not Exist");
            return deal;
        }

        public Deal getDealBySerialKey(string serialKey)
        {
            Deal deal = data.getDeal(serialKey);
            if (deal == null)
                throw new Exception("Serial Key Does Not Exist");
            return deal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serialKey"></param>
        /// <param name="paymentDetails"></param>
        /// <param name="paymentType">1- Paypal, 2 - Credit Card</param>
        public bool payForCoupon(string serialKey, string paymentDetails, int paymentType)
        {
            bool approved = false;
            if (paymentType == 2)
                approved = requestApprovalFromCreditCard(paymentDetails);
            else if (paymentType == 1)
                approved = requestApprovalFromPaypal(paymentDetails);
            if (approved)
            {
                setCouponDealToPayed(serialKey);
                return approved;
            }
            else
                throw new Exception("Payment was not approved");
        }

        private bool requestApprovalFromPaypal(string paymentDetails)
        {
            return true;
        }

        private bool requestApprovalFromCreditCard(string paymentDetails)
        {
            return true;
        }

        public void updateCouponRank(int couponID, int dealID, int rank)
        {
            Coupon newCoupon = data.getCoupon(couponID);
            double newAverage = (newCoupon.couponRank * newCoupon.numOfRanks + rank) / (newCoupon.numOfRanks + 1);
            data.editDeal("UserRank = " + rank, dealID);
            int newNumOfRanks = newCoupon.numOfRanks + 1;
            data.editCoupon("CouponRank = " + newAverage + ", NumOfRanks = " + newNumOfRanks, couponID);
            Dictionary<int, Coupon> allCoupons = data.getAllCouponsByStore(newCoupon.Store);
            double sum = 0;
            int num = 0;
            double storeAverage;
            foreach (Coupon c in allCoupons.Values)
            {
                if (c.couponRank > 0)
                {
                    sum += c.couponRank;
                    num++;
                }
            }
            if (num > 0)
                storeAverage = sum / num;
            else
                storeAverage = 0;
            data.editStore("Store_Rank = " + storeAverage, newCoupon.Store); 
        }
    }
}