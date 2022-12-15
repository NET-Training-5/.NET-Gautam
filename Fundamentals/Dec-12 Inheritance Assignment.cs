interface ILoanPayment
{
    public float NumberOfYears();
    public float MonthlyInterest();
    public float MonthlyPayment();   
}

class HomeLoan: ILoanPayment
{
    public HomeLoan(float i, float t, float p)
    {
        interest = i;
        term = t;
        principle = p;
    }

    static float interest;
    static float term;
    float principle;
    float mi = interest/12;
    float mt = term * 12;

    public float NumberOfYears() => term * 12 * -1;
    public float MonthlyInterest() => interest/12;
    public double MonthlyPayment() => (mi * principle) / (1 - Math.Pow(1 + mi, mt * -1));

    float ILoanPayment.MonthlyPayment()
    {
        throw new NotImplementedException();
    }
}

class CarLoan : HomeLoan
{
    public CarLoan(float i, float t, float p) : base(i, t, p)
    {
    }
}