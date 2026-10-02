public class Program
{
    public static void Main()
    {
        decimal deliveryCost = 5;

        string input;

        do
        {
            Console.WriteLine("Enter customer's name: ");
            input = Console.ReadLine();
        }
        while (input.IsWhiteSpace());
        string name = input;

        do
        {
            Console.WriteLine("Enter the number of books: ");
            input = Console.ReadLine();
        }
        while (input.IsWhiteSpace());
        int numberOfBooks = int.Parse(input);

        do
        {
            Console.WriteLine("Enter the price of a single book: ");
            input = Console.ReadLine();
        }
        while (input.IsWhiteSpace());
        decimal bookPrice = decimal.Parse(input);

        do
        {
            Console.WriteLine("Is the customer a student? [Y/N]");
            input = Console.ReadLine().ToLower();
        }
        while (input != "y" && input != "n");
        bool isStudent = input == "y";

        bool isDelivery = false;
        int deliveryMethod;
        do
        {
            Console.WriteLine("Select the delivery type");
            Console.WriteLine("1 for delivery, 2 for pick up");
            deliveryMethod = int.Parse(Console.ReadLine());

            if (deliveryMethod == 1)
            {
                isDelivery = true;
            }
            else if (deliveryMethod == 2)
            {
                isDelivery = false;
                deliveryCost = 0;
            }
            else
            {
                Console.WriteLine("Enter a valid input");
            }
        } while (!(deliveryMethod == 1 || deliveryMethod == 2));

        decimal total = bookPrice * numberOfBooks + deliveryCost;
        string status;

        switch (total)
        {
            case <= 0:
                status = "Invalid order.";
                break;
            case < 15:
                status = "That's one small order, thank you!";
                break;
            case >= 15:
                status = "Thank you for your order!";
                break;
        }

        Console.WriteLine
            (
            "\n\n------- ORDER CONFIRMATION -------\n" +
            $"Customer: {name} (Student: {isStudent})\n" +
            $"Number of books bought: {numberOfBooks}\n" +
            $"Price of a single book: {bookPrice}\n" +
            $"Delivery type: {(isDelivery)}\n" +
            $"-------------------------------------\n" +
            $"Delivery cost: {deliveryCost}\n" +
            $"TOTAL: {total}\n" +
            "--------------------------------------\n\n" +
            $"Status: {status}"
            );
    }
}