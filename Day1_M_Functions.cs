review1.cs
package CS1;
public class UserValidator 
{
    private Cryptographer cryptographer;
    public boolean checkPasswordAndInitializeSession(String userName, String password) 
    {
        User user = UserGateway.findByName(userName);
        if (user != null) 
        {
            String codedPhrase = user.getPhraseEncodedByPassword();
            String phrase = cryptographer.decrypt(codedPhrase, password);
            if ("Valid Password".equals(phrase)) 
            {
                session.initialize();
                return true;
            }
        }      
        return false;
    }
}

review2.cs
var name = "Ryan McDermott";
var splitted_name = name.Split(" ");
name = $"His first name is {splitted_name[0]}, and his last name is {splitted_name[1]}"; 
Console.WriteLine(name);

review3.cs
public bool IsDOMNodePresent(string node)
{
    // ...
}

if (!IsDOMNodePresent(node))
{
    // ...
}

review4.cs
abstract class Airplane
{
    public abstract double GetCruisingAltitude();
}
 
class 777 : Airplane {
    public override double GetCruisingAltitude()
    {
        return GetMaxAltitude() - GetPassengerCount();
    }
}

class AirForceOne : Airplane {
    public override double GetCruisingAltitude()
    {
        return GetMaxAltitude();
    }
}

class Cessna :Airplane {
    public override double GetCruisingAltitude()
    {
        return GetMaxAltitude() - GetFuelExpenditure();
    }
}

review6.cs
public void CreateFile(string name)
{
   
        Touch(name);
    
}
public void CreateTempFile(string name)
{
  Touch("./temp/" + name);
}

review7.cs
class DBConnection
{
    public dbConnection( IOptions<dbConnectionOptions> options)
    {
    }
}





