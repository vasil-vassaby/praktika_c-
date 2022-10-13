int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;
while(distance > 10)
{
    if (friend == 1)
    {
        double time = distance/(firstFriendSpeed + dogSpeed);
        bool friend = 2;
    }
    else
    {
        double time = distance/(secondFriendSpeed + dogSpeed);
        bool friend = 1;
    }
    distance = distance-(firstFriendSpeed + secondFriendSpeed)* time;
    count++;
}
Console.WriteLine("Собака пробежала", count, "раз");
