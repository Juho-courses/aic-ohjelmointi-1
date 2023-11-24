bool isRunning = false;
int temperature = 31;

if (temperature > 30)
{
    isRunning = true;
}

if (isRunning)
{
    Console.WriteLine("motor is running");
}
else
{
    Console.WriteLine("motor not running");
}