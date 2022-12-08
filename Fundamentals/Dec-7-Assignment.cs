public class MinMax {
   public static void Main() {
      int[] numbers = new int[6] {99, 95, 93, 89, 87, 65};
      
      int n = 6;
      int max = numbers[0];
      int min = numbers[0];
      int i;
      for(i=1; i<n; i++) {
         if(numbers[i]>max) {
            max = numbers[i];
         }
         if(numbers[i]<min) {
            min = numbers[i];
         }
      }
      Console.Write("Max number is" + max);
      Console.Write("Min number is" + min);
   }
}