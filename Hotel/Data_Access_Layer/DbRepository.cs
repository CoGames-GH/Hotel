using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Data_Access_Layer
{
    public static class DbRepository
{
    public static User GetUser(string login, string pwd)
    {
        var dt = SqlHelper.ExecQuery(
            "SELECT * FROM Users WHERE Login_=@l AND Password_=@p",
            new SqlParameter("@l", login),
            new SqlParameter("@p", pwd));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new User
        {
            Id = (int)r["Id"],
            Login = r["Login_"].ToString(),
            Name = r["Name_"].ToString(),
            Role = r["Role_"].ToString()
        };
    }

    public static DataTable GetRooms(string city, DateTime? fromDate, DateTime? toDate, decimal? maxPrice)
    {
        string sql = @"SELECT * FROM Rooms WHERE 1=1";
        var prms = new List<SqlParameter>();
        if (!string.IsNullOrWhiteSpace(city))
        {
            sql += " AND City=@c";
            prms.Add(new SqlParameter("@c", city));
        }
        if (maxPrice.HasValue)
        {
            sql += " AND PricePerNight<=@p";
            prms.Add(new SqlParameter("@p", maxPrice.Value));
        }
        return SqlHelper.ExecQuery(sql, prms.ToArray());
    }

    public static int InsertRequest(BookingRequest req)
    {
        return SqlHelper.ExecNonQuery(
            @"INSERT BookingRequests(UserId,RoomId,CheckInDate,CheckOutDate,Status_,TotalAmount)
                  VALUES(@uid,@rid,@in,@out,'Забронировано',@sum);
                  SELECT SCOPE_IDENTITY();",
            new SqlParameter("@uid", req.UserId),
            new SqlParameter("@rid", req.RoomId),
            new SqlParameter("@in", req.CheckInDate),
            new SqlParameter("@out", req.CheckOutDate),
            new SqlParameter("@sum", req.TotalAmount)) > 0 ? 1 : 0;
    }

    public static DataTable GetRequestsForApproval()
    {
        return SqlHelper.ExecQuery(
            @"SELECT r.Id, u.Name_ Name_, rm.Name_ Name,
                         r.CheckInDate, r.CheckOutDate, r.TotalAmount
                  FROM BookingRequests r
                  JOIN Users u ON u.Id=r.UserId
                  JOIN Rooms rm ON rm.Id=r.RoomId
                  WHERE r.Status_='Забронировано'");
    }

    public static void ApproveRequest(int id, bool approve, string comment)
    {
        SqlHelper.ExecNonQuery(
            "UPDATE BookingRequests SET Status_=@st, Comment=@c WHERE Id=@id",
            new SqlParameter("@st", approve ? "Занято" : "Отклонено"),
            new SqlParameter("@c", comment ?? (object)DBNull.Value),
            new SqlParameter("@id", id));
    }

    public static DataTable GetReport(DateTime fromDate, DateTime toDate)
    {
        return SqlHelper.ExecQuery(
            @"SELECT u.Name_, rm.Name_ Name_, r.CheckInDate, r.CheckOutDate,
                         r.TotalAmount, r.Status_
                  FROM BookingRequests r
                  JOIN Users u ON u.Id=r.UserId
                  JOIN Rooms rm ON rm.Id=r.RoomId
                  WHERE r.CheckInDate>=@f AND r.CheckOutDate<=@t",
            new SqlParameter("@f", fromDate),
            new SqlParameter("@t", toDate));
    }
}
}
