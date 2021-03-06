﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CourierDBEntities : DbContext
    {
        public CourierDBEntities()
            : base("name=CourierDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<tblLogin> tblLogin { get; set; }
        public virtual DbSet<User> User { get; set; }
    
        public virtual int spAddPackage(Nullable<System.DateTime> acceptDate, Nullable<double> packageWeight, Nullable<double> cost, string senderAddress, string receiverAddress, Nullable<int> customerID, Nullable<int> employeeID, string currentLocation, string packageStatus)
        {
            var acceptDateParameter = acceptDate.HasValue ?
                new ObjectParameter("acceptDate", acceptDate) :
                new ObjectParameter("acceptDate", typeof(System.DateTime));
    
            var packageWeightParameter = packageWeight.HasValue ?
                new ObjectParameter("packageWeight", packageWeight) :
                new ObjectParameter("packageWeight", typeof(double));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("cost", cost) :
                new ObjectParameter("cost", typeof(double));
    
            var senderAddressParameter = senderAddress != null ?
                new ObjectParameter("senderAddress", senderAddress) :
                new ObjectParameter("senderAddress", typeof(string));
    
            var receiverAddressParameter = receiverAddress != null ?
                new ObjectParameter("receiverAddress", receiverAddress) :
                new ObjectParameter("receiverAddress", typeof(string));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var currentLocationParameter = currentLocation != null ?
                new ObjectParameter("currentLocation", currentLocation) :
                new ObjectParameter("currentLocation", typeof(string));
    
            var packageStatusParameter = packageStatus != null ?
                new ObjectParameter("packageStatus", packageStatus) :
                new ObjectParameter("packageStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddPackage", acceptDateParameter, packageWeightParameter, costParameter, senderAddressParameter, receiverAddressParameter, customerIDParameter, employeeIDParameter, currentLocationParameter, packageStatusParameter);
        }
    
        public virtual int spDeletePackageById(Nullable<int> consignmentId)
        {
            var consignmentIdParameter = consignmentId.HasValue ?
                new ObjectParameter("consignmentId", consignmentId) :
                new ObjectParameter("consignmentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePackageById", consignmentIdParameter);
        }
    
        public virtual ObjectResult<spGetPackageByConsignmentID_Result> spGetPackageByConsignmentID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPackageByConsignmentID_Result>("spGetPackageByConsignmentID", idParameter);
        }
    
        public virtual ObjectResult<spGetPackageById_Result> spGetPackageById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPackageById_Result>("spGetPackageById", idParameter);
        }
    
        public virtual ObjectResult<spGetPackages_Result> spGetPackages()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPackages_Result>("spGetPackages");
        }
    
        public virtual ObjectResult<spPackageSearch_Result> spPackageSearch(string key)
        {
            var keyParameter = key != null ?
                new ObjectParameter("key", key) :
                new ObjectParameter("key", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPackageSearch_Result>("spPackageSearch", keyParameter);
        }
    
        public virtual int spStaffRegister(string first_Name, string last_Name, string gender, string email, string password, Nullable<long> contactNumber, Nullable<int> salary, string designation, string permanentAddr, string correspondenceAddr, string loginType)
        {
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("first_Name", first_Name) :
                new ObjectParameter("first_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("last_Name", last_Name) :
                new ObjectParameter("last_Name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var contactNumberParameter = contactNumber.HasValue ?
                new ObjectParameter("contactNumber", contactNumber) :
                new ObjectParameter("contactNumber", typeof(long));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var designationParameter = designation != null ?
                new ObjectParameter("designation", designation) :
                new ObjectParameter("designation", typeof(string));
    
            var permanentAddrParameter = permanentAddr != null ?
                new ObjectParameter("permanentAddr", permanentAddr) :
                new ObjectParameter("permanentAddr", typeof(string));
    
            var correspondenceAddrParameter = correspondenceAddr != null ?
                new ObjectParameter("correspondenceAddr", correspondenceAddr) :
                new ObjectParameter("correspondenceAddr", typeof(string));
    
            var loginTypeParameter = loginType != null ?
                new ObjectParameter("loginType", loginType) :
                new ObjectParameter("loginType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spStaffRegister", first_NameParameter, last_NameParameter, genderParameter, emailParameter, passwordParameter, contactNumberParameter, salaryParameter, designationParameter, permanentAddrParameter, correspondenceAddrParameter, loginTypeParameter);
        }
    
        public virtual int spUpdatePackage(Nullable<int> consignmentId, Nullable<System.DateTime> acceptDate, Nullable<double> packageWeight, Nullable<double> cost, string senderAddress, string receiverAddress, Nullable<int> customerID, Nullable<int> employeeID, string currentLocation, string packageStatus)
        {
            var consignmentIdParameter = consignmentId.HasValue ?
                new ObjectParameter("consignmentId", consignmentId) :
                new ObjectParameter("consignmentId", typeof(int));
    
            var acceptDateParameter = acceptDate.HasValue ?
                new ObjectParameter("acceptDate", acceptDate) :
                new ObjectParameter("acceptDate", typeof(System.DateTime));
    
            var packageWeightParameter = packageWeight.HasValue ?
                new ObjectParameter("packageWeight", packageWeight) :
                new ObjectParameter("packageWeight", typeof(double));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("cost", cost) :
                new ObjectParameter("cost", typeof(double));
    
            var senderAddressParameter = senderAddress != null ?
                new ObjectParameter("senderAddress", senderAddress) :
                new ObjectParameter("senderAddress", typeof(string));
    
            var receiverAddressParameter = receiverAddress != null ?
                new ObjectParameter("receiverAddress", receiverAddress) :
                new ObjectParameter("receiverAddress", typeof(string));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var currentLocationParameter = currentLocation != null ?
                new ObjectParameter("currentLocation", currentLocation) :
                new ObjectParameter("currentLocation", typeof(string));
    
            var packageStatusParameter = packageStatus != null ?
                new ObjectParameter("packageStatus", packageStatus) :
                new ObjectParameter("packageStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdatePackage", consignmentIdParameter, acceptDateParameter, packageWeightParameter, costParameter, senderAddressParameter, receiverAddressParameter, customerIDParameter, employeeIDParameter, currentLocationParameter, packageStatusParameter);
        }
    
        public virtual ObjectResult<spUserLogin_Result> spUserLogin(string userName, string password, string userType)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("userType", userType) :
                new ObjectParameter("userType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUserLogin_Result>("spUserLogin", userNameParameter, passwordParameter, userTypeParameter);
        }
    
        public virtual int spUserRegister(string first_Name, string last_Name, string gender, string email, string password, Nullable<long> contactNumber)
        {
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("first_Name", first_Name) :
                new ObjectParameter("first_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("last_Name", last_Name) :
                new ObjectParameter("last_Name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var contactNumberParameter = contactNumber.HasValue ?
                new ObjectParameter("contactNumber", contactNumber) :
                new ObjectParameter("contactNumber", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUserRegister", first_NameParameter, last_NameParameter, genderParameter, emailParameter, passwordParameter, contactNumberParameter);
        }
    }
}
