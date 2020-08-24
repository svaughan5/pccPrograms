package sample;

public class Loan {

    //Declare fields
    private double salary;
    private double interestIncome;
    private double investmentIncome;
    private double otherIncome;
    private double totalIncome;
    private double annualInterestRate;
    private int term;
    private double loanAmt;
    private double monthlyPayment;
    private int totalAmtOfPayments;
    private double termInMonths;
    private double periodicPayment;
    private boolean isEligible;
    private double percentOfIncome;

    //Global constants
    final double ELIGIBILITY_CHECK = 0.25;

    //Default constructor
    public Loan(){
        setSalary(0.00);
        setInterestIncome(0.00);
        setInvestmentIncome(0.00);
        setOtherIncome(0.00);
        setTotalIncome(0.00);
        setAnnualInterestRate(0.00);
        setTerms(0);
        setLoanAmt(0.00);
        setMonthlyPayment(0.00);
        setTotalAmtOfPayments(0);
    }
    //Custom constructor
    public Loan(double salary, double interestIncome, double investmentIncome, double otherIncome,
                double totalIncome, double annualInterestRate, int term,
                double loanAmt, double monthlyPayment, int totalAmtOfPayments) {
        setSalary(salary);
        setInterestIncome(interestIncome);
        setInvestmentIncome(investmentIncome);
        setOtherIncome(otherIncome);
        setTotalIncome(totalIncome);
        setAnnualInterestRate(annualInterestRate);
        setTerms(term);
        setLoanAmt(loanAmt);
        setMonthlyPayment(monthlyPayment);
        setTotalAmtOfPayments(totalAmtOfPayments);
    }

    //-------------GETTERS AND SETTERS----------------

    //Salary
    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }

    //Interest income
    public double getInterestIncome() {
        return interestIncome;
    }

    public void setInterestIncome(double interestIncome) {
        this.interestIncome = interestIncome;
    }

    //Investment income
    public double getInvestmentIncome() {
        return investmentIncome;
    }

    public void setInvestmentIncome(double investmentIncome) {
        this.investmentIncome = investmentIncome;
    }

    //Other income
    public double getOtherIncome() {
        return otherIncome;
    }

    public void setOtherIncome(double otherIncome) {
        this.otherIncome = otherIncome;
    }

    //Total income
    public double getTotalIncome() {
        return totalIncome;
    }

    public void setTotalIncome(double totalIncome) {
        this.totalIncome = totalIncome;
    }

    //Annual Interest rate
    public double getAnnualInterestRate() {
        return annualInterestRate;
    }

    public void setAnnualInterestRate(double annualInterestRate) {
        this.annualInterestRate = (annualInterestRate / 100);
    }

    //Term
    public int getTerm() {
        return term;
    }

    public void setTerms(int term) {
        this.term = term;
        this.termInMonths = term * 12;
    }

    //sample.Loan amount
    public double getLoanAmt() {
        return loanAmt;
    }

    public void setLoanAmt(double loanAmt) {
        this.loanAmt = loanAmt;
    }

    //Monthly Payment
    public double getMonthlyPayment() {
        return monthlyPayment;
    }

    public void setMonthlyPayment(double monthlyPayment) {
        this.monthlyPayment = monthlyPayment;
    }

    //Total payments over loan
    public int getTotalAmtOfPayments() {
        return totalAmtOfPayments;
    }

    public void setTotalAmtOfPayments(int totalAmtOfPayments) {
        this.totalAmtOfPayments = totalAmtOfPayments;
    }

    public String getPeriodicPayment(){
        String periodicPaymentString = String.format("%.2f", this.periodicPayment);
        return periodicPaymentString;
    }

    public Boolean getEligibility(){ return this.isEligible; }

    public String getPercentOfIncome(){
        String percentOfIncomeString = String.format("%.2f", this.percentOfIncome);
        return percentOfIncomeString;
    }

    //--------------END OF GETTERS AND SETTERS-----------------

    public void calcPeriodicPayment(){
        double monthlyInterestRate = this.annualInterestRate / 12.0;

        double loanMonthlyPayment =
                (this.loanAmt*monthlyInterestRate) /
                        (1-Math.pow(1+monthlyInterestRate, -this.termInMonths));

        this.periodicPayment = loanMonthlyPayment;
    }

    public void determineIfEligible(){
        double monthlyIncome = this.totalIncome / 12.0;
        double percentageCheck = this.periodicPayment/monthlyIncome;

        setPercentOfIncome(percentageCheck);

        if(percentageCheck < ELIGIBILITY_CHECK){
            this.isEligible = true;
        }else if(percentageCheck > ELIGIBILITY_CHECK){
            this.isEligible = false;
        }
    }

    public void setPercentOfIncome(double percentOfIncome){
        this.percentOfIncome = (percentOfIncome * 100);
    }
}
