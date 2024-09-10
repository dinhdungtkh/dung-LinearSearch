namespace  Dung.LinearSearch
{
    public class Bai21Recursion
    {
        public double calSalary(double salary, int n)
        {
            if (n == 0) 
                return salary;
            else  return calSalary((salary + (salary * 0.1)), n - 1);
        } 


        public double calculateSalary(double salary, int m)
        {
            for (int i = 0;i < m; i++) {
                salary = salary + salary * 0.1;
             }
            return salary;
        }
    }
}