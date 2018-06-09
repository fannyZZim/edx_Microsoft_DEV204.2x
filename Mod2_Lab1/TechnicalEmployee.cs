// TechnicalEmployee Class inheriting from Employee Class
class TechnicalEmployee : Employee
{
  // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
  // Sets baseSalary to 75000 for all TechnicalEmployee objects
  public TechnicalEmployee(String name) : base(name, 75000)
  {

  } 
}

