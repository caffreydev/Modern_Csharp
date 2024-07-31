
PrintState(true);
PrintState(false);
PrintState(null);

static void PrintState(bool? state)
{
    var message = state switch
    {
        true => "State is true",
        false => "State is false",
        _ => "State is indeterminate"
    };

    Console.WriteLine(message);
}