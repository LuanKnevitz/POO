namespace Ap2_1.Models.Domain;

public class Billing {
    
    public int BillingId { get; set; }
    public DateTime IssuanceDate { get; set; } 
    public DateTime DueDate { get; set; } 
    public double AmountCharge { get; set; } 
    
    public DateTime PaymentDate { get; set; } 
    public bool Status { get; set; }
    public int ClientId { get; set; }

    public Client Client;
    

    public Billing(){}
    
    public Billing( double amountCharge, int clientId)
    {   
        this.IssuanceDate = DateTime.Now;
        this.DueDate = DateTime.Now.AddDays(10);
        this.AmountCharge = amountCharge;
        this.Status = false;
        this.ClientId = clientId;
    }
}