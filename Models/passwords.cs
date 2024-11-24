namespace PassGen.Models;

public static class Passwords {
    public static bool Check(string password){
        if(password== "123456"){
            return true;
        } else {
            return false;
        }
    }
}