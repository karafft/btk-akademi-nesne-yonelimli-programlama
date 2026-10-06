using System;
using System.Runtime.CompilerServices;

namespace numbers;

class Employee
{

    // Full Property
    private string _firstName; //field
    private string _lastName;
    private Decimal _minsalary = 28000;
    private Decimal _salary;

    public String FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public String LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public Decimal Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            if (value < _minsalary)
            {
                Console.WriteLine("Maaş asgari ücretten az olamaz");
                _salary = _minsalary;
            }
            else
            {
                _salary = value;
            }
        }
    }

    public Employee() //parametresiz yapıcı
    {
    }

    public Employee(string firstName, string lastName, decimal salary) //parametreli yapıcı
    {
        _firstName = firstName;
        _lastName = lastName;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {Salary}";
    }
}
