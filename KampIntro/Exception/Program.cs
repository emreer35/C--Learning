
// try
// {
// Find();

// }
// catch (RecordNotFoundException exception)
// {
//     System.Console.WriteLine(exception.Message);
// }

// bunun yerine action delegasyonu ile de yapabilirz 


HandleException(() =>
{
    Find();
});

void HandleException(Action action)
{
   try
   {
        action.Invoke();
   }
   catch (Exception exception)
   {
        Console.WriteLine(exception.Message);

   }
}

static void Find()
{
    List<string> names = new List<string>
{
    "1","2","3"
};

    if (!names.Contains("ahmet"))
    {
        throw new RecordNotFoundException("Hata Firlatildi");
    }
    else
    {
        System.Console.WriteLine("Record Found");
    }
}

