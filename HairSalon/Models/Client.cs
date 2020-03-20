namespace HairSalon.Models
{
  public class Client
  {
    public int ClientID {get; set;}
    public string Description {get; set;}
    public int StylistId {get; set;}
    public virtual Stylist stylist {get; set;}
  }
}