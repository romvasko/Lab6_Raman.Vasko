// See https://aka.ms/new-console-template for more information

try {
    Console.WriteLine(Lab6_Login.Check("ttttt","123456","123456"));
    Console.WriteLine(Lab6_Login.Check("ttttt","abcabc1","abcabc1"));
    //Console.WriteLine(Lab6_Login.Check("ttttt","11111","22222"));
}
catch (Exception ex) {

    Console.WriteLine(ex.Message);
}

class Lab6_Login 
{
    public Lab6_Login() {

    }

    public static bool Check(string login, string pass, string passConf) 
    {
        if (login.Length >= 20 || login.Contains(" ")) { throw new WrongLoginException(); }
        if (pass != passConf || pass.Contains(" ") ||
            pass.Length > 20 || !IsNumberContains(pass)) {throw new WrongPasswordException();}
        return true;
    }
    static bool IsNumberContains(string input) {
        foreach (char c in input)
            if (Char.IsNumber(c))
                return true;
        return false;
    }
}

public class WrongLoginException : Exception {
    public WrongLoginException() : base("Wrong login") {

    }
    public WrongLoginException(string message)
    : base(message) {

    }
}

public class WrongPasswordException : Exception {
    public WrongPasswordException() : base("Wrong password") {
        
    }
    public WrongPasswordException(string message)
    : base(message) {

    }
}