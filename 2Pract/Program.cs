// "Перегрузка". Вариант 4

// В следующих задачах перегрузить операции: «*» на случай произведения пар чисел 
// (a1, b1) и (a2, b2): (a1, b1) * (a2, b2) = (a1 a2 – b2 b1, a1 b2 + a2 b1).

class Programm {


     static double Mult (double a1, double b1, double a2, double b2) {

        return a1 * a2 - b2 * b1; 
        }
        
     static int Mult (int a1, int b1, int a2, int b2) {
        
        return  a1 * b2 + a2 * b1; 
        }

    static void Main (string[] args) {

        int Result = Mult(8, 7, 2, 3);

        Console.WriteLine(Result);
    }  
}