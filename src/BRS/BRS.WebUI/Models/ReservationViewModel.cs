using System;
using BRS.Core.Models;

namespace BRS.WebUI.Models {
  public class ReservationViewModel {

    public int Id { get; set; }
    public Trip Trip { get; set; }
    public float Price { get; set; }
    public int TripId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int NoPassengers { get; set; }
    public string CardHolder { get; set; }
    public string CardNumber { get; set; }
    public string CVC { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ReservationDate { get; set; }
  }
}