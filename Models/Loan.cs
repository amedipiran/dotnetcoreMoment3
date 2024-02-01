public class Loan
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public DateTime LoanDate { get; set; }
    public string Loaner { get; set; }
}