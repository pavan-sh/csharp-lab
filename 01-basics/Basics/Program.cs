/*
Simple Salary Calculator
*/

Console.WriteLine("\nEnter your salary:");

string userSalaryInput = Console.ReadLine();

int salary = int.Parse(userSalaryInput);

//Console.WriteLine("\nEntered Salary is- \t" + salary+ "\n");

Console.WriteLine("\nChoose Tax Regime (Enter a or b) \n a) Old Tax Regime b) New Tax Regime: ");

string userTaxRegime = Console.ReadLine();

char taxRegime = char.Parse(userTaxRegime);

double tax = 0;
double salaryAfterTax = 0;

if(taxRegime=='a'){
    if(salary <= 250000){
        tax = 0;
    }
    else if(salary <= 500000){
        // apply tax on amount above 250000
        tax = (salary - 250000) * 0.05;
    }
    else if(salary <= 1000000){
        tax = 12500 + (salary - 500000) * 0.20;
    }
    else {
        tax = 112500 + (salary - 1000000) * 0.30;
    }

    salaryAfterTax = salary - tax;

    Console.WriteLine("\nWith old tax regime, salary is: "+salaryAfterTax+"\n");

} else {
    if (salary <= 400000){
        tax = 0;
    }
    else if (salary <= 600000){
        tax = (salary - 300000) * 0.05;
    }
    else if (salary <= 900000){
        tax = 15000 + (salary - 600000);
    }
    else if (salary <= 1200000){
        tax = 4500 + (salary - 900000) * 0.15;
    } 
    else {
        tax = 90000 + (salary - 1200000) * 0.20;
    }

    salaryAfterTax = salary - tax;

    Console.WriteLine("\nWith new tax regime, salary is: "+salaryAfterTax);
}
