namespace pottencial_dev_week.src.Models;

public class Contract 
{
    public Contract ()
    {
        this.Date = DateTime.Now;
        this.Value = 0;
        this.TokenId = "000";
        this.Pago = false;
    }

    public Contract (string token, double value) 
    {
        this.Date = DateTime.Now;
        this.TokenId = token;
        this.Value = value;
        this.Pago = false;
    }

    public DateTime Date { get; set; }
    public string TokenId { get; set; }
    public double Value { get; set; }
    public bool Pago { get; set; }



}