namespace LearnEFByProject.Views;

public class MainView
{
public static int isNumiric(string str){
    try{
        int num = Convert.ToInt32(str);
        return num;
    }
    catch (Exception e)
    {
        return 0;
    }
}
    public static void redirect(string response)
    {
        if (response == "1")
        {
            CustomerView.Register();
        }
        
        else if (response == "2")
        {
            CustomerView.Login();
        }
        
        else
        {
            // to print the message in red
            // save the color of the console right now 
            // change color
            // create your output, then change the color again
            
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Please enter valid response 1 or 2 only");
            Console.ForegroundColor = originalColor;
            
            // to go to the first page
            Start();
        }
    }
    public static void Start()
    {
        string response = "";
        Console.WriteLine("Main Page");
        Console.WriteLine("Select one Option From All of this options");
        Console.WriteLine("1- create new customer");
        Console.WriteLine("2- Login with customer phone");
        Console.Write("What's Your response : ");
        
        response = Console.ReadLine();

        redirect(response);
    }
}