namespace edx_Microsoft_DEV204.2x.Mod2_Lab1
{
    // BusinessEmployee Class inheriting from Employee Class
    class BusinessEmployee : Employee
    {
    // Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)
    // Sets baseSalary to 50000 for all BusinessEmployee objects
    public BusinessEmployee(String name) : base(name, 50000)
    {
    } 
    // Creates double variable called "bonusBudget" and assigns value to 1000
    public double bonusBudget = 1000;
    bonus budget
    public override String employeeStatus()
    {
        return toString() + " with a budget of " + this.bonusBudget;
    }
    }
}