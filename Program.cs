

namespace PI;
public class Pi {

    static void Main(string[] argv){
        double s = 0.0;
        double pi;
        double divisor = 1.0;

        for(double counter = 1; counter <= 100; counter++){
            s = counter % 2 == 0
                ? s - Math.Pow(1/divisor, 3.0) 
                : s + Math.Pow(1/divisor, 3.0);
            divisor += 2;
        }
        pi = Math.Pow(s*32, 1.000/3.000);

        Console.WriteLine($"\n\n\tPI: {pi},\n\tSérie: {s}\n\n");
        Console.ReadLine();
    }
}
