﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniProjectAdo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MiniProjectEntities : DbContext
    {
        public MiniProjectEntities()
            : base("name=MiniProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<train> trains { get; set; }
        public virtual DbSet<TrainBerthInfo> TrainBerthInfoes { get; set; }
        public virtual DbSet<UserPer> UserPers { get; set; }
        public virtual DbSet<CancelTicket> CancelTickets { get; set; }
    
        public virtual int AddTrain(Nullable<int> trainID, string trainName, string source, string destination)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrain", trainIDParameter, trainNameParameter, sourceParameter, destinationParameter);
        }
    
        public virtual int AddTrainBerthInfo(Nullable<int> trainID, string berthClass, Nullable<int> totalSeats, Nullable<int> availableSeats, Nullable<decimal> price)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            var berthClassParameter = berthClass != null ?
                new ObjectParameter("BerthClass", berthClass) :
                new ObjectParameter("BerthClass", typeof(string));
    
            var totalSeatsParameter = totalSeats.HasValue ?
                new ObjectParameter("TotalSeats", totalSeats) :
                new ObjectParameter("TotalSeats", typeof(int));
    
            var availableSeatsParameter = availableSeats.HasValue ?
                new ObjectParameter("AvailableSeats", availableSeats) :
                new ObjectParameter("AvailableSeats", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrainBerthInfo", trainIDParameter, berthClassParameter, totalSeatsParameter, availableSeatsParameter, priceParameter);
        }
    
        public virtual int ChangeTrainStatus(Nullable<int> trainID)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeTrainStatus", trainIDParameter);
        }
    
        public virtual ObjectResult<GetActiveTrains_Result> GetActiveTrains()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetActiveTrains_Result>("GetActiveTrains");
        }
    
        public virtual ObjectResult<GetBirthDetal_Result> GetBirthDetal(Nullable<int> trainID)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBirthDetal_Result>("GetBirthDetal", trainIDParameter);
        }
    
        public virtual int ModifyTrain(Nullable<int> trainID, string trainName, string source, string destination)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyTrain", trainIDParameter, trainNameParameter, sourceParameter, destinationParameter);
        }
    
        public virtual ObjectResult<ShowAllTrain_Result> ShowAllTrain()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowAllTrain_Result>("ShowAllTrain");
        }
    
        public virtual ObjectResult<ShowAllTrains_Result> ShowAllTrains()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowAllTrains_Result>("ShowAllTrains");
        }
    
        public virtual int SoftDeleteTrain(Nullable<int> trainID)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SoftDeleteTrain", trainIDParameter);
        }
    
        public virtual int UpdateTrain(Nullable<int> trainID, string trainName, string source, string destination)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTrain", trainIDParameter, trainNameParameter, sourceParameter, destinationParameter);
        }
    
        public virtual ObjectResult<ViewTrain_Result> ViewTrain(Nullable<int> trainID)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewTrain_Result>("ViewTrain", trainIDParameter);
        }
    
        public virtual ObjectResult<ViewTrainStatus_Result> ViewTrainStatus(Nullable<int> trainID)
        {
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewTrainStatus_Result>("ViewTrainStatus", trainIDParameter);
        }
    
        public virtual int BookTrainTicket(string userName, Nullable<int> trainID, string berthClass, Nullable<int> totalTickets)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var trainIDParameter = trainID.HasValue ?
                new ObjectParameter("TrainID", trainID) :
                new ObjectParameter("TrainID", typeof(int));
    
            var berthClassParameter = berthClass != null ?
                new ObjectParameter("BerthClass", berthClass) :
                new ObjectParameter("BerthClass", typeof(string));
    
            var totalTicketsParameter = totalTickets.HasValue ?
                new ObjectParameter("TotalTickets", totalTickets) :
                new ObjectParameter("TotalTickets", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BookTrainTicket", userNameParameter, trainIDParameter, berthClassParameter, totalTicketsParameter);
        }
    
        public virtual ObjectResult<Printticket_Result> Printticket(Nullable<int> bookingID)
        {
            var bookingIDParameter = bookingID.HasValue ?
                new ObjectParameter("BookingID", bookingID) :
                new ObjectParameter("BookingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Printticket_Result>("Printticket", bookingIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetLastBookingID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetLastBookingID");
        }
    
        public virtual int CancelTicketData(Nullable<int> bookingID)
        {
            var bookingIDParameter = bookingID.HasValue ?
                new ObjectParameter("BookingID", bookingID) :
                new ObjectParameter("BookingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CancelTicketData", bookingIDParameter);
        }
    }
}
